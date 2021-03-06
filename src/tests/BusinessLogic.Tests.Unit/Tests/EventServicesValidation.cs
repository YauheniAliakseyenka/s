﻿using Autofac;
using BusinessLogic.DTO;
using BusinessLogic.Exceptions.EventExceptions;
using BusinessLogic.Services;
using BusinessLogic.Tests.Unit.DiContainer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogin.Unit.Tests
{
	internal class EventServicesValidation
	{
		private IContainer _container;

		[SetUp]
		public void Init()
		{
            _container = Container.GetContainer();	
		}

		[TestCase("The area #4", 1)]
		[TestCase("The area #5", 1)]
		[TestCase("The area #1", 3)]
		public  void Event_area_description_is_unique(string description, int eventId)
		{
			//Arrange
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();
			var eventArea = new EventAreaDto { Description = description, EventId = eventId };

			//Act
			var exception =  Assert.CatchAsync<EventAreaException>(async () => await eventAreaService.Create(eventArea));

			//Assert
			Assert.That(exception.Message, Is.Not.EqualTo("Area description isn't unique"));
		}

		[TestCase("The area #1", 1)]
		[TestCase("The area #3", 1)]
		[TestCase("The first area", 3)]
		public void Event_area_is_unique_throws_exception(string description, int eventId)
		{
            //Arrange
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();
            var eventArea = new EventAreaDto { Description = description, EventId = eventId };

			//Act
			var exception = Assert.CatchAsync<EventAreaException>(async () => await eventAreaService.Create(eventArea));

			//Assert
			StringAssert.AreEqualIgnoringCase(exception.Message, "Area description isn't unique");
		}

		[Test]
		public void Event_area_is_null_throws_exception()
		{
            //Arrange
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();

            //Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await eventAreaService.Create(null));
		}

		[Test, TestCaseSource(typeof(TestingData), "EventsValid")]
		public async Task Event_is_valid(EventDto e)
		{
			//Arrange
			var eventService = _container.Resolve<IEventService>();

            //Act
            await eventService.Create(e);

            //Assert
            Assert.AreEqual(e, await eventService.Get(e.Id));
		}

		[Test, TestCaseSource(typeof(TestingData), "EventsDateIsNotValid")]
		public void Events_date_is_valid_expected_exception(EventDto e)
		{
            //Arrange
            var eventService = _container.Resolve<IEventService>();

            //Act
            var exception = Assert.CatchAsync<EventException>(async () => await eventService.Create(e));

			//Assert
			StringAssert.AreEqualIgnoringCase(exception.Message, "Invalid date");
		}

		[Test, TestCaseSource(typeof(TestingData), "EventInThePast")]
		public void Events_in_the_past_expected_exception(EventDto e)
		{
            //Arrange
            var eventService = _container.Resolve<IEventService>();

            //Act
            var exception = Assert.CatchAsync<EventException>(async () => await eventService.Create(e));

			//Assert
			StringAssert.AreEqualIgnoringCase(exception.Message, "Attempt of creating event with a date in the past");
		}

		[Test]
		public void Event_is_null_throws_exception()
		{
            //Arrange
            var eventService = _container.Resolve<IEventService>();

            //Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await eventService.Create(null));
		}

		[Test]
		public void Delete_event_with_locked_seats_expected_exception()
		{
            //Arrange
            var eventService = _container.Resolve<IEventService>();

            //Act
            var exception = Assert.CatchAsync<EventException>(async () => await eventService.Delete(1));

			//Assert
			StringAssert.AreEqualIgnoringCase(exception.Message, "Not allowed to delete. Event has locked seat");
		}

		[Test]
		public async Task Delete_event_without_locked_seats()
		{
            //Arrange
            var eventService = _container.Resolve<IEventService>();

            //Act
            await eventService.Delete(3);

            //Assert
            Assert.IsNull(await eventService.Get(3));
		}

		[Test]
		public async Task Change_layout_of_event_with_locked_seats_expected_exception()
		{
            //Arrange
            var eventService = _container.Resolve<IEventService>();
            var update = await eventService.Get(1);
			update.LayoutId = 3;

			//Act
			var exception = Assert.CatchAsync<EventException>(async () => await eventService.Update(update));

			//Assert
			StringAssert.AreEqualIgnoringCase(exception.Message, "Not allowed to update layout. Event has locked seats");
		}

		[Test]
		public void Create_event_area_without_event_seats_expected_exception()
		{
			//Arrange
			var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();
            var create = new EventAreaDto
			{
				Seats = new List<EventSeatDto>(),
				CoordX = 1,
				CoordY = 2,
				Description = "Area #2",
				EventId = 1,
				Price = 240.25M
			};

			//Act
			var exception = Assert.CatchAsync<EventAreaException>(async () => await eventAreaService.Create(create));

			//Assert
			StringAssert.AreEqualIgnoringCase(exception.Message, "Invalid state of event area. Seat list is empty");
		}

		[Test]
		public void Create_event_area()
		{
			//Arrange
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();
            var create = new EventAreaDto
			{
				Seats = new List<EventSeatDto>
				{
					new EventSeatDto{State = 0, Number = 1, Row = 1},
					new EventSeatDto{State = 0, Number = 2, Row = 1},
					new EventSeatDto{State = 0, Number = 3, Row = 1},
					new EventSeatDto{State = 0, Number = 1, Row = 2}
				},
				CoordX = 1,
				CoordY = 2,
				Description = "Area #2",
				EventId = 1,
				Price = 155.35M,
				Id = 10
			};

			Assert.DoesNotThrowAsync(async () => await eventAreaService.Create(create));
		}

		[Test]
		public void Delete_event_area_expected_exception()
		{
            //Arrange
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();

            //Act
            var exception = Assert.CatchAsync<EventAreaException>(async () => await eventAreaService.Delete(1));

			//Assert
			StringAssert.AreEqualIgnoringCase(exception.Message, "Not allowed to delete. Area has locked seat");
		}

		[Test]
		public async Task Delete_event_area()
		{
            //Arrange
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();

            //Act
            await eventAreaService.Delete(3);

            //Assert
            Assert.IsNull(await eventAreaService.Get(3));
		}

		[Test]
		public async Task Update_event_area_without_event_seats_expected_exception()
		{
            //Arrange
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();
            var update = await eventAreaService.Get(1);
			update.Seats = new List<EventSeatDto>();

			//Act
			var exception = Assert.CatchAsync<EventAreaException>(async () => await eventAreaService.Update(update));

			//Assert
			StringAssert.AreEqualIgnoringCase(exception.Message, "Invalid state of event area. Seat list is empty");
		}

		[Test]
		public async Task Update_event_area_with_one_added_seat()
		{
            //Arrange
            var eventSeatService = _container.Resolve<IStoreService<EventSeatDto, int>>();
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();
            var update = await eventAreaService.Get(1);
			var seats = await eventSeatService.GetList();
			update.Seats = seats.Where(x => x.EventAreaId == update.Id).ToList();
			update.Seats.Add(new EventSeatDto { Row = 3, Number = 1, State = 0, EventAreaId = 1 });

			//Assert
			Assert.DoesNotThrowAsync(async () => await eventAreaService.Update(update));
		}

		[Test]
		public async Task Update_event_area_with_one_deleted_seat()
		{
            //Arrange
            var eventSeatService = _container.Resolve<IStoreService<EventSeatDto, int>>();
            var eventAreaService = _container.Resolve<IStoreService<EventAreaDto, int>>();
            var update = await eventAreaService.Get(1);
			var seats = await eventSeatService.GetList();
			update.Seats = seats.Where(x => x.EventAreaId == update.Id).ToList();
            update.Seats.RemoveAt(1);

            //Assert
            Assert.DoesNotThrowAsync(async () => await eventAreaService.Update(update));
        }

		[Test, TestCaseSource(typeof(TestingData), "EventsByDateFilter")]
		public async Task Get_published_events_with_filter_by_date(EventDto entity)
		{
			//Arrange
			var eventService = _container.Resolve<IEventService>();
            var isFiltered = true;
			var culture = "en";

			//Act
			var events = await eventService.GetPublishedEvents(FilterEventOptions.Date, 
				entity.Date.ToString(CultureInfo.CreateSpecificCulture(culture)), culture);
			events.ToList().ForEach(x =>
			{
				if (x.Event.Date.Date != entity.Date.Date)
					isFiltered = false;
			});

			//Assert
			Assert.IsTrue(isFiltered);
		}

		[TestCase("Parsifal")]
		[TestCase("The Mastersingers of Nuremberg")]
		public async Task Get_published_events_with_filter_by_title(string title)
		{
            //Arrange
            var eventService = _container.Resolve<IEventService>();
            var isFiltered = true;

			//Act
			var events = await eventService.GetPublishedEvents(FilterEventOptions.Title, title);
			events.ToList().ForEach(x =>
			{
				if (!x.Event.Title.Contains(title))
					isFiltered = false;
			});

			//Assert
			Assert.IsTrue(isFiltered);
		}
	}
}

﻿using BusinessLogic.DTO;
using System.Linq;
using WcfBusinessLogic.Core.Contracts.Data;

namespace WcfBusinessLogic.Core.Helpers.Parsers
{
    internal class VenueParser
    {
        public static Venue ToVenueContract(VenueDto from)
        {
            return new Venue
            {
                Address = from.Address,
                Description =from.Description,
                Id = from.Id,
                Name = from.Name,
                Phone = from.Phone,
                Timezone  = from.Timezone,
                LayoutList = from.LayoutList?.Select(x=>LayoutParser.ToLayoutContract(x)).ToList(),
				NameWithOffset = from.NameWithOffset
            };
        }

        public static VenueDto ToVenueDto(Venue from)
        {
            return new VenueDto
            {
                Address = from.Address,
                Description = from.Description,
                Id = from.Id,
                Name = from.Name,
                Phone = from.Phone,
                Timezone = from.Timezone,
				LayoutList = from.LayoutList?.Select(x => LayoutParser.ToLayoutDto(x)).ToList()
            };
        }
    }
}

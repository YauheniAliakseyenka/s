﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using BusinessLogic.Services;
using BusinessLogic.DTO;
using BusinessLogic.Exceptions;
using TicketManagementMVC.Helpers;

namespace TicketManagementMVC.Infrastructure.Authentication
{
    internal class UserStore : IUserClaimStore<User>, IUserPasswordStore<User>, IUserEmailStore<User>
    {
		bool disposed = false;
		private IUserService _userService;

        ~UserStore()
        {
            Dispose(false);
        }

        public UserStore(IUserService userService)
        {
            _userService = userService;
        }

        public Task AddClaimAsync(User user, Claim claim)
        {
			throw new NotImplementedException();
        }

		public Task CreateAsync(User user)
		{
			var userModel = maptToUserDto(user);
			userModel.Id = Guid.NewGuid().ToString();

			return _userService.Create(userModel);
		}

        public Task DeleteAsync(User user)
        {
			return _userService.Delete(user.Id);
        }

        public async Task<User> FindByIdAsync(string userId)
        {
            var user = await _userService.Get(userId);
            
            return user != null ? mapToUser(user) : null;
        }

        public async Task<User> FindByNameAsync(string userName)
        {
            var data = await _userService.FindBy(x => x.UserName.Equals(userName, StringComparison.Ordinal));
			var user = data.FirstOrDefault();

            return user != null ? mapToUser(user) : null;
        }

        public async Task<IList<Claim>> GetClaimsAsync(User user)
        {
			var userRoles = await _userService.GetRoles(user.UserName);
			IList<Claim> claims = new List<Claim>();

			userRoles.ToList().ForEach(x =>
            {
                claims.Add(new Claim(ClaimTypes.Role, x));
            });
			
            return claims;
        }

        public Task<string> GetPasswordHashAsync(User user)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public async Task<bool> HasPasswordAsync(User user)
        {
            var userModel = await _userService.Get(user.Id);

            return userModel.PasswordHash != null;
        }

        public Task RemoveClaimAsync(User user, Claim claim)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(User user, string passwordHash)
        {
            user.PasswordHash = passwordHash;

            return Task.FromResult(0);
        }

        public async Task UpdateAsync(User user)
        {
			var updateUser = await _userService.Get(user.Id);

			if(updateUser != null)
			{
				updateUser.Surname = user.Surname;
				updateUser.Firstname = user.Firstname;
				updateUser.Email = user.Email;
				updateUser.PasswordHash = user.PasswordHash;
				updateUser.Amount = user.Amount;
				updateUser.Culture = user.Culture;
				updateUser.Email = user.Email;
				updateUser.Timezone = user.Timezone;
			}

			 await _userService.Update(updateUser);
        }

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposed)
				return;

			if(disposing)
			{
			}

			disposed = true;
		}

		private User mapToUser(UserDto user)
        {
            return new User
			{
                Surname = user.Surname,
                UserName = user.UserName,
                Email = user.Email,
                Firstname = user.Firstname,
                Id = user.Id,
                PasswordHash = user.PasswordHash,
				Culture = user.Culture,
				Amount = user.Amount,
				Timezone = user.Timezone
            };
        }

        private UserDto maptToUserDto(User user)
        {
            return new UserDto
			{
                Surname = user.Surname,
                UserName = user.UserName,
                Email = user.Email,
                Firstname = user.Firstname,
                Id = user.Id,
                PasswordHash = user.PasswordHash,
				Culture = user.Culture,
				Timezone = user.Timezone,
				Amount = user.Amount
			};
        }

		public Task SetEmailAsync(User user, string email)
		{
			user.Email = email;

			return Task.FromResult(0);
		}

		public Task<string> GetEmailAsync(User user)
		{
			return Task.FromResult(user.Email);
		}

		public Task<bool> GetEmailConfirmedAsync(User user)
		{
			throw new NotImplementedException();
		}

		public Task SetEmailConfirmedAsync(User user, bool confirmed)
		{
			throw new NotImplementedException();
		}

		public async Task<User> FindByEmailAsync(string email)
		{
			var data = await _userService.FindBy(x => x.Email.Equals(email, StringComparison.Ordinal));
			var user = data.FirstOrDefault();

			return user != null ? mapToUser(user) : null;
		}
	}
}
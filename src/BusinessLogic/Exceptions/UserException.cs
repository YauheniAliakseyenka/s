﻿using System;

namespace BusinessLogic.Exceptions
{
	internal class UserException : Exception
	{
		public UserException()
		{
		}

		public UserException(string message)
			: base(message)
		{
		}

		public UserException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}

using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Account : IEntity
	{
		public int AccountId { get; set; }
		public int AccountTypeId { get; set; }
		public int AccountStatusId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public string ProfilePhotoPath { get; set; }
	}
}


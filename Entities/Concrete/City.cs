using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class City : IEntity
	{
		public int CityId { get; set; }
		public int CountryId { get; set; }
		public string CityName { get; set; }
		public int Priority { get; set; }
		public bool Visible { get; set; }
	}
}


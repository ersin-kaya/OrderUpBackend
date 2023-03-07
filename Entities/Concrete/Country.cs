using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Country : IEntity
	{
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int Priority { get; set; }
        public bool Visible { get; set; }
    }
}


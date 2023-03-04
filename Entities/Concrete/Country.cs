using System;
using Entities.Abstract;

namespace Entities.Concrete
{
	public class Country : IEntity
	{
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool Visible { get; set; }
    }
}


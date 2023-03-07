using System;
using Core.Entities;

namespace Entities.DTOs
{
	public class CityDetailDto : IDto
	{
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Priority { get; set; }
        public bool Visible { get; set; }
        public string CountryName { get; set; }
        public int NumberOfDistricts { get; set; }
    }
}


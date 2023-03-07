using System;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICityService
	{
        CityDetailDto GetCityDetails(int cityId);
        List<City> GetAllByCountryId(int countryId);
        City GetById(int cityId);
        void Add(City city);
        void Update(City city);
        void Delete(City city);
    }
}


using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Add(City city)
        {
            _cityDal.Add(city);
        }

        public void Delete(City city)
        {
            _cityDal.Delete(city);
        }

        public List<City> GetAllByCountryId(int countryId)
        {
            return _cityDal.GetAll(c=>c.CountryId == countryId);
        }

        public City GetById(int cityId)
        {
            return _cityDal.Get(c=>c.CityId == cityId);
        }

        public CityDetailDto GetCityDetails(int cityId)
        {
            return _cityDal.GetCityDetails(cityId);
        }

        public void Update(City city)
        {
            _cityDal.Update(city);
        }
    }
}


using System;
using Business.Abstract;
using Business.Constants.Messages.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(Messages.CityAdded);
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult(Messages.CityDeleted);
        }

        public IDataResult<List<City>> GetAllByCountryId(int countryId)
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(c=>c.CountryId == countryId), Messages.CitiesListed);
        }

        public IDataResult<City> GetById(int cityId)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c=>c.CityId == cityId), Messages.CityListed);
        }

        public IDataResult<CityDetailDto> GetCityDetailsById(int cityId)
        {
            return new SuccessDataResult<CityDetailDto>(_cityDal.GetCityDetailsById(cityId), Messages.CityDetailsListed);
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Messages.CityUpdated);
        }
    }
}


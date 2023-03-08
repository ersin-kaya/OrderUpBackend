using System;
using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Business.Constants.Messages.Concrete;

namespace Business.Concrete
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IResult Add(Country country)
        {
            if (country.CountryName.Length >= 2)
            {
                _countryDal.Add(country);
                return new SuccessResult(Messages.CountryAdded);
            }
            else
            {
                return new ErrorResult(Messages.CountryNameInvalid);
            }
        }

        public IResult Delete(Country country)
        {
            _countryDal.Delete(country);
            return new SuccessResult(Messages.CountryDeleted);
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll(), Messages.CountriesListed);
        }

        public IDataResult<Country> GetById(int countryId)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(c=>c.CountryId == countryId));
        }

        public IResult Update(Country country)
        {
            _countryDal.Update(country);
            return new SuccessResult(Messages.CountryUpdated);
        }
    }
}


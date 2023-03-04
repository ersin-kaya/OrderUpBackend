using System;
using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public void Add(Country country)
        {
            _countryDal.Add(country);
        }

        public void Delete(Country country)
        {
            _countryDal.Delete(country);
        }

        public List<Country> GetAll()
        {
            return _countryDal.GetAll();
        }

        public Country GetById(int countryId)
        {
            return _countryDal.GetById(countryId);
        }

        public void Update(Country country)
        {
            _countryDal.Update(country);
        }
    }
}


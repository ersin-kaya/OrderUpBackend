using System;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCountryDal : ICountryDal
    {
        List<Country> _countries;

        public InMemoryCountryDal()
        {
            _countries = new List<Country> {
                new Country { CountryId=1, CountryName="Türkiye", Visible=true },
                new Country { CountryId=2, CountryName="Azerbaycan", Visible=false },
                new Country { CountryId=3, CountryName="Katar", Visible=false },
                new Country { CountryId=4, CountryName="Almanya", Visible=false },
                new Country { CountryId=5, CountryName="Rusya", Visible=false },
            };
        }

        public void Add(Country country)
        {
            _countries.Add(country);
        }

        public void Delete(Country country)
        {
            Country countryToDelete = _countries.SingleOrDefault(c=>c.CountryId == country.CountryId);
            _countries.Remove(countryToDelete);
        }

        public List<Country> GetAll()
        {
            return _countries;
        }

        public Country GetById(int countryId)
        {
            return _countries.Where(c=>c.CountryId == countryId).First();
        }

        public void Update(Country country)
        {
            Country countryToUpdate = _countries.SingleOrDefault(c => c.CountryId == country.CountryId);
            countryToUpdate.CountryName = country.CountryName;
            countryToUpdate.Visible = country.Visible;
        }
    }
}


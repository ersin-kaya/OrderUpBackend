using System;
using System.Linq.Expressions;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICountryService
	{
        List<Country> GetAll();
        Country GetById(int countryId);
        void Add(Country country);
        void Update(Country country);
        void Delete(Country country);
    }
}


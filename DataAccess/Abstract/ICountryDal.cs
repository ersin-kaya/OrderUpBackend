using System;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface ICountryDal
	{
		List<Country> GetAll();
		Country GetById(int countryId);
		void Add(Country country);
		void Update(Country country);
		void Delete(Country country);
	}
}


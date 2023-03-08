using System;
using System.Linq.Expressions;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICountryService
	{
        IDataResult<List<Country>> GetAll();
        IDataResult<Country> GetById(int countryId);
        IResult Add(Country country);
        IResult Update(Country country);
        IResult Delete(Country country);
    }
}


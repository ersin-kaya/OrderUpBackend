using System;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICityService
	{
        IDataResult<CityDetailDto> GetCityDetailsById(int cityId);
        IDataResult<List<City>> GetAllByCountryId(int countryId);
        IDataResult<City> GetById(int cityId);
        IResult Add(City city);
        IResult Update(City city);
        IResult Delete(City city);
    }
}


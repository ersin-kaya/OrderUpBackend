using System;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	public interface ICityDal : IEntityRepository<City>
	{
		CityDetailDto GetCityDetailsById(int cityId);
	}
}


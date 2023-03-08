using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<City, OrderUpContext>, ICityDal
    {
        public CityDetailDto GetCityDetailsById(int cityId)
        {
            using (OrderUpContext context = new OrderUpContext())
            {
                var result = from city in context.Cities
                             join country in context.Countries
                             on city.CountryId equals country.CountryId
                             where city.CityId == cityId
                             select new CityDetailDto
                             {
                                 CityId=city.CityId, CityName=city.CityName, Priority=city.Priority, Visible=city.Visible, CountryName=country.CountryName
                             };

                return result.Single();
            }
        }
    }
}


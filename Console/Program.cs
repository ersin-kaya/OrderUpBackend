using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CountryManager countryManager = new CountryManager(new EfCountryDal());

CityManager cityManager = new CityManager(new EfCityDal());

//cityManager.Add(new City { CityName="İstanbul", CountryId=1 });

var result = cityManager.GetCityDetailsById(2);

Console.WriteLine(result.Data.CityName + " - " + result.Data.CountryName);
Console.WriteLine(result.Message);
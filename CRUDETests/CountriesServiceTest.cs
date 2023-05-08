using System;
using System.Collections.Generic;
using CRUDEAssistant.ServiceContracts;

namespace CRUDETests
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService _countriesService;

        public CountriesServiceTest (ICountriesService countriesService)
        {
            _countriesService = countriesService;
        }
        //When CountryAddRequest is null, it should throw ArgumentNullException
        public void AddRequest_NullCountry()
        {
            //Arrange

            //Act

            //Assert
        }

        //When the CountryName is null, it should throw ArgumentException


        //When the CountryName is duplicate, it should throw ArgumentException


        //When you supply proper country name, it should insert (add) the country to the existing list of countries

    }
}

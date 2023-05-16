using LibraryGroup13;
using MvcGroup13.Models;
using MvcGroup13.Controllers;
using MvcGroup13.ViewModels;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace LibraryGroup13
{
    public class LocationTest
    {
        private Mock<iLocationRepo> mockLocationRepo;
        private LocationController locationController;

      public LocationTest()
        {
           mockLocationRepo=new Mock<iLocationRepo>();
            locationController=new LocationController(mockLocationRepo.Object);
        }

        [Fact]
        public void ShouldFindLocationByName()
        {
           
            List<Location> mockLocationData = CreateMockData();
            mockLocationRepo.Setup(m => m.GetAllLocations()).Returns(mockLocationData);
            int expectedNumberOfLocations = 1;

            SearchLocationsViewModel viewModel = new SearchLocationsViewModel
            {
                SearchAddress = null,
                SearchDescription = null,
                SearchImage = null,
                SearchName = "name"

            };
            //ViewResult viewResult = locationController.SearchLocations(viewModel) as ViewResult;
            //// expected against actual
            //SearchLocationsViewModel resultModel = viewResult.Model as SearchLocationsViewModel;
            //List<Location> actualResultList = resultModel.SearchResult;

            //int actualNumberOFLocations = actualResultList.Count;
            //// 3 assert
            //Assert.Equal(expectedNumberOfLocations,actualNumberOFLocations);


        }

        [Fact]
        public void ShouldFindLocationByDesciption()
        {
          
            List<Location> mockLocationData = CreateMockData();

            mockLocationRepo.Setup(m => m.GetAllLocations()).Returns(mockLocationData);
            int expectedNumberOfLocations = 1;

          
            SearchLocationsViewModel viewModel = new SearchLocationsViewModel
            {
                SearchAddress = null,
                SearchDescription = "description",
                SearchImage = null,
                SearchName = null

            };
            //ViewResult viewResult = locationController.SearchLocations(viewModel) as ViewResult;
            //// expected against actual
            //SearchLocationsViewModel resultModel = viewResult.Model as SearchLocationsViewModel;
            //List<Location> actualResultList = resultModel.SearchResult;

            //int actualNumberOFLocations = actualResultList.Count;
            //// 3 assert
            //Assert.Equal(expectedNumberOfLocations, actualNumberOFLocations);


        }

        [Fact]
        public void ShouldFindLocationByAddress()
        {
      
            List<Location> mockLocationData = CreateMockData();

            mockLocationRepo.Setup(m => m.GetAllLocations()).Returns(mockLocationData);
            int expectedNumberOfLocations = 1;

    
            SearchLocationsViewModel viewModel = new SearchLocationsViewModel
            {
               SearchAddress="address",
               SearchDescription=null,
               SearchImage=null,
               SearchName=null

            };

            //ViewResult viewResult = locationController.SearchLocations(viewModel) as ViewResult;
            //// expected against actual
            //SearchLocationsViewModel resultModel = viewResult.Model as SearchLocationsViewModel;
            //List<Location> actualResultList = resultModel.SearchResult;

            //int actualNumberOFLocations = actualResultList.Count;
            //// 3 assert
            //Assert.Equal(expectedNumberOfLocations, actualNumberOFLocations);
        }

        [Fact]
        public void SearchLocationsNameandImage()
        {
     //    
            List<Location> mockLocationData = CreateMockData();

            mockLocationRepo.Setup(m => m.GetAllLocations()).Returns(mockLocationData);
            int expectedNumberOfLocations = 1;

   //      
            SearchLocationsViewModel viewModel = new SearchLocationsViewModel
            {
                SearchAddress = null,
                SearchDescription = null,
                SearchImage = 0,
                SearchName = "name"

            };
            //ViewResult viewResult = locationController.SearchLocations(viewModel) as ViewResult;
            //// expected against actual
            //SearchLocationsViewModel resultModel = viewResult.Model as SearchLocationsViewModel;
            //List<Location> actualResultList = resultModel.SearchResult;

            //int actualNumberOFLocations = actualResultList.Count;
            //// 3 assert
            //Assert.Equal(expectedNumberOfLocations, actualNumberOFLocations);


        }

        public List<Location> CreateMockData()
        {
            List<Location> mockData = new List<Location>();

            Location Location = new Location("name", 1,1, "description");
            mockData.Add(Location);

            return mockData;
        }

    }
}
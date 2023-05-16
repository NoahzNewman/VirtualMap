using LibraryGroup13;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcGroup13.Models;
using MvcGroup13.ViewModels;
using System.Drawing;

namespace MvcGroup13.Controllers
{
    public class LocationController : Controller
    {

        private iLocationRepo ILocationRepo;
       
        public LocationController(iLocationRepo iLocationRepo)
        {
            ILocationRepo = iLocationRepo;
        }
        //public void CreateDropDownLists()
        //{
        //    List<Location> allLocations = ILocationRepo.GetAllLocations();
        //    var allNames = allLocations.Select(v => v.LocationName).Distinct().ToList();
        //    List<SelectListItem> listOfAllNames = allNames.Select(eachName => new SelectListItem { Text = eachName, Value = eachName }).ToList();
        //    ViewData["AllNames"] = listOfAllNames;

        //    allLocations = ILocationRepo.GetAllLocations();
        //    var allDescriptions = allLocations.Select(v => v.LocationDescription).Distinct().ToList();
        //    List<SelectListItem> listOfAllDescriptions = allDescriptions.Select(eachDescription => new SelectListItem { Text = eachDescription, Value = eachDescription }).ToList();
        //    ViewData["Alldescriptions"] = listOfAllDescriptions;

        //     allLocations = ILocationRepo.GetAllLocations();
        //    var allAddresses = allLocations.Select(v => v.Address).Distinct().ToList();
        //    List<SelectListItem> listOfAllAddresses = allAddresses.Select(eachAddress => new SelectListItem { Text = eachAddress, Value = eachAddress }).ToList();
        //    ViewData["AllAddresses"] = listOfAllAddresses;

        //}
        //[HttpGet]
        //public IActionResult SearchLocations()
        //{
        //    CreateDropDownLists();
        //    SearchLocationsViewModel vm = new SearchLocationsViewModel();
        //    vm.SearchResult = new List<Location>();
        //    return View(vm);
        //}
        //[HttpPost]
        //public IActionResult SearchLocations(SearchLocationsViewModel viewModel)
        //{
        //    CreateDropDownLists();
        //    List<Location> allLocations = ILocationRepo.GetAllLocations();
        //    if (viewModel.SearchName != null)
        //    {
        //        allLocations = allLocations.Where(m => m.LocationName == viewModel.SearchName).ToList();
        //    }
        //    if (viewModel.SearchDescription != null)
        //    {
        //        allLocations = allLocations.Where(m => m.LocationDescription == viewModel.SearchDescription).ToList();
        //    }
        //    if (viewModel.SearchAddress != null)
        //    {
        //        allLocations = allLocations.Where(m => m.Address == viewModel.SearchAddress).ToList();
        //    }
        //    if (viewModel.SearchImage != null)
        //    {
        //        allLocations = allLocations.Where(a => a.Image == viewModel.SearchImage).ToList();
        //    }



        //    viewModel.SearchResult = allLocations;
        //    return View(viewModel);
        //}
        public static byte[] ImageToByte(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();

            byte[] bytes = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));

            return bytes;
        }

        [HttpGet]
        public IActionResult AddLocation()
        {
            //CreateDropDownLists();
            return View();
        }
        [HttpPost]
        public IActionResult AddLocation(AddLocationViewModel viewModel)
        {
           

            if(ModelState.IsValid)
            {
                Location location = new Location(viewModel.Name, viewModel.Latitude.Value, viewModel.Longitude.Value, viewModel.Description);

                if(viewModel.Image != null)
                {

                    location.Image = ImageToByte(viewModel.Image);
                    
                }

                int LocationID = ILocationRepo.AddLocation(location);

                return RedirectToAction("ListAllLocation");

            }
            else
            {
                return View(viewModel);
            }
           

        }
        [HttpGet]
        public IActionResult EditLocation(int locationID)
        {
            Location location = ILocationRepo.FindLocation(locationID);
            return View(location);
        }
        [HttpPost]
        public IActionResult EditLocation(Location modifiedLocation)
        {
            if (ModelState.IsValid)
            {
                ILocationRepo.UpdateLocation(modifiedLocation);
                return RedirectToAction("ListAllLocation");
            }
            else
            {
                return View(modifiedLocation);
            }
        }

        public IActionResult ListAllLocation()
        {
            List<Location> locationList = ILocationRepo.GetAllLocations();

            return View(locationList);

        }

        [HttpGet]
        public IActionResult DeleteLocation(int LocationId)
        {
            Location location = ILocationRepo.FindLocation(LocationId);
            return View(location);
        }

        [HttpPost]
        public IActionResult DeleteLocation(Location location)
        {
            int LocationId = location.LocationID;

            if(ModelState.IsValid)
            {
                ILocationRepo.DeleteLocation(location);
                return RedirectToAction("ListAllLocation");
            }
            else
            {
                return View(location);
            }

            
               
        }
        //
        [HttpGet]
        public IActionResult LocationDetails(int locationID)
        {
            Location location = ILocationRepo.FindLocation(locationID);

            

            return View(location);

          

        }
    }
}

//create a map controller with view for map 
//MapSelect within map controller 
//method called GetAllInfo for map
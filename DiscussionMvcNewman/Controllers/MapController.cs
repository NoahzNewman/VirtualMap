using DiscussionMvcNewman.Data;
using LibraryGroup13;
using Microsoft.AspNetCore.Mvc;

namespace MvcGroup13.Controllers
{
    public class MapController : Controller
    {
        private ApplicationDbContext _database;

        public MapController(ApplicationDbContext dbContext) 
        {
            _database = dbContext;
        }

        public JsonResult GetAllLocations()
        {

            List<Location> allLocations = _database.Location.ToList();

            return Json(allLocations);

        }


        public IActionResult CreateMapView()
        {
            JsonResult allLocations = GetAllLocations();
            return View();
        }


    }
}
//create a map controller with view for map 
//MapSelect within map controller 
//method called GetAllInfo for map

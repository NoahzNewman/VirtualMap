using DiscussionMvcNewman.Data;
using LibraryGroup13;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MvcGroup13.Models
{
    public class LocationRepo : iLocationRepo
    {
        private ApplicationDbContext _database;
        private IHttpContextAccessor _contextAccessor;

        public LocationRepo(ApplicationDbContext database, IHttpContextAccessor contextAccessor)
        {
            _database = database;
            _contextAccessor = contextAccessor;
        }

        public int AddLocation(Location location)
        {
            _database.Location.Add(location);
            _database.SaveChanges();
            int locationID = location.LocationID;
            return locationID;
        }

        public void DeleteLocation(Location location)
        {
            _database.Location.Remove(location);
            _database.SaveChanges();
        }

        public Location FindLocation(int locationID)
        {
            Location location=_database.Location.Find(locationID);
            return location;
        }

        public List<Location> GetAllLocations()
        {
            List<Location> allLocations = _database.Location.ToList();

            return allLocations;
        }

        public string GetUserID()
        {
            string UserID = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return UserID;
        }

        public void UpdateLocation(Location modifiedLocation)
        {
            _database.Location.Update(modifiedLocation);
            _database.SaveChanges();
        }
    }
}

using LibraryGroup13;


namespace MvcGroup13.Models
{
    public interface iLocationRepo
    {
        public List<Location> GetAllLocations();
        public int AddLocation(Location location);

        public string GetUserID();
      public  Location FindLocation(int locationID);
       public  void UpdateLocation(Location modifiedLocation);

        public void DeleteLocation(Location location);

       
    }
}

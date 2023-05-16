using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGroup13
{
    public class Location
    {


        public string LocationName { get; set; }
        public string? LocationDescription { get; set; }



        
        public double Longitude { get; set; }

        
        public double Latitude { get; set; }
        

        [Key]
        public int LocationID { get; set; }

        //[ForeignKey("AppUserID")] //message to the entity framework to not create another FK
        //public AppUser Appuser { get; set; }

        //public LocationTypeOptions LocationType { get; set; }


        // public List<Location> Images { get; set; }

        public byte[]? Image { get; set; }

        //public Images Images { get; set; }
       

        //public Campus Campus { get; set; }
       
        //You are missing variables in your constructor
        public Location(string name, double latitude, double longitude, string? description)
        {
            LocationName = name;
            Longitude = longitude;
            Latitude = latitude;
            LocationDescription = description;
          
            

        }
        public Location()
        {

        }

        
    

    }
}

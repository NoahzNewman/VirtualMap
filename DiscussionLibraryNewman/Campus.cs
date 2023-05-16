using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LibraryGroup13
{
    public class Campus
    {
        [Key]
        public int CampusID { get; set; }
        public string CampusName { get; set; }

        public int Longitude { get; set; }
        public int Latitude { get; set; }

        public int LocationID { get; set; }
        [ForeignKey("LocationID")]
        public Location Location { get; set; }

        //Where is the constuctor? There needs to be a constructor for every class   Done
        public Campus()
        {

        }

        //draw a geographic area on a map
        //add longitude and latitude for each point to create a boundary 
        //add radius 
    }
}
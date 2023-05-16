using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LibraryGroup13
{
    public class TourTime
    {
        [Key]
        public int TourID { get; set; }

        [ForeignKey("RequestID")] //message to the entity framework to not create another FK
       

        public DateTime TourDate {get; set;}

        //public string TourGuideName { get; set;}
            
        public string TourType { get; set;}

        public DateTime TourDuration {get; set;}

        public DateTime createTourTime { get; set;}

        //Why is this here?   Done


        public TourTime(string tourType, string tourGuideName, DateTime tourDate)
        {
            TourType = tourType;
            //TourGuideName = tourGuideName;
            TourDate = tourDate;
        }

        public TourTime()
        {

        }

        //tour type
        //duration
        
    }
}

//
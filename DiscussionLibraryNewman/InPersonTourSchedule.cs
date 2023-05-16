using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LibraryGroup13
{
    public class InPersonTourSchedule
    {
        //Why is the requestID a string? it can be an int  Done
        [Key]
        public int RequestID { get; set; }

        public int TourID { get; set; }

        //You need to declare a TourID variable. Not just make a foreignkey reference  Done
        [ForeignKey("TourID")] 
        public TourTime CreateTourTime { get; set; }
        public DateTime DateRequested { get; set; }

       

        public InPersonTourSchedule(DateTime dateRequested)
        {
         
            DateRequested = dateRequested;
        }
        public InPersonTourSchedule()
        {

        }

    }
}
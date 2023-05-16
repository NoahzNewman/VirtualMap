using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LibraryGroup13
{
    public class Images
    {
        //Waiting to code in images 
        [Key]
        public int ImageID { get; set; }

        [ForeignKey("LocationID")] 
       
        public string ImageName { get; set; }

        public byte Image { get; set; }

      //.public List<Location> Image { get; set; }
      
      

        public Images(int imageID, string imageName, byte image)
        {
            ImageID = imageID;
            ImageName = imageName;
            Image = image;
        }
        public Images()
        {
            
        }
            
      
    }
}
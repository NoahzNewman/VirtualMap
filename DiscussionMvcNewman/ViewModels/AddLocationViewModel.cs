using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MvcGroup13.ViewModels
{
    public class AddLocationViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name cannot be empty")]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Latitude is required")]
        [DisplayFormat(DataFormatString = "{0:0.##########}")]
        public double? Latitude { get; set; }

        [Required(ErrorMessage = "Longitude is required")]
        [DisplayFormat(DataFormatString = "{0:0.##########}")]
        public double? Longitude { get; set; }

        
        public Image? Image { get; set; }


    }
}



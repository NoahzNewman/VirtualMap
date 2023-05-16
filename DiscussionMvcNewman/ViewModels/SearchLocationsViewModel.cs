using LibraryGroup13;
using System.ComponentModel.DataAnnotations;

namespace MvcGroup13.ViewModels
{
    public class SearchLocationsViewModel
    {
        public string? SearchName { get; set; }
        public string?SearchDescription { get; set; }

        public string? SearchAddress { get; set; }

        public byte? SearchImage { get; set; }
        public string? LocationType { get; set; }

        public List<Location> SearchResult { get; set; }

        public string? LocationName { get; set; }

        public string? LocationDescription { get; set; }

        public string? LocationAddress { get; set; }

    }
}

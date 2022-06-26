using Resto_Backend.Models;
using System.Collections.Generic;

namespace Resto_Backend.ViewModels
{
    public class HomeVM
    {
        public PageIntro pageIntros { get; set; }
        public IEnumerable<Slider>sliders { get; set; }
        public IEnumerable<Icon> icons { get; set; }    
        public About about { get; set; }
        public IEnumerable<AboutImg> aboutImg { get; set; }
        public IEnumerable<Specialties> specialties { get; set; }
        public IEnumerable<Team> teams { get; set; }

    }
}

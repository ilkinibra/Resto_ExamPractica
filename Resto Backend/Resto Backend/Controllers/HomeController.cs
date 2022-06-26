using Microsoft.AspNetCore.Mvc;
using Resto_Backend.DAL;
using Resto_Backend.ViewModels;
using System.Linq;

namespace Resto_Backend.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM=new HomeVM();
            homeVM.pageIntros = _context.pageIntros.FirstOrDefault();
            homeVM.sliders = _context.sliders.ToList();
            homeVM.icons = _context.icons.ToList();
            homeVM.about=_context.abouts.FirstOrDefault();
            homeVM.aboutImg = _context.aboutImgs.ToList();
            homeVM.specialties=_context.specialties.ToList();
            homeVM.teams=_context.teams.ToList();
            return View(homeVM);
        }
    }
}

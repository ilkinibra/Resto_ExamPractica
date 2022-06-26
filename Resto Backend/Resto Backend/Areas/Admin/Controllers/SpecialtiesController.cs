using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Resto_Backend.DAL;
using Resto_Backend.Helpers;
using Resto_Backend.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Resto_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialtiesController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;
        public SpecialtiesController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Specialties> teams = _context.specialties.ToList();
            return View(teams);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Specialties dbSpecialties = await _context.specialties.FindAsync(id);
            if (dbSpecialties == null) return NotFound();
            return View(dbSpecialties);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Specialties dbSpecialties = await _context.specialties.FindAsync(id);
            if (dbSpecialties == null) return NotFound();
            Helper.DeleteFile(_env, "img", dbSpecialties.ImageUrl);
            _context.specialties.Remove(dbSpecialties);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Specialties specialties)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!specialties.Photo.ContentType.Contains("image/"))
            {
                return View();
            }
            if (specialties.Photo.Length / 1024 > 1000)
            {
                return View();
            }
            string path = _env.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + specialties.Photo.FileName;
            string result = Path.Combine(path, "img", fileName);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                await specialties.Photo.CopyToAsync(stream);
            };
            Specialties newSpecialties = new Specialties();
            newSpecialties.ImageUrl = fileName;
            await _context.specialties.AddAsync(newSpecialties);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
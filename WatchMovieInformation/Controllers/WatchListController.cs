using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WatchMovieInformation.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WatchMovieInformation.Controllers
{
    public class WatchListController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            using (var _context=new WatchListDbContext())
            {                
                return View(_context.WatchLists.ToList());
            }
        }
        public IActionResult Create()
        {
            using (var _context = new WatchListDbContext())
            {
                List<Language> languages = _context.Languages.ToList();
                List<Generic> generics = _context.Generics.ToList();
                ViewBag.Languages = languages;
                ViewBag.Generics = generics;                
            }
            return View();
        }
        [HttpPost]
        public IActionResult Create(WatchList watchList)
        {

            return View();
        }
    }
}

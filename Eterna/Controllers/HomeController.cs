using Eterna.DAL;
using Eterna.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext appDb)
        {
            _context = appDb;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();  
            model.Sliders = _context.Slider.ToList();
            model.Catagories = _context.Catagories.ToList();    
            model.Portfolios = _context.Portfolios.ToList();


            return View(model);
        }
    }
}

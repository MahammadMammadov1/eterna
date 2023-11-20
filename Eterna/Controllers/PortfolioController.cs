using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _appDb;

        public PortfolioController(AppDbContext dbContext)
        {
            _appDb = dbContext;
        }


        public IActionResult Index()
        {
            PortfolioViewModel model = new PortfolioViewModel();
            model.Catagories = _appDb.Catagories.ToList();
            model.Portfolios = _appDb.Portfolios.ToList();

            return View(model); 
        }


        public IActionResult Details(int id)
        {
            Portfolio portfolio = _appDb.Portfolios.Include(x=>x.Catagory).FirstOrDefault(x => x.Id == id);
            if (portfolio == null)
            {
                return NotFound();
            }


            return View(portfolio);
        }
    }
}

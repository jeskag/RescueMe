using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RescueMe.Controllers
{
    public class RescueController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("RescueMe Coming Soon!");
        }
    }
}

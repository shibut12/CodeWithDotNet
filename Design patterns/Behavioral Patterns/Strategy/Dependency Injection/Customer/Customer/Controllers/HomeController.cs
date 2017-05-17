using System.Web.Mvc;

namespace Customer.Controllers
{
    public class HomeController : Controller
    {
        private IGreetingService _greetingService;
        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }
        public ActionResult Index()
        {
            return Content(_greetingService.GetGreeting());
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace TangyWeb_API.Controllers
{
    public class StripePaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace jquery_autocomplete_aspnet_mvc_core.Areas.Purchasing.Controllers
{
    [Area("purchasing")]
    public class VendorController : Controller
    {  
        [Route("/vendor/VendorOrders")]
        public IActionResult VendorOrders()
        {
            return View();
        }
    }
}

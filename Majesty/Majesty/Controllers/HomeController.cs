using Majesty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Majesty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _context;
        private readonly IStringLocalizer<HomeController> _local;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor context, IStringLocalizer<HomeController> local)
        {
            _logger = logger;
            _context = context;
            _local = local;
        }

        public IActionResult Index(string culture, string cultureIU)
        {
            GetCulture(culture);
            return View();
        }

        public IActionResult CreativeChronicles()
        {
            return View();
        }

        public IActionResult EclecticElegance()
        {
            return View();
        }
        public IActionResult StyleUnveiled()
        {
            return View();
        }
        public IActionResult UnleashedImagination()
        {
            return View();
        }
        public IActionResult VisualSymphony()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string GetCulture(string code = "")
        {
            if (!string.IsNullOrWhiteSpace(code))
            {
                CultureInfo.CurrentCulture = new CultureInfo(code);
                CultureInfo.CurrentUICulture = new CultureInfo(code);

                ViewBag.Culture = string.Format("CurrentCulture: {0}, CurrentUICulture: {1}", CultureInfo.CurrentCulture,
                    CultureInfo.CurrentUICulture);
            }
            return "";
        }
    }
}

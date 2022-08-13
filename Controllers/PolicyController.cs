using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace Homepage
{
    public class PolicyController : Controller
    {
        static string language_default = "english";
        private readonly ILogger<PolicyController> _logger;

        public PolicyController(ILogger<PolicyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("TermsOfService");
        }

        public IActionResult TermsOfService(string date)
        {
            return Policy(date);
        }

        public IActionResult PrivacyPolicy(string date)
        {
            return Policy(date);
        }

        private IActionResult Policy(string date)
        {
            ViewData["date"] = date;            
            string action = RouteData.Values["action"].ToString();
            string language = (RouteData.Values["language"] ?? language_default).ToString();
            if (!this.ViewExists(language))
            {
                language = language_default;
            }
            ViewData["action"] = action;
            ViewData["language"] = language;

            return View(language);
        }
    }
}

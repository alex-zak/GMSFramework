using Microsoft.AspNetCore.Antiforgery;
using GMSFramework.Controllers;

namespace GMSFramework.Web.Host.Controllers
{
    public class AntiForgeryController : GMSFrameworkControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

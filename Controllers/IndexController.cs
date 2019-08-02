using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class IndexController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            // Views/Home/This is going to look for Index.cshtml IF NOT at this directory it will look in
            // Views/Shared/Index.cshtml
            return View();
        }
        [Route("Projects")]
        [HttpGet]
        public ViewResult Projects()
        {
            return View();
        }
        [Route("Contacts")]
        [HttpGet]
        public ViewResult Contacts()
        {
            return View();
        }
    }
}
 
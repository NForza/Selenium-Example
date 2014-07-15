using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RequestInfoController : Controller
    {
        public ActionResult Index()
        {
            return View(new RequestInfoViewModel());
        }

        // POST: RequestInfo/Index
        [HttpPost]
        public ActionResult Index(RequestInfoViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Confirm", new RequestInfoSentViewModel { EmailAddress = model.EmailAddress });
            }
            return View(model);
        }
    }
}

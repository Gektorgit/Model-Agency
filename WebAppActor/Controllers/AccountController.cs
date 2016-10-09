using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppActor.DataLayer.Repositories;

namespace WebAppActor.Controllers
{
    public class AccountController : Controller
    {
        private IActorRepository actorrepository;
        public AccountController(IActorRepository _actorrepository)
        {
            actorrepository = _actorrepository;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            return RedirectToAction("FindActor", "Home");
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
    }
}
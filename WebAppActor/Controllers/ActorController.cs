using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppActor.DataLayer.DatabaseLayer;
using WebAppActor.DataLayer.Repositories;

namespace WebAppActor.Controllers
{
    public class ActorController : Controller
    {
        private IActorRepository actorrepository;
        private IPhotoRepository photorepository;
        public ActorController(IActorRepository _actorrepository, IPhotoRepository _photorepository)
        {
            actorrepository = _actorrepository;
            photorepository = _photorepository;
        }

        
        public ActionResult EditActor(int id)
        {
            ViewBag.ReturnUrl = Request.UrlReferrer.LocalPath == null ? "" : Request.UrlReferrer.LocalPath;
            return View(id);
        }
        public ActionResult EditPartial(int id)
        {
            ViewBag.Eyes = actorrepository.GetEyes();
            ActorInfo model = actorrepository.Get(id);
            return PartialView(model);
        }
        [HttpPost]
        public ActionResult EditPartial(ActorInfo actor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    actorrepository.Update(actor);
                }
                return Json(new { id = actor.ActorId, success = true }, JsonRequestBehavior.AllowGet);
            }
            catch { return Json(new { success = false }); }
        }

    }
}
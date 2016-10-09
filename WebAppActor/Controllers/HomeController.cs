using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppActor.DataLayer.BusinessLayer;
using WebAppActor.DataLayer.DatabaseLayer;
using WebAppActor.DataLayer.Repositories;
using WebAppActor.Models;

namespace WebAppActor.Controllers
{
    public class HomeController : Controller
    {
        private int ItemsPerPage = 5;
        private IActorRepository actorrepository;
        private IPhotoRepository photorepository;
        public HomeController(IActorRepository _actorrepository, IPhotoRepository _photorepository)
        {
            actorrepository = _actorrepository;
            photorepository = _photorepository;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FindActor()
        {
            //ActorInfo actor = new ActorInfo();
            //ViewBag.EyesId = new SelectList(actorrepository.GetEyes(), "EyesId", "EyesType", actor.EyesId);
            /*var cookie = new HttpCookie("Persistent_cookie")
            {
                Name = "test_cookie",
                Value = DateTime.Now.ToString("dd.MM.yyyy"),
                Expires = DateTime.Now.AddMinutes(10),
            };
            Response.SetCookie(cookie);*/

            var model = new ActorsFilter();
            ViewBag.IsData = 0;
            return View(model);
        }

        [HttpPost]
        public ActionResult FindActor(ActorsFilter obj)
        {            
            TempData["ObjActorFilter"] = obj;
            actorrepository.actorsFilter = obj;
            if (actorrepository.CountActorByFilter > 0)
                return RedirectToAction("ListFindActor", "Home", new { id = 1 });
            return View(obj);
        }

        public ActionResult ListFindActor(int id = 1)
        {
            ActorsFilter obj = (TempData["ObjActorFilter"] != null) ? TempData["ObjActorFilter"]
                                as ActorsFilter : new ActorsFilter();
            TempData["ObjActorFilter"] = obj;
            actorrepository.actorsFilter = obj;
            int TotalItems = actorrepository.CountActorByFilter;
            actorrepository.pagingInfo = new PagingInfo() { CurrentPage = id, ItemsPerPage = ItemsPerPage
                                                            , TotalItems = TotalItems };
            var model = new ViewModelActor()
            {
                Filter = obj,
                PageInfo = actorrepository.pagingInfo,
                Actors = actorrepository.Actors

            };
            return View(model);
        }
        public ActionResult GetAllPhotoActor(int id)
        {
            int countPhoto = photorepository.CountPhoto(id);
            var model = new ViewModelPhoto()
            {
                photo = photorepository.GetPhotoActor(id),
                countphoto = countPhoto,
                select = (countPhoto > 0) ? photorepository.GetPhotoActor(id).FirstOrDefault().PhotoId : (Nullable<int>)null,
                actor = actorrepository.Get(id)
            };
            return PartialView(model);
        }
        public FileContentResult GetPhotoSmall(int id)//PhotoId
        {
            byte[] photo = photorepository.GetPhotoSmall(id);
            return File(photo, "image/jpeg");
        }
        public FileContentResult GetPhotoLarge(int id)//PhotoId
        {
            byte[] photo = photorepository.GetPhotoLarge(id);
            return File(photo, "image/jpeg");
        }
    }
}
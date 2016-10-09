using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppActor.DataLayer.Repositories;
using WebAppActor.Models;

namespace WebAppActor.Controllers
{
    public class PhotoController : Controller
    {
        private IActorRepository actorrepository;
        private IPhotoRepository photorepository;
        public PhotoController(IActorRepository _actorrepository, IPhotoRepository _photorepository)
        {
            actorrepository = _actorrepository;
            photorepository = _photorepository;
        }        
        
        /// <summary>
        /// отобразить ВСЕ фото актера по его id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GetPhoto(int id=134)
        {
            //ViewBag.ReturnUrl = Request.UrlReferrer.LocalPath == null ? "" : Request.UrlReferrer.LocalPath;
            return View(id);
        }
        public ActionResult GetPhotoPartial(int id)
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
    }
}
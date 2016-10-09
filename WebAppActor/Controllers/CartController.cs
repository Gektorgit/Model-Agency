using Stimulsoft.Report.Export;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppActor.DataLayer.DatabaseLayer;
using WebAppActor.DataLayer.Repositories;
using WebAppActor.Models;

namespace WebAppActor.Controllers
{
    public class CartController : Controller
    {
        private IActorRepository actorrepository;
        private IPhotoRepository photorepository;
        public CartController (IActorRepository _actorrepository, IPhotoRepository _photorepository)
        {
            actorrepository = _actorrepository;
            photorepository = _photorepository;
        }
        public ActionResult Index()
        {
            return View();
        }
        [NonAction]
        private TempProject GetTempProject()
        {
            TempProject temp = (TempProject)Session["TempProject"];
            if (temp == null)
            {
                temp = new TempProject(actorrepository);
                Session["TempProject"] = temp;
            }
            return temp;
        }
        public ActionResult DeleteTempProject(int id)
        {
            TempProject temp = GetTempProject();
            temp.RemovePrj(id);
            Session["TempProject"] = temp;
            //int model = 1;
            return Json(1, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddCart(int id)
        {
            PrjDetail obj = new PrjDetail() { PrjMainId = 0, PhotoId = id, PrjDetailId = 0 };
            TempProject temp = GetTempProject();
            temp.AddItem(obj);
            Session["TempProject"] = temp;
            int count = GetTempProject().Count;
            return Json(count, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult ViewTempProject()
        {
            TempProject temp = GetTempProject();
            temp.returnUrl = Request.UrlReferrer.LocalPath;
            return View(temp);
        }
        [NonAction]
        private StiTempDataTable FillStiTempDataTable()
        {
            TempProject temp = GetTempProject();
            StiTempDataTable obj = new StiTempDataTable();
            foreach (var item in temp.TempCollection)
            {
                PhotoActor photo = photorepository.GetPhoto(item.PhotoId);
                ActorInfo actor = actorrepository.Get(photo.ActorId);
                StiTempProject tmp = new StiTempProject()
                    {
                        PhotoId = item.PhotoId,
                        ActorId = photo.ActorId,
                        PhotoLarge = photo.PhotoTrue,
                        Age = DateTime.Now.Year - actor.ActorBirthday.Year,
                        ActorHeght = actor.Heigth
                    };
                obj.AddItem(tmp);
            }
            return obj;
        }
        public FileResult ReportPdf()
        {
            StiTempDataTable data = FillStiTempDataTable();
            Reports.TempProject report = new Reports.TempProject();
            report.RegData(data.GetDataTable());
            if (!report.IsRendered) report.Render(false);
            MemoryStream stream = new MemoryStream();
            StiPdfExportSettingsUpdate settings = new StiPdfExportSettingsUpdate();
            StiPdfExportServiceUpdate export = new StiPdfExportServiceUpdate();
            export.ExportPdf(report, stream, settings);
            return File(stream.ToArray(), "application/pdf");
        }
        [HttpPost]
        public ActionResult Save()
        {
            TempProject temp = GetTempProject();
            temp.Clear();
            return RedirectToAction("FindActor", "Home");
        }

        
    }
}
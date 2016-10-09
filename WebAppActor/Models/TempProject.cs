using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppActor.DataLayer.DatabaseLayer;
using WebAppActor.DataLayer.Repositories;

namespace WebAppActor.Models
{
    public class TempProject
    {
        private PrjMain _prjMain = new PrjMain() { PrjMainId = 0, DateCreate = DateTime.Now, DateStart = DateTime.Now, DateEnd = DateTime.Now.AddDays(+30) };///User and title add to controller...
        private List<PrjDetail> tempCollection = new List<PrjDetail>();
        private IActorRepository actorrepository;

        public TempProject() { }
        public TempProject(IActorRepository _actorrepository)
        {
            actorrepository = _actorrepository;
        }

        public int Count { get { return tempCollection.Count; } }

        public void AddItem(PrjDetail o)
        {
            PrjDetail tmp = tempCollection.Where(p => p.PhotoId == o.PhotoId).FirstOrDefault();
            if (tmp == null)
            {
                o.PrjDetailId = (o.PrjDetailId == 0) ? Count : o.PrjDetailId;
                tempCollection.Add(o);
            }
        }

        public void RemovePrj(int id)
        {
            tempCollection.RemoveAll(p => p.PrjDetailId == id);
        }
        public ActorInfo GetActor(int id)
        {
            return actorrepository.GetByPhoto(id);
        }
        public PrjMain prjMain
        {
            get { return _prjMain; }
            set { _prjMain = value; }
        }
        public string returnUrl { get; set; }
        public void Clear()
        {
            tempCollection.Clear();
        }

        public IEnumerable<PrjDetail> TempCollection
        {
            get { return tempCollection; }
        }
    }
}
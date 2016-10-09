using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public class PrjMainRepository : IPrjMainRepository
    {
        private Actor context;
        public PrjMainRepository() { }
        public PrjMainRepository(Actor context)
        {
            this.context = context;
        }
        public IEnumerable<PrjMain> GetAll()
        {
            return context.PrjMain;
        }

        public PrjMain GetById(int id)
        {
            return context.PrjMain.Find(id);
        }

        public int Add(PrjMain obj)
        {
            var temp = this.context.PrjMain.Add(obj);
            this.context.SaveChanges();

            return temp.PrjMainId;
        }
    }
}

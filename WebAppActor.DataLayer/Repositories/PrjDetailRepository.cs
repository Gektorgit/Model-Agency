using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public class PrjDetailRepository : IPrjDetailRepository
    {
        private Actor context;
        public PrjDetailRepository() { }
        public PrjDetailRepository(Actor context) 
        {
            this.context = context;
        }
        public IEnumerable<PrjDetail> GetAll()
        {
            return context.PrjDetail;
        }

        public PrjDetail GetById(int id)
        {
            return context.PrjDetail.Find(id);
        }

        public int Add(PrjDetail obj)
        {
            var temp = this.context.PrjDetail.Add(obj);
            this.context.SaveChanges();

            return temp.PrjDetailId;
        }
    }
}

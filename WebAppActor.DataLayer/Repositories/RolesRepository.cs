using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public class RolesRepository : IRolesRepository
    {
        private Actor context;
        public RolesRepository() { }
        public RolesRepository(Actor context)
        {
            this.context = context;
        }
        public int Add(Roles obj)
        {
            var temp = context.Roles.Add(obj);
            context.SaveChanges();

            return temp.RoleId;
        }

        public IEnumerable<Roles> GetAll()
        {
            return context.Roles;
        }

        public Roles GetById(int id)
        {
            return context.Roles.Find(id);
        }
    }
}

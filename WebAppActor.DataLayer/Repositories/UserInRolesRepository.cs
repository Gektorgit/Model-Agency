using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public class UserInRolesRepository : IUserInRolesRepository
    {
        private Actor context;
        public UserInRolesRepository() { }
        public UserInRolesRepository(Actor context)
        {
            this.context = context;
        }

        public int Add(UserInRoles obj)
        {
            var temp = context.UserInRoles.Add(obj);
            context.SaveChanges();

            return temp.UserInRoleId; ;
        }

        public IEnumerable<UserInRoles> GetAll()
        {
            return context.UserInRoles;
        }

        public UserInRoles GetById(int id)
        {
            return context.UserInRoles.Find(id);
        }
    }
}

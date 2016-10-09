using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private Actor context;
        public UsersRepository() { }
        public UsersRepository(Actor context)
        {
            this.context = context;
        }

        public int Add(Users obj)
        {
            var temp = context.Users.Add(obj);
            context.SaveChanges();

            return temp.UserId;
        }

        public IEnumerable<Users> GetAll()
        {
            return context.Users;
        }

        public Users GetById(int id)
        {
            return context.Users.Find(id);
        }
    }
}

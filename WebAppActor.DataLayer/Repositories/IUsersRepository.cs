using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<Users> GetAll();
        Users GetById(int id);
        int Add(Users obj);
    }
}

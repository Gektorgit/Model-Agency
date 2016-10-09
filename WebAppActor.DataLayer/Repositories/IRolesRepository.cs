using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public interface IRolesRepository
    {
        IEnumerable<Roles> GetAll();
        Roles GetById(int id);
        int Add(Roles obj);
    }
}

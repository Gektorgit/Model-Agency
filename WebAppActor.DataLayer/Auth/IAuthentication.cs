using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Auth
{
    public interface IAuthentication
    {
        /// <summary>
        /// Конекст (тут мы получаем доступ к запросу и кукисам)
        /// </summary>
        HttpContext HttpContext { get; set; }

        Users Login(string login, string password, bool isPersistent);

        Users Login(string login);

        void LogOut();

        IPrincipal CurrentUser { get; }
    }
}

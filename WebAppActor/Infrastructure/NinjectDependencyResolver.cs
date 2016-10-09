using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppActor.DataLayer.DatabaseLayer;
using WebAppActor.DataLayer.Repositories;

namespace WebAppActor.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }
        /// <summary>
        /// Метод интерфейса
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        /// <summary>
        ///  Метод интерфейса
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            Actor context = new Actor();
            kernel.Bind<IActorRepository>().To<ActorRepository>().WithConstructorArgument("context", context);
            kernel.Bind<IPhotoRepository>().To<PhotoRepository>().WithConstructorArgument("context", context);
            kernel.Bind<IPrjMainRepository>().To<PrjMainRepository>().WithConstructorArgument("context", context);
            kernel.Bind<IPrjDetailRepository>().To<PrjDetailRepository>().WithConstructorArgument("context", context);

            kernel.Bind<IUsersRepository>().To<UsersRepository>().WithConstructorArgument("context", context);
            kernel.Bind<IRolesRepository>().To<RolesRepository>().WithConstructorArgument("context", context);
            kernel.Bind<IUserInRolesRepository>().To<UserInRolesRepository>().WithConstructorArgument("context", context);
        }
    }
}
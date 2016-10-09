using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.BusinessLayer;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public interface IActorRepository
    {
        ActorsFilter actorsFilter { get; set; }
        PagingInfo pagingInfo { get; set; }
        IEnumerable<ActorInfo> Actors { get; }
        int CountActorByFilter { get; }
        ActorInfo Get(int? id);
        ActorInfo GetByPhoto(int? Photoid);
        List<Eyes> GetEyes();
        void Update(ActorInfo actor);
    }
}

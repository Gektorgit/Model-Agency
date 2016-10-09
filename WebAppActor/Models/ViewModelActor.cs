using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppActor.DataLayer.BusinessLayer;
using WebAppActor.DataLayer.DatabaseLayer;


namespace WebAppActor.Models
{
    public class ViewModelActor
    {
        public ActorsFilter Filter { get; set; }
        public IEnumerable<ActorInfo> Actors { get; set; }
        public PagingInfo PageInfo { get; set; }

    }
}
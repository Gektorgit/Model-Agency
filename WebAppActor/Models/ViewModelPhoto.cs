using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.Models
{
    public class ViewModelPhoto
    {
        public IEnumerable<PhotoActor> photo { get; set; }
        public int countphoto { get; set; }
        public int? select { get; set; }
        public ActorInfo actor { get; set; }
    }
}
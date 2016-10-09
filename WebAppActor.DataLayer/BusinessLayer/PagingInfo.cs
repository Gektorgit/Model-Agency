using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppActor.DataLayer.BusinessLayer
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get { return ItemsPerPage == 0 ? 0 : (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }

    }
}
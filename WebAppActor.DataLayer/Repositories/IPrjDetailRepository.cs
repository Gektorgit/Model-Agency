﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public interface IPrjDetailRepository
    {
        IEnumerable<PrjDetail> GetAll();
        PrjDetail GetById(int id);
        int Add(PrjDetail obj);
    }
}

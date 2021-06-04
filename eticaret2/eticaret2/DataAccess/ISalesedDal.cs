﻿using eticaret.Entities;
using eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticaret.DataAccess;

namespace eticaret.DataAccess
{
    public interface ISalesedDal : IEntityRepository<Salesed>
    {
        void Salesed(Salesed2 salesed);
        List<SalesedOrderModel> orders(int Userid);
        void deleteproduct(int salesp_id);
    }
}

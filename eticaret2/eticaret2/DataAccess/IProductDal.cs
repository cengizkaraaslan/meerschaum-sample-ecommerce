﻿using eticaret.Entities;
using eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticaret.DataAccess;

namespace eticaret.DataAccess
{
    public interface IProductDal : IEntityRepository<Products>
    {
        ProductModel  getProductWithDetail(int product_id);

    }
}

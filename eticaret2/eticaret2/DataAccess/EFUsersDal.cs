﻿using eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eticaret.DataAccess
{
    public class EFUsersDal : EFEntityRepositoryBase<Users, MeerschaumContext>, IUsersDal
    {
    }
}

﻿using MvcBootcamp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBootcamp.BLL.Abstract
{
   public interface IUserLevelService
    {
        List<UserLevel> GetList();
    }
}

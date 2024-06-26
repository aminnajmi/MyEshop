﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyEshop.Models;

namespace MyEshop.Data.Repositories
{
    public interface IGroupRepository
   {
       IEnumerable<Category> GetAllCategories();
       IEnumerable<ShowGroupViewModel> GetGroupForShow();
   }
}

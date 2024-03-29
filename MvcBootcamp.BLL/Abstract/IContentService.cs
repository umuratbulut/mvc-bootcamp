﻿using MvcBootcamp.Entities.Concrete;
using MvcBootcamp.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBootcamp.BLL.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<ContentDetailDto> GetContentDetails();
        void Add(Content content);
        void Update(Content content);
    }
}

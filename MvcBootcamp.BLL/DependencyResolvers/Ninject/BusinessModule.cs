﻿using MvcBootcamp.BLL.Abstract;
using MvcBootcamp.BLL.Concrete;
using MvcBootcamp.DAL.Abstract;
using MvcBootcamp.DAL.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBootcamp.BLL.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            // InSingletonScope() ilgili nesnenin sadece bir kere oluşturulmasını sağlar.
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<CategoryDal>().InSingletonScope();

            Bind<IAuthorService>().To<AuthorManager>().InSingletonScope();
            Bind<IAuthorDal>().To<AuthorDal>().InSingletonScope();

            Bind<IContactFormService>().To<ContactFormManager>().InSingletonScope();
            Bind<IContactFormDal>().To<ContactFormDal>().InSingletonScope();

            Bind<IContentService>().To<ContentManager>().InSingletonScope();
            Bind<IContentDal>().To<ContentDal>().InSingletonScope();

            Bind<IHeadlineService>().To<HeadlineManager>().InSingletonScope();
            Bind<IHeadlineDal>().To<HeadlineDal>().InSingletonScope();
        }
    }
}
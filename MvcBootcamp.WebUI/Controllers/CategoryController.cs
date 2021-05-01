﻿using MvcBootcamp.BLL.Abstract;
using MvcBootcamp.BLL.Concrete;
using MvcBootcamp.BLL.DependencyResolvers.Ninject;
using MvcBootcamp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootcamp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        public CategoryController()
        {
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        private ICategoryService _categoryService;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            return View(_categoryService.GetList());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction("GetList");
        }
    }
}
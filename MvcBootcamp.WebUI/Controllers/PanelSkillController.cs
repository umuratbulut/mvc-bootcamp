﻿using MvcBootcamp.BLL.Abstract;
using MvcBootcamp.BLL.DependencyResolvers.Ninject;
using MvcBootcamp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootcamp.WebUI.Controllers
{
    public class PanelSkillController : Controller
    {
        public PanelSkillController()
        {
            _skillService = InstanceFactory.GetInstance<ISkillService>();
        }
        private ISkillService _skillService;

        // GET: PanelSkill
        [Route("skill")]
        public ActionResult GetList()
        {
            return View(_skillService.GetList());
        }
        [HttpGet]
        [Route("skill/new")]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("skill/new")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Skill skill)
        {
            _skillService.Add(skill);
            return RedirectToAction("GetList");
        }
        [HttpGet]
        [Route("skill/update/{id:int}")]
        public ActionResult Update(int id)
        {
            var skill = _skillService.GetList().FirstOrDefault(x => x.Id.Equals(id));
            return View("Update",skill);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Skill skill)
        {
            _skillService.Update(skill);
            return RedirectToAction("GetList");
        }
        [Route("skill/remove/{id:int}")]
        public ActionResult Remove(Skill skill)
        {
            _skillService.Remove(skill);
            return RedirectToAction("GetList");
        }
    }
}
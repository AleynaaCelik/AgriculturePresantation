﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresantation.Controllers
{
    public class TestController : Controller
    {
        private readonly IServiceService _serviceService;

        public TestController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
             _serviceService.Insert(service);
            return RedirectToAction("Index");
        }
    }
}
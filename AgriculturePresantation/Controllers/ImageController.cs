using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresantation.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var values = _imageService.GetListAll();
            return View(values);
        }
    }
}

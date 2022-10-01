using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreBlogMvc.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreBlogMvc.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            var sehirler = new List<ViewModel>() {
                new ViewModel{  Sehir="Ankara"},
                new ViewModel{  Sehir="İstanbul"},
                new ViewModel{  Sehir="İzmir"},
                new ViewModel{  Sehir="Bursa"},
          
            };

            ViewBag.Sehirler = sehirler;

            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            var sehirler = new List<ViewModel>() {
                new ViewModel{  Sehir="Ankara"},
                new ViewModel{  Sehir="İstanbul"},
                new ViewModel{  Sehir="İzmir"},
                new ViewModel{  Sehir="Bursa"},

            };

            ViewBag.Sehirler = sehirler;



            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "dneme test";
                wm.WriterAdd(p);
                return RedirectToAction("Index", "Register");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

          
        }

    }
}

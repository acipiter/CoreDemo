using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Writer writer)
        {
            writer.WriterStatus = true;
            writer.WriterAbout = "Yazar hakkında";
            wm.AddWriter(writer);
            //var values = writer;
            return RedirectToAction("Blog","Blog");
        }
    }
}

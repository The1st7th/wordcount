using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using stringWordApp.Models;

namespace word.Controllers
{
    public class wordController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }
        [HttpPost("/getcount")]
        public ActionResult Count()
        {
          Wordstring origin = new Wordstring(Request.Form["sentence"], Request.Form["key"]);
          return View("Index", origin);
        }
    }
}
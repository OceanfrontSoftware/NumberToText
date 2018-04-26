using ConverterLogic;
using NumberToText.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumberToText.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NumberToTextVM model = new NumberToTextVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(NumberToTextVM model)
        {
            NumberToString converter = new NumberToString(model.Value);
            model.Text = converter.GetNumberText();
            return View(model);
        }
    }
}
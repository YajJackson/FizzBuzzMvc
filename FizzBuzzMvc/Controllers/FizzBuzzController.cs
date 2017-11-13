using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMvc.Controllers
{
    public class FizzBuzzController : Controller
    {
        private string ToFizzBuzz(int value)
        {
            return value % 15 == 0 ? "FizzBuzz" : value % 5 == 0 ? "Buzz" : value % 3 == 0 ? "Fizz" : $"{value}";
        }

        // GET: FizzBuzz
        public ActionResult Index()
        {
            var model = Enumerable.Range(1, 100).Select(ToFizzBuzz);
            return View(model);
        }
    }
}
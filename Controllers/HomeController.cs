using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormatPhoneNumber(string inputNumber)
        {

          if (string.IsNullOrEmpty(inputNumber) || inputNumber.Length != 10)
          {
            return Content("Invalid input. Please enter a 10 digit phone number.");
          }
          else
          {
            string formatted = formatNumber(inputNumber);
            return View((object)formatted);
          }
        }

        // please implement your phone number formatting logic here
        private string formatNumber(string inputNumber)
        {
            string areaCode = inputNumber.Substring(0, 3);
            areaCode = areaCode.Insert(0, "(").Insert(4, ")");
            string phoneNumber = inputNumber.Substring(3, 3) + "-" + inputNumber.Substring(6, 4);
            string formattedNumber = areaCode + " " + phoneNumber;
            return formattedNumber;
        }

        public ActionResult ReverseOrder()
        {
            return View();
        }

    }
}

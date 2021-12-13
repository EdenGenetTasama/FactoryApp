using FactoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult ShowOneEmployeeName()
        {
            //string name = "Eden";
            //ViewBag.Name = name;
            //return View(name);
            return View(ReturnObjEmployee());
        }

        private static Employee ReturnObjEmployee()
        {
            Employee employeOne = new Employee("Eden" , "Employee", 1996 , 527303780);
            return employeOne;
        }



        public ActionResult ShowEmployeeInfo()
        {
            string[] arrayOfEmploye = new string[] { "nameOne", "NameTwo", "NameThree", "NameFour", "nameFive", "nameSix" };
            ViewBag.EmployeeName = arrayOfEmploye;
            return View();

        }

        public ActionResult ShowEmploiesName()
        {
            return View();

        }

        public ActionResult ShowEmployiesAllInfo()
        {

            return View();
        }
    }
}
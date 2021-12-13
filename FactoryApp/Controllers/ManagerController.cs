using FactoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryApp.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult ShowOneManagerName()
        {
            //string name = "Eden";
            //ViewBag.Name = name;
            //return View(name);
            return View(ReturnObjInfo()); 
        }

        private Manger ReturnObjInfo()
        {
            Manger managerObj = new Manger("Eden" , "Eden" , 189);
            return managerObj; 
        }




        public ActionResult ShowManagersInfo()
        {
            string[] arrayOfEmploye = new string[] { "nameOne", "NameTwo", "NameThree", "NameFour", "nameFive", "nameSix" };
            ViewBag.EmployeeName = arrayOfEmploye;
            return View();

        }
    }
}
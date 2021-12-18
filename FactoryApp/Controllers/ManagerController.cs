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

        public ActionResult ManagerList()
        {

            List<Manger> list = new List<Manger>();
            list.Add(new Manger("aaa", "bbbb", 1996));
            list.Add(new Manger("cccc", "dddd", 1998));
            list.Add(new Manger("eee", "fff", 2000));

            return View(list);

        }
    }
}
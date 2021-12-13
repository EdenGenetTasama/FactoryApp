using FactoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryApp.Controllers
{
    public class SupervisorController : Controller
    {
        // GET: Supervisor
        public ActionResult ShowOneSupervisorName()
        {
            //string name = "Eden";
            //ViewBag.Name = name;
            //return View(name);

            return View(ReturnObjInfo());
        }

        private Supervisor ReturnObjInfo()
        {
            Supervisor supervisorOne = new Supervisor("nameOne", "NameTwo", 1980, 5658965);
            return supervisorOne;
        }


        public ActionResult ShowSupervisorsInfo()
        {
            string[] arrayOfEmploye = new string[] { "nameOne", "NameTwo", "NameThree", "NameFour", "nameFive", "nameSix" };
            ViewBag.EmployeeName = arrayOfEmploye;
            return View();

        }


    }
}
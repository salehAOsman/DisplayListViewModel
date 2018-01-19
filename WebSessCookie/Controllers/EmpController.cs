using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSessCookie.Models;

namespace WebSessCookie.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            //We need new container to have this return info from this "ReturnList()" down method
            List<Emploee> emp1 = EmploeeList.EmpList;
            //we use reference to display
            return View(emp1);
            //we can use where if we need to seach for more than one person
            //Emploee me = EmploeeList.EmpList.SingleOrDefault(e => e.Id == id)
        }
    }
}
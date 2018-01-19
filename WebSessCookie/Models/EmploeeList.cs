using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSessCookie.Models
{
    public class EmploeeList
    {
        public static List<Emploee> EmpList = new List<Emploee>();
        //we can use static constractor here instead of method because we need it just one time
        //constractor 
        static EmploeeList()
        {
            EmpList.Add(new Emploee { Id = 1, Name = "samer", Jobb = "mikanik" });
            EmpList.Add(new Emploee { Id = 2, Name = "saleh", Jobb = "electrical" });
            EmpList.Add(new Emploee { Id = 3, Name = "amer", Jobb = "doctor" });
            EmpList.Add(new Emploee { Id = 4, Name = "yasser", Jobb = "sellare" });
        }
    }
}
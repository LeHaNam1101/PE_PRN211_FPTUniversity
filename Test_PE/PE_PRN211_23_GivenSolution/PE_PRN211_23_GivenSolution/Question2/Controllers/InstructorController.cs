using Microsoft.AspNetCore.Mvc;
using Question2.Models;
using System.Globalization;

namespace Question2.Controllers
{
    public class InstructorController : Controller
    {
        private PE_PRN_Spr23_B5Context _context = new PE_PRN_Spr23_B5Context();
        public IActionResult List(int department, string contract, string sortby)
        {
            using (var context = new PE_PRN_Spr23_B5Context())
            {
                List<Department> listD = context.Departments.ToList();
                List<Instructor> listI = context.Instructors.ToList();
                List<Instructor2> list2 = new List<Instructor2>();
                foreach (Instructor item in listI)
                {
                    Instructor2 i2 = new Instructor2();
                    i2.InstructorId = item.InstructorId;
                    i2.Fullname = item.Fullname;
                    i2.ContractDate = item.ContractDate;
                    i2.Fullname = item.Fullname;
                    i2.Department = item.Department;
                    i2.DepartmentName = context.Departments.FirstOrDefault(x => x.DepartmentId == item.Department).DepartmentName;
                    list2.Add(i2);

                }

                ViewBag.listD = listD;
                ViewBag.listI = list2;
            }
                return View();
        }
        public IActionResult Search()
        {
            using (var context = new PE_PRN_Spr23_B5Context())
            {
                string de = HttpContext.Request.Form["department"];
                string con = HttpContext.Request.Form["contract"];
                string sort = HttpContext.Request.Form["sort"];


                List<Department> listD = context.Departments.ToList();
                List<Instructor> listI = context.Instructors.Where(x => x.Department == int.Parse(de) && x.IsFulltime == bool.Parse(con)).ToList();
                List<Instructor2> list2 = new List<Instructor2>();
                foreach (Instructor item in listI)
                {
                    Instructor2 i2 = new Instructor2();
                    i2.InstructorId = item.InstructorId;
                    i2.Fullname = item.Fullname;
                    i2.ContractDate = item.ContractDate;
                    i2.Fullname = item.Fullname;
                    i2.Department = item.Department;
                    i2.DepartmentName = context.Departments.FirstOrDefault(x => x.DepartmentId == item.Department).DepartmentName;
                    list2.Add(i2);

                }
                if (sort == "1")
                {
                    list2.OrderBy(x => x.Fullname).ToList();
                }
                else if (sort == "2")
                {
                    list2.OrderBy(x => x.InstructorId).ToList();
                }
                else
                {
                    list2.OrderBy(x => x.ContractDate).ToList();
                }
                ViewBag.listD = listD;
                ViewBag.listI = list2;
            }
            return View();
        }
    }
}

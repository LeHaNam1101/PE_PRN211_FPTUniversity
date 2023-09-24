using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Question2.Models;

namespace Question2.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(string? orderdate, string? requireddate, string name)
        {
            using (var context = new PE_PRN_23SumContext())
            {
                List<Order> orders = new List<Order>();

                orders = context.Orders.ToList();
              
                ViewBag.Orderdate = orderdate;
                ViewBag.RequiredDate = requireddate;
               
                return View(orders);
            }
        }
        public IActionResult Delete(int id)
        {
            using (var context = new PE_PRN_23SumContext())
            {


                Order order = context.Orders.FirstOrDefault(x => x.EmployeeId == id);
                context.Orders.Remove(order);
                context.SaveChanges();

                return Redirect("/Orders/ListByEmployee");
            }
        }
        public IActionResult Details(int id)
        {
            using (var context = new PE_PRN_23SumContext())
            {

                Order order = context.Orders.Include(x => x.DepartmentNavigation).FirstOrDefault(x => x.EmployeeId == id);

                if (id == null)
                {
                    return NotFound();
                }
                if (order == null)
                {
                    return NotFound();
                }
                return View(order);
            }
        }
        public IActionResult Create()
        {
            using (var context = new PE_PRN_23SumContext())
            {
                var orders = context.Employees.Select(x => x.EmployeeId).Distinct().ToList();

         

              
                ViewBag.Postions = orders;

            }
            return View();
        }
        public IActionResult Add(DateTime date, int freight, DateTime dob, DateTime require)
        {
            using (var context = new PE_PRN_23SumContext())
            {
                Order order = new Order();
                order.OrderDate = date;
                order.RequiredDate = require;
              
            
                order.ShippedDate = dob;
                order.Freight = freight;
                context.Orders.Add(order);
                context.SaveChanges();


            }
            return RedirectToAction("List");
        }

    }
}

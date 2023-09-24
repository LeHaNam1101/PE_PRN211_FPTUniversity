using Assignment3.Models;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Assignment3.Controllers
{
    public class MemberController : Controller
    {
        private readonly FstoreContext context;
        public MemberController()
        {
            context = new FstoreContext();
        }

        public ActionResult Index(string search, string name, decimal? to, decimal? from)
        {
            // var model = context.Products.ToList();
            var model = from member in context.Members select member;
            if (!string.IsNullOrEmpty(name))
            {
                if (to != null && from != null)
                {
                    model = model.Where(x => x.Email.Contains(name) && x.MemberId >= to && x.MemberId <= from);
                }
                else
                {
                    model = model.Where(x => x.Email.Contains(name));
                }

            }
            else
            {
                if (to != null && from != null)
                {
                    model = model.Where(x => x.Email.Contains(name) && x.MemberId >= to && x.MemberId <= from);
                }
            }
            if (!String.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.CompanyName.Contains(search) || x.Email.Contains(search) || x.City.Contains(search));
            }

            return View(model);
        }
        public ActionResult Refresh()
        {
            return RedirectToAction(nameof(Index));
        }


        // GET: ProductController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var member = context.Members.FirstOrDefault(m => m.MemberId == id);
            if (member == null)
            {
                return NotFound();
            }
            var orderDetailsUrl = Url.Action("OrderDetails", "Member", new { memberId =  id});

            ViewBag.OrderDetailsUrl = orderDetailsUrl;
            return View(member);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                // Check if the member ID already exists
                if (IsMemberIdExists(member.MemberId))
                {
                    ModelState.AddModelError("MemberId", "Member ID already exists");
                }
                else
                {
                    context.Members.Add(member);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }

            // Model state is invalid or member ID already exists, return to the create view with validation errors
            return View(member);
        }
       

        private bool IsMemberIdExists(int memberId)
        {
            // Check if the member ID already exists in the database
            bool isExists = context.Members.Any(m => m.MemberId == memberId);
            return isExists;
        }
        // GET: ProductController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
                ;
            }
            var member = context.Members.Find(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Member member)
        {
            if (id != member.MemberId)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                context.Update(member);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int? id)
        {
            var member = context.Members.Find(id);
            context.Members.Remove(member);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Order(int id)
        {
            var order = context.Orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        public ActionResult OrderDetails(int memberId)
        {
            var orderDetails = context.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.Product)
                .Where(od => od.Order.MemberId == memberId)
                .ToList();

            return View(orderDetails);
        }

    }
}


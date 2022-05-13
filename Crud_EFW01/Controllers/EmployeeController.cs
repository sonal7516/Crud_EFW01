using Crud_EFW01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_EFW01.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public ActionResult Index()
        {
            var emp = dbContext.Employees.ToList();
            return View(emp);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            dbContext.Employees.Add(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var employee = dbContext.Employees.SingleOrDefault(e => e.ID == id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Update(Employee emp)
        {

            dbContext.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.ID == Id);
            dbContext.Employees.Remove(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
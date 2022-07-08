using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Controllers
{
    public class GorevController : Controller
    {
        Context c = new Context();
        GorevManager gorevManager = new GorevManager(new EfGorevDal());
        UserManager userManager = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            var values = gorevManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGorev()
        {
            List<SelectListItem> deger1 = (from x in c.Users.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.UserID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public IActionResult AddGorev(Gorev gorev)
        {
            gorevManager.TAdd(gorev);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteGorev(int id)
        {
            var values = gorevManager.TGetById(id);
            gorevManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditGorev(int id)
        {

            var values = gorevManager.TGetById(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditBList(Gorev gorev)
        {
            gorevManager.TUpdate(gorev);
            return RedirectToAction("Index");
        }
    }
}
    


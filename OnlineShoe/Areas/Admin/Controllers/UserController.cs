using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace OnlineShoe.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var dao = new UserDao();
            var model = dao.listAllPaging(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.insert(user);
                if (id > 0)
                {
                    return RedirectToAction("Create", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm không thành công");
                }
            }
            return View("Index");

        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var user = new UserDao().getViewDetail(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                bool result = dao.update(user);
                if (result)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật không thành công");
                }
            }
            return View("Index");

        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            var user = new UserDao().getViewDetail(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                bool result = dao.delete(user);
                if (result)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Xóa không thành công");
                }
            }
            return View("Index");
        }

        /*
        public ActionResult Delete(int id)
        {
            var phone = _db.Phones.Select(p => p).Where(p => p.PhoneId == id).FirstOrDefault(); return View(phone);
        } // // POST: /Home/Delete/5 

        [HttpPost] 
        public ActionResult Delete(int id, FormCollection collection)
        { try
            { var phone = _db.Phones.Select(p => p).Where(p => p.PhoneId == id) .FirstOrDefault();
                if (phone != null) _db.DeleteObject(phone); _db.SaveChanges();
                return RedirectToAction(“Index”);
            }
            catch
            { return View();
            }
        }*/

    }
}
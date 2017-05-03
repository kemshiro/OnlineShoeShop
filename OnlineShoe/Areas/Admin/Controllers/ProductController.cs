using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using PagedList;
using Model.Dao;

namespace OnlineShoe.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Admin/Product
        public ActionResult Index(int pageNum = 1, int pageSize = 10)
        {
            var dao = new ProductDao();
            var model = dao.listAllProduct(pageNum, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDao();
                long id = dao.insert(product);
                if (id > 0)
                {
                    return RedirectToAction("Create", "Product");
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
            var product = new ProductDao().getProductById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDao();
                bool result = dao.update(product);
                if (result)
                {
                    return RedirectToAction("Index", "Product");
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
            var product = new ProductDao().getProductById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDao();
                bool result = dao.delete(product);
                if (result)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Xóa không thành công");
                }
            }
            return View("Index");
        }
    }
}
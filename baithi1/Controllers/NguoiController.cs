using baithi1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace baithi1.Controllers
{
    public class NguoiController : Controller
    {
        // GET: NguoiController1
        public ActionResult Index()
        {
            return View(NguoiReposity.Getlist);
        }

        // GET: NguoiController1/Details/5
        public ActionResult Details(int id)
        {
            return View(NguoiReposity.GetNguoi(id));
        }

        // GET: NguoiController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NguoiController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Nguoi nguoi)
        {
            try
            {
                NguoiReposity.addNguoi(nguoi);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NguoiController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(NguoiReposity.GetNguoi(id));
        }

        // POST: NguoiController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Nguoi nguoi)
        {
            try
            {
                NguoiReposity.EditNguoi(nguoi);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NguoiController1/Delete/5
        public ActionResult Delete(int id)
        {
            NguoiReposity.XoaNguoi(NguoiReposity.GetNguoi(id));
            return RedirectToAction(nameof(Index));
        }

        // POST: NguoiController1/Delete/5
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
        [HttpPost]
        public ActionResult TimKiem (string Tim)
        {
            return View("Index", NguoiReposity.Getlist.Where(p => p.Name == Tim));

        }
    }
}

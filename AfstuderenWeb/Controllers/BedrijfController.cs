using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Afstuderen.Domain;

namespace AfstuderenWeb.Controllers
{
    public class BedrijfController : Controller
    {
        // GET: BedrijfsController
        public ActionResult Index()
        {
            using(var ctx = new AfstudeerContext()){
                return View(ctx.Bedrijven.ToList());
            }
        }

        // GET: BedrijfsController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                using(var ctx = new AfstudeerContext())
                {
                    return View(ctx.Bedrijven.FirstOrDefault(b => b.Id == id));
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Index","Home");
            }
        }

        // GET: BedrijfsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BedrijfsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Bedrijf model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new AfstudeerContext())
                    {

                        ctx.Bedrijven.Add(model);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: BedrijfsController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                using (var ctx = new AfstudeerContext())
                {
                    return View(ctx.Bedrijven.FirstOrDefault(b => b.Id == id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: BedrijfsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Bedrijf model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new AfstudeerContext())
                    {

                        ctx.Attach(model);
                        ctx.Update(model);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: BedrijfsController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                using (var ctx = new AfstudeerContext())
                {
                    return View(ctx.Bedrijven.FirstOrDefault(b => b.Id == id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: BedrijfsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Bedrijf model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new AfstudeerContext())
                    {

                        ctx.Attach(model);
                        ctx.Remove(model);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }
    }
}

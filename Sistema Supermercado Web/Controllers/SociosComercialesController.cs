using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Sistema_Supermercado_Web.Controllers
{
    public class SociosComercialesController : Controller
    {
        private HttpClientHandler clientHandler = new HttpClientHandler();

        public SociosComercialesController()
        {
            clientHandler.ServerCertificateCustomValidationCallback =
                (sender, cert, chain, sslPolicyErrors)
                =>
                { return true; };
        }
        // GET: SocioComercialesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SocioComercialesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SocioComercialesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocioComercialesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: SocioComercialesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SocioComercialesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: SocioComercialesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SocioComercialesController/Delete/5
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
    }
}

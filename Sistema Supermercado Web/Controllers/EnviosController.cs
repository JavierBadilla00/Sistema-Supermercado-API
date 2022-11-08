using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Sistema_Supermercado_Web.Controllers
{
    public class EnviosController : Controller
    {
            private HttpClientHandler clientHandler = new HttpClientHandler();

            public EnviosController()
            {
                clientHandler.ServerCertificateCustomValidationCallback =
                    (sender, cert, chain, sslPolicyErrors)
                    =>
                    { return true; };
            }
            // GET: EnviosController
            public ActionResult Index()
        {
            return View();
        }

        // GET: EnviosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnviosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnviosController/Create
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

        // GET: EnviosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnviosController/Edit/5
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

        // GET: EnviosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnviosController/Delete/5
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

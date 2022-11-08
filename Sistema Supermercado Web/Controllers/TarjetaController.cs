using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Sistema_Supermercado_Web.Controllers
{
    public class TarjetaController : Controller
    {
        private HttpClientHandler clientHandler = new HttpClientHandler();

        public TarjetaController()
        {
            clientHandler.ServerCertificateCustomValidationCallback =
                (sender, cert, chain, sslPolicyErrors)
                =>
                { return true; };
        }
        // GET: TarjetaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TarjetaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TarjetaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TarjetaController/Create
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

        // GET: TarjetaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TarjetaController/Edit/5
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

        // GET: TarjetaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TarjetaController/Delete/5
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

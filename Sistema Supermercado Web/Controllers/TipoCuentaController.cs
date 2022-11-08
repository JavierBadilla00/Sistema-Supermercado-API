using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Sistema_Supermercado_Web.Controllers
{
    public class TipoCuentaController : Controller
    {
        private HttpClientHandler clientHandler = new HttpClientHandler();

        public TipoCuentaController()
        {
            clientHandler.ServerCertificateCustomValidationCallback =
                (sender, cert, chain, sslPolicyErrors)
                =>
                { return true; };
        }
        // GET: TipoCuentaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoCuentaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoCuentaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCuentaController/Create
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

        // GET: TipoCuentaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoCuentaController/Edit/5
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

        // GET: TipoCuentaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoCuentaController/Delete/5
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

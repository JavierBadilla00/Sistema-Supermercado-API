using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Sistema_Supermercado_Web.Controllers
{
    public class TipoEmpleadoController : Controller
    {
        private HttpClientHandler clientHandler = new HttpClientHandler();

        public TipoEmpleadoController()
        {
            clientHandler.ServerCertificateCustomValidationCallback =
                (sender, cert, chain, sslPolicyErrors)
                =>
                { return true; };
        }
        // GET: TipoEmpleadoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoEmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoEmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEmpleadoController/Create
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

        // GET: TipoEmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoEmpleadoController/Edit/5
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

        // GET: TipoEmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoEmpleadoController/Delete/5
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

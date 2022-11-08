using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Sistema_Supermercado_Web.Controllers
{
    public class CategoriaProductoController : Controller
    {
        private HttpClientHandler clientHandler = new HttpClientHandler();

        public CategoriaProductoController()
        {
            clientHandler.ServerCertificateCustomValidationCallback =
                (sender, cert, chain, sslPolicyErrors)
                =>
                { return true; };
        }
        // GET: CategoriaProductoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoriaProductoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriaProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaProductoController/Create
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

        // GET: CategoriaProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriaProductoController/Edit/5
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

        // GET: CategoriaProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaProductoController/Delete/5
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

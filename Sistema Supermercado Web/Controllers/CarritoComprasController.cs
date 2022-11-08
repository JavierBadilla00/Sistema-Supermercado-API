using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Sistema_Supermercado_Web.Controllers
{
    public class CarritoComprasController : Controller
    {
        private HttpClientHandler clientHandler = new HttpClientHandler();

        public CarritoComprasController()
        {
            clientHandler.ServerCertificateCustomValidationCallback =
                (sender, cert, chain, sslPolicyErrors)
                =>
                { return true; };
        }
            // GET: CarritoComprasController
            public ActionResult Index()
            {
                return View();
            }

            // GET: CarritoComprasController/Details/5
            public ActionResult Details(int id)
            {
                return View();
            }

            // GET: CarritoComprasController/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: CarritoComprasController/Create
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

            // GET: CarritoComprasController/Edit/5
            public ActionResult Edit(int id)
            {
                return View();
            }

            // POST: CarritoComprasController/Edit/5
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

            // GET: CarritoComprasController/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: CarritoComprasController/Delete/5
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




using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sistema_Supermercado_Web.Controllers
{
    public class TipoTarjetaController : Controller
    {
        private HttpClientHandler clientHandler = new HttpClientHandler();

        public TipoTarjetaController()
        {
            clientHandler.ServerCertificateCustomValidationCallback =
                (sender, cert, chain, sslPolicyErrors)
                =>
                { return true; };
        }
        // GET: TipoTarjetaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoTarjetaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoTarjetaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTarjetaController/Create
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

        // GET: TipoTarjetaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoTarjetaController/Edit/5
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

        // GET: TipoTarjetaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoTarjetaController/Delete/5
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

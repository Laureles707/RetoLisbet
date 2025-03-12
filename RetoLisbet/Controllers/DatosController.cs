using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetoLisbet.Services;

namespace RetoLisbet.Controllers
{
    public class DatosController : Controller
    {
        private readonly ServicioDatos _apiService;

        public DatosController(ServicioDatos apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var datos = await _apiService.ObtenerDatosAsync();
            return View(datos);
        }

        // GET: DatosController
       

        // GET: DatosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DatosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatosController/Create
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

        // GET: DatosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DatosController/Edit/5
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

        // GET: DatosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DatosController/Delete/5
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

using Microsoft.AspNetCore.Mvc;
using SW.Models;
using SW.Services;


namespace SW.Web.Controllers
{
    public class EspeceController : Controller
    {
        private readonly EspeceService _especeService;

        public EspeceController(EspeceService especeService)
        {
            _especeService = especeService;
        }

        // GET: Espece
        public IActionResult Index()
        {
            var especes = _especeService.GetAllEspeces();
            return View(especes);
        }

        // GET: Espece/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST: Espece/Add
        [HttpPost]
        public IActionResult Add(Espece espece)
        {
            if (ModelState.IsValid)
            {
                _especeService.AddEspece(espece);
                return RedirectToAction(nameof(Index));
            }
            return View(espece);
        }

        // GET: Espece/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var espece = _especeService.GetEspeceById(id);
            if (espece == null)
            {
                return NotFound();
            }
            return View(espece);
        }

        // POST: Espece/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Espece espece)
        {
            if (ModelState.IsValid)
            {
                _especeService.UpdateEspece(espece);
                return RedirectToAction(nameof(Index));
            }
            return View(espece);
        }

        // GET: Espece/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var espece = _especeService.GetEspeceById(id);
            if (espece == null)
            {
                return NotFound();
            }
            return View(espece);
        }

        // POST: Espece/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _especeService.DeleteEspece(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
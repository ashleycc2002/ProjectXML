using Domain.API;
using Layer.BLL.Customers;
using Layer.DATA.Model;
using Microsoft.AspNetCore.Mvc;
using WebAppGenesis.Response;

namespace WebAppGenesis.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityCommandService<City> _cityCmdService;

        public CityController(ICityCommandService<City> cityCmdService)
        {

            _cityCmdService = cityCmdService ?? throw new ArgumentException(nameof(cityCmdService));
        }

        // GET: CityController
        public ActionResult Index()
        {
           
            var city = _cityCmdService.GetAll().ToList();
            return View(city);
        }

        // GET: CityController/Details/5
        public ActionResult Details(int id)
        {
            var city = _cityCmdService.GetEntityById(id);
            return View(city);
        }

        // GET: CityController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: CityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(City entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _cityCmdService.Add(entity);
                    return RedirectToAction("Index");
                }

                return View(entity);
            }
            catch
            {
                return View();
            }
        }

        // GET: CityController/Edit/5
        public ActionResult Edit(int id)
        {
            var city = _cityCmdService.GetEntityById(id);
            return View(city);
        }

        // POST: CityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(City entity)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _cityCmdService.Update(entity);
                    return RedirectToAction("Index");
                }

                return View(entity);

            }
            catch
            {
                return View();
            }
        }

        // GET: CityController/Delete/5
        public ActionResult Delete(int id)
        {
            var city = _cityCmdService.GetEntityById(id);
            return View(city);
        }

        // POST: CityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(City entity)
        {
            try
            {
                var city = _cityCmdService.GetEntityById(entity.Id);
                if (city != null)
                {

                    _cityCmdService.Delete(city);
                    return RedirectToAction("Index");
                }

                return View(entity);

            }
            catch
            {
                return View();
            }
        }
    }
}

using Layer.BLL.Customers;
using Layer.DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCustomer.Controllers
{
    public class CountryController : Controller
    {

        private readonly ICountryCommandService<Country> _countryCmdService;

        public CountryController(ICountryCommandService<Country> countryCmdService)
        {
            _countryCmdService = countryCmdService ?? throw new ArgumentException(nameof(countryCmdService));
        }


        // GET: CountryController
        public ActionResult Index()
        {
            var country = _countryCmdService.GetAll().ToList();
            return View(country);
        }

        // GET: CountryController/Details/5
        public ActionResult Details(int id)
        {
            var country = _countryCmdService.GetEntityById(id);
         
            return View(country);
        }

        // GET: CountryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Country entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _countryCmdService.Add(entity);
                    return RedirectToAction("Index");
                }

                return View(entity);
               
            }
            catch
            {
                return View();
            }
        }

        // GET: CountryController/Edit/5
        public ActionResult Edit(int id)
        {
            var country = _countryCmdService.GetEntityById(id);
            return View(country);
        }

        // POST: CountryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Country entity)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _countryCmdService.Update(entity);
                    return RedirectToAction("Index");

                }

                return View(entity);
               
            }
            catch
            {
                return View();
            }
        }

        // GET: CountryController/Delete/5
        public ActionResult Delete(int id)
        {
            var country = _countryCmdService.GetEntityById(id);
            return View(country);
        }

        // POST: CountryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Country entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _countryCmdService.Delete(entity);
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

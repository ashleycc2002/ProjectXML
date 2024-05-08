using Layer.BLL.Customers;
using Layer.DATA.GRepository;
using Layer.DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCustomer.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerInformationCommandService<InfoCustomer> _customerCmdService;

        public CustomerController(ICustomerInformationCommandService<InfoCustomer> customerCmdService)
        {

            _customerCmdService = customerCmdService ?? throw new ArgumentException(nameof(customerCmdService));
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            var customer = _customerCmdService.GetAll().ToList();
            return View(customer);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            var customer = _customerCmdService.GetEntityById(id);
            return View(customer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InfoCustomer entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _customerCmdService.Add(entity);
                    return RedirectToAction("Index");
                }

                return View(entity);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = _customerCmdService.GetEntityById(id);
            return View(customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InfoCustomer entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _customerCmdService.Update(entity);
                    return RedirectToAction("Index");
                }

                return View(entity);


            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = _customerCmdService.GetEntityById(id);
            return View(customer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(InfoCustomer entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _customerCmdService.Update(entity);
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

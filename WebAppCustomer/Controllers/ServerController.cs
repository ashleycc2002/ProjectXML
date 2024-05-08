using Layer.BLL.Customers;
using Layer.DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCustomer.Controllers
{
    public class ServerController : Controller
    {

        private readonly IServerCommandService<ServerInfo> _serverCommandService;

        public ServerController(IServerCommandService<ServerInfo> serverCommandService)
        {

            _serverCommandService = serverCommandService ?? throw new ArgumentException(nameof(serverCommandService));

        }

        // GET: ServerController
        public ActionResult Index()
        {
            var server = _serverCommandService.GetAll().ToList();
            return View(server);
        }

        // GET: ServerController/Details/5
        public ActionResult Details(int id)
        {
            var server = _serverCommandService.GetEntityById(id);
            return View(server);
        }

        // GET: ServerController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: ServerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServerInfo entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _serverCommandService.Add(entity);
                    return RedirectToAction("Index");
                }

                return View(entity);
               
            }
            catch
            {
                return View();
            }
        }

        // GET: ServerController/Edit/5
        public ActionResult Edit(int id)
        {
            var server = _serverCommandService.GetEntityById(id);
            return View(server);
        }

        // POST: ServerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServerInfo entity)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _serverCommandService.Update(entity);
                    return RedirectToAction("Index");

                }

                return View(entity);
               
            }
            catch
            {
                return View();
            }
        }

        // GET: ServerController/Delete/5
        public ActionResult Delete(int id)
        {
            var server = _serverCommandService.GetEntityById(id);
            return View(server);
        }

        // POST: ServerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ServerInfo entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _serverCommandService.Delete(entity);
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

using Domain.API;
using Layer.BLL.Customers;
using Layer.DATA.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Xml.Linq;
using WebAppGenesis.Response;

namespace WebAppGenesis.Controllers
{
    public class XMLController : Controller
    {
        private readonly ICityCommandService<City> _cityCmdService;
        private readonly ICountryCommandService<Country> _countryCmdService;
        private readonly ICustomerInformationCommandService<InfoCustomer> _customerCmdService;
        private readonly IServerCommandService<ServerInfo> _serverCommandService;

        public XMLController(ICityCommandService<City> cityCmdService, ICountryCommandService<Country> countryCmdService,
            ICustomerInformationCommandService<InfoCustomer> customerCmdService, IServerCommandService<ServerInfo> serverCommandService)
        {

            _cityCmdService = cityCmdService ?? throw new ArgumentException(nameof(cityCmdService));
            _countryCmdService = countryCmdService;
            _customerCmdService = customerCmdService;
            _serverCommandService = serverCommandService;
        }

       
        //GET: CityController/Create
        
        public ActionResult Create()
        {
           //string rexml = new ReadDocumentXML(_cityCmdService, _countryCmdService, _customerCmdService, _serverCommandService).GetConsultInformationCompanyXML(3,8,4);
            return View();
        }


        public ActionResult CreateXML()
        {

            return View();
        }


        public ActionResult ReadXML()
        {
            return View();
        }


        // POST: CityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateXML(string xml)
        {
            try
            {
                var modelLista = ResponseDocumentXML.GetListDocXML(XmlDocument.GetXmlFile());

                //List<City> city = modelLista._city.ConvertAll(item => new City
                //{
                //    Description = item.Description,
                //    Code = item.Code,
                //    State = item.State,
                //    Longitude = item.Longitude,
                //    Latitude = item.Latitude,
                //    TimeZone = item.TimeZone,
                //    ExternalId = item.ExternalId,
                //    Enabled = item.Enabled
                //});

                //object[] objects = list.ConvertAll<object>(item => (object)item).ToArray();
                //theList.Cast<object>().ToArray()
                //new List<object>(theList).ToArray()
                if (modelLista != null)
                {
                    City city = new City();
                    if (!_cityCmdService.GetAll().Any(e=> e.CountryId == modelLista._city.FirstOrDefault().CountryId))
                    {

                        city.CountryId = modelLista._city.FirstOrDefault().CountryId;
                        city.Description = modelLista._city.FirstOrDefault().Description;
                            city.Code = modelLista._city.FirstOrDefault().Code;
                        city.State = modelLista._city.FirstOrDefault().State;
                        city.Longitude = modelLista._city.FirstOrDefault().Longitude;
                        city.Latitude = modelLista._city.FirstOrDefault().Latitude;
                        city.TimeZone = modelLista._city.FirstOrDefault().TimeZone;
                        city.ExternalId = modelLista._city.FirstOrDefault().ExternalId;
                        city.Enabled = modelLista._city.FirstOrDefault().Enabled;

                        _cityCmdService.Add(city);

                    }
                    

                    Country country = new Country
                    {
                        Descripcion = modelLista._country.FirstOrDefault().Descripcion,
                        IsoCode = modelLista._country.FirstOrDefault().IsoCode,
                        IsoCodi = modelLista._country.FirstOrDefault().IsoCodi
                    };
                    _countryCmdService.Add(country);

                    InfoCustomer customer = new InfoCustomer
                    {
                         CustomerName = modelLista._infocustomer.FirstOrDefault().CustomerName,
                         UserId  = modelLista._infocustomer.FirstOrDefault().UserId,
                        CustomerType = modelLista._infocustomer.FirstOrDefault().CustomerType,
                        CustomerSegment = modelLista._infocustomer.FirstOrDefault().CustomerSegment,
                        Email = modelLista._infocustomer.FirstOrDefault().Email,
                        CustomerBranch = modelLista._infocustomer.FirstOrDefault().CustomerBranch,
                        ParentCustomerId = modelLista._infocustomer.FirstOrDefault().ParentCustomerId,
                        ChildDocumentType = modelLista._infocustomer.FirstOrDefault().ChildDocumentType,
                        ChildDocumentNumber = modelLista._infocustomer.FirstOrDefault().ChildDocumentNumber,
                        DocumentType = modelLista._infocustomer.FirstOrDefault().DocumentType,
                        DocumentNumber = modelLista._infocustomer.FirstOrDefault().DocumentNumber
                    };
                    _customerCmdService.Add(customer);


                    ServerInfo server = new ServerInfo
                    {
                         ServerSource = modelLista._serverInfo.FirstOrDefault().ServerSource,
                         ServiceSource = modelLista._serverInfo.FirstOrDefault().ServiceSource,
                        Chanel = modelLista._serverInfo.FirstOrDefault().Chanel,
                        Funcion = modelLista._serverInfo.FirstOrDefault().Funcion,
                        Languge = modelLista._serverInfo.FirstOrDefault().Languge,
                        Country = modelLista._serverInfo.FirstOrDefault().Country,
                        SesionId = modelLista._serverInfo.FirstOrDefault().SesionId,
                        Serverip = modelLista._serverInfo.FirstOrDefault().Serverip,
                    };
                    _serverCommandService.Add(server);

                    return RedirectToAction("Index","City");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        
    }
}

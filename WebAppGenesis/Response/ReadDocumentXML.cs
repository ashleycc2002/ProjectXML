using Layer.BLL.Customers;
using Layer.DATA.Model;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Xml.Linq;
using WebAppGenesis.ModelView;
using City = WebAppGenesis.ModelView.City;
using Country = WebAppGenesis.ModelView.Country;
using InfoCustomer = WebAppGenesis.ModelView.InfoCustomer;
using ServerInfo = WebAppGenesis.ModelView.ServerInfo;

namespace WebAppGenesis.Response
{
    public  class ReadDocumentXML
    {
        //private readonly ICityCommandService<City> _cityCmdService;
        //private readonly ICountryCommandService<Country> _countryCmdService;
        //private readonly ICustomerInformationCommandService<InfoCustomer> _customerCmdService;
        //private readonly IServerCommandService<ServerInfo> _serverCommandService;

        //public ReadDocumentXML(ICityCommandService<City> cityCmdService, ICountryCommandService<Country> countryCmdService,
        //    ICustomerInformationCommandService<InfoCustomer> customerCmdService, IServerCommandService<ServerInfo> serverCommandService)
        //{

        //    _cityCmdService = cityCmdService ?? throw new ArgumentException(nameof(cityCmdService));
        //    _countryCmdService = countryCmdService;
        //    _customerCmdService = customerCmdService;
        //    _serverCommandService = serverCommandService;
        //}

        public ReadDocumentXML(ICityCommandService<Layer.DATA.Model.City> cityCmdService, ICountryCommandService<Layer.DATA.Model.Country> countryCmdService, ICustomerInformationCommandService<Layer.DATA.Model.InfoCustomer> customerCmdService, IServerCommandService<Layer.DATA.Model.ServerInfo> serverCommandService)
        {
            _cityCmdService = cityCmdService;
            _countryCmdService = countryCmdService;
            _customerCmdService = customerCmdService;
            _serverCommandService = serverCommandService;
        }

        public ICityCommandService<Layer.DATA.Model.City> _cityCmdService { get; }
        public ICountryCommandService<Layer.DATA.Model.Country> _countryCmdService { get; }
        public ICustomerInformationCommandService<Layer.DATA.Model.InfoCustomer> _customerCmdService { get; }
        public IServerCommandService<Layer.DATA.Model.ServerInfo> _serverCommandService { get; }

        public  string  GetConsultInformationCompanyXML(int cityId,int countryId, int customerId)
        {
            XDocument _result = null;
            var city = _cityCmdService.GetAll().FirstOrDefault(x=> x.Id == cityId);
            var country = _countryCmdService.GetAll().FirstOrDefault(x => x.Id == countryId);
            var customer = _customerCmdService.GetAll().FirstOrDefault(x => x.Id == customerId);
            var serverLIst = _serverCommandService.GetAll().ToList();

            try
            {
                _result = new XDocument(new XDeclaration("1.0", "utf-8", "true"));

                #region city

                if (city == null) throw new ArgumentException("No hay parametros de salidas para la city");
                XElement _Root = new XElement("Messages");
                XElement _Header = new XElement("HEADER");
                XElement _city = new XElement("CITY");
                XElement _country = new XElement("COUNTRY");
                XElement _customer = new XElement("CUSTOMERINFO");
                XElement _Servers = new XElement("SERVERS");

               

                //agragar los valores de city
                _city.Add(new XElement("Id", city.Id));
                _city.Add(new XElement("CountryId",city.CountryId));
                _city.Add(new XElement("Description", city.Description));
                _city.Add(new XElement("Code", city.Code ));
                _city.Add(new XElement("State", city.State));
                _city.Add(new XElement("Longitude", city.Longitude));
                _city.Add(new XElement("Latitude", city.Latitude));
                _city.Add(new XElement("TimeZone", city.TimeZone));
                _city.Add(new XElement("externalId", city.ExternalId));
                _city.Add(new XElement("enabled", city.Enabled));

                _Root.Add(_city);


                //agragar los valores de country
                _country.Add(new XElement("Id", country.Id));
                _country.Add(new XElement("Descripcion", country.Descripcion));
                _country.Add(new XElement("IsoCode", country.IsoCode));
                _country.Add(new XElement("IsoCodi", country.IsoCodi));

                _Root.Add(_country);


                //agragar los valores de customer
                _customer.Add(new XElement("Id", customer.Id));
                _customer.Add(new XElement("CustomerName", customer.CustomerName));
                _customer.Add(new XElement("UserId", customer.UserId));
                _customer.Add(new XElement("CustomerType", customer.CustomerType));
                _customer.Add(new XElement("CustomerSegment", customer.CustomerSegment));
                _customer.Add(new XElement("Email", customer.Email));
                _customer.Add(new XElement("CustomerBranch", customer.CustomerBranch));
                _customer.Add(new XElement("ParentCustomerId", customer.ParentCustomerId));
                _customer.Add(new XElement("ChildDocumentType", customer.ChildDocumentType));
                _customer.Add(new XElement("ChildDocumentNumber", customer.ChildDocumentNumber));
                _customer.Add(new XElement("DocumentType", customer.DocumentType));
                _customer.Add(new XElement("DocumentNumber", customer.DocumentNumber));

                _Root.Add(_customer);


                serverLIst.ForEach(item =>
                {
                    XElement _Server = new XElement("SERVER");

                    _Server.Add(new XElement("Id", item.Id));
                    _Server.Add(new XElement("ServerSource", item.ServerSource));
                    _Server.Add(new XElement("ServiceSource", item.ServiceSource));
                    _Server.Add(new XElement("Chanel", item.Chanel));
                    _Server.Add(new XElement("funcion", item.Funcion));
                    _Server.Add(new XElement("languge", item.Languge));
                    _Server.Add(new XElement("Country", item.Country));
                    _Server.Add(new XElement("ServiceSource", item.SesionId));
                    _Server.Add(new XElement("Chanel", item.Serverip));

                    _Servers.Add(_Server);
                });

               
                _Root.Add(_Servers);
                _result.Add(_Root);
                #endregion
            }
            catch (Exception)
            {

                throw;
            }


            return _result.ToString();
        }
       
    }
}

using Layer.DATA.Model;
using System;
using System.Xml;
using System.Xml.Linq;
using WebAppGenesis.ModelView;


namespace WebAppGenesis.Response
{
    public class ResponseDocumentXML
    {

        public static HeaderViewModel GetListDocXML(string xmlDocument)
        {
           
           HeaderViewModel headerViewModel = new HeaderViewModel();

            #region codigo_ejlempo
            /*
            XDocument xmlDoc = XDocument.Parse(xmlDocument);
            IEnumerable<XElement> titleElements = xmlDoc.Element("books").Elements("book").Elements("title");
            XElement xElement = XElement.Parse(xml);
            XElement headerElement = xml.Descendants().Where(e => e.Name.LocalName == "HEADER").FirstOrDefault();
            XDocument xDocument = XDocument.Load("bookparticipants.xml", LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
            XElement internalIdElement = headerElement.Descendants().FirstOrDefault(e => e.Name.LocalName == "SERVERSOURCE");

            // Cargar el archivo XML
            XDocument doc = XDocument.Load("archivo.xml");

            // Recorrer los departamentos
            Console.WriteLine("Departamentos:");
            var departamentos = doc.Descendants("departamento");
            foreach (var departamento in departamentos)
            {
                string id = departamento.Element("id").Value;
                string nombre = departamento.Element("nombre").Value;
                Console.WriteLine($"ID: {id}, Nombre: {nombre}");
            }

            // Recorrer los empleados
            Console.WriteLine("\nEmpleados:");
            var empleados = doc.Descendants("empleado");
            foreach (var empleado in empleados)
            {
                string id = empleado.Element("id").Value;
                string nombre = empleado.Element("nombre").Value;
                string puesto = empleado.Element("puesto").Value;
                string departamento_id = empleado.Element("departamento_id").Value;
                Console.WriteLine($"ID: {id}, Nombre: {nombre}, Puesto: {puesto}, Departamento ID: {departamento_id}");
            }
        }
            ---------------------------------------------------------------------------------------------------
            otra forma de recorrer un xml
            -------------------------------------------------------------------------------------------------------
            // Cargar el archivo XML
        XmlDocument doc = new XmlDocument();
        doc.Load("archivo.xml");

        // Recorrer los departamentos
        Console.WriteLine("Departamentos:");
        XmlNodeList departamentos = doc.SelectNodes("/empresa/departamentos/departamento");
        foreach (XmlNode departamento in departamentos)
        {
            string id = departamento.SelectSingleNode("id").InnerText;
            string nombre = departamento.SelectSingleNode("nombre").InnerText;
            Console.WriteLine($"ID: {id}, Nombre: {nombre}");
        }

        // Recorrer los empleados
        Console.WriteLine("\nEmpleados:");
        XmlNodeList empleados = doc.SelectNodes("/empresa/empleados/empleado");
        foreach (XmlNode empleado in empleados)
        {
            string id = empleado.SelectSingleNode("id").InnerText;
            string nombre = empleado.SelectSingleNode("nombre").InnerText;
            string puesto = empleado.SelectSingleNode("puesto").InnerText;
            string departamento_id = empleado.SelectSingleNode("departamento_id").InnerText;
            Console.WriteLine($"ID: {id}, Nombre: {nombre}, Puesto: {puesto}, Departamento ID: {departamento_id}");
        }
    }


            */
        #endregion

        XDocument xml = XDocument.Parse(xmlDocument);

            #region serverInfoXML

            XElement headerElement = xml.Descendants().FirstOrDefault(e => e.Name.LocalName == "HEADER");
            if (headerElement != null)
            {
                var serverInfo = new ModelView.ServerInfo
                {
                    ServerSource = headerElement.Element("SERVERSOURCE").Value,
                    ServiceSource = headerElement.Element("SERVICESOURCE").Value,
                    Chanel = headerElement.Element("CHANNEL").Value,
                    Funcion = headerElement.Element("FUNCTION").Value,
                    Languge = headerElement.Element("LANGUAGE").Value,
                    Country = headerElement.Element("COUNTRY-T").Value,
                    SesionId = Convert.ToInt32( headerElement.Element("SESSIONID").Value),
                    Serverip = headerElement.Element("SERVER_IP").Value,
                };

                headerViewModel._serverInfo.Add(serverInfo);

            }
            #endregion

            #region infoCustomerXML

            XElement customerInfoElement = xml.Descendants().Where(e => e.Name.LocalName == "CUSTOMERINFO").FirstOrDefault();
            if (customerInfoElement != null)
            {

                var infoCustomer = new ModelView.InfoCustomer
                {
                    Id = Convert.ToInt32(customerInfoElement.Element("CUSTOMERID").Value),
                    CustomerName = customerInfoElement.Element("CUSTOMERNAME").Value,
                    UserId = customerInfoElement.Element("USERID").Value,
                    CustomerType = customerInfoElement.Element("CUSTOMERTYPE").Value,
                    CustomerSegment = customerInfoElement.Element("CUSTOMERSEGMENT").Value,
                    Email = customerInfoElement.Element("EMAIL").Value,
                    CustomerBranch = Convert.ToInt32(customerInfoElement.Element("CUSTOMERBRANCH").Value),
                    ParentCustomerId = Convert.ToInt32(customerInfoElement.Element("PARENT-CUSTOMERID").Value),
                    ChildDocumentType = customerInfoElement.Element("CHILDDOCUMENTTYPE").Value,
                    ChildDocumentNumber = customerInfoElement.Element("CHILDDOCUMENTNUMBER").Value,
                    DocumentType = customerInfoElement.Element("DOCUMENTTYPE").Value,
                    DocumentNumber = customerInfoElement.Element("DOCUMENTNUMBER").Value,

                };

                headerViewModel._infocustomer.Add(infoCustomer);

            }
            #endregion

            #region countryXML

            XElement countryElement = xml.Descendants().Where(e => e.Name.LocalName == "COUNTRY").FirstOrDefault();
            if (countryElement != null)
            {
             
                var country = new ModelView.Country
                {
                    Id = Convert.ToInt32(countryElement.Element("INTERNAL-ID").Value),
                    Descripcion = countryElement.Element("DESCRIPCION").Value,
                    IsoCode = countryElement.Element("CODE-ISO").Value,
                    IsoCodi = countryElement.Element("ISO-CODI").Value,
                   
                };

                headerViewModel._country.Add(country);
            }

            #endregion


            #region XML_city

            XElement cityElement = xml.Descendants().FirstOrDefault(e => e.Name.LocalName == "CITY");
            if (cityElement != null)
            {
                var city = new ModelView.City
                {
                    Id = Convert.ToInt32(cityElement.Element("INTERNAL-ID").Value),
                    CountryId = Convert.ToInt32(cityElement.Element("COUNTRY-CODE").Value),
                    Description = cityElement.Element("DESCRIPCION").Value,
                    Code = cityElement.Element("CODE").Value,
                    State = cityElement.Element("STATE").Value,
                    Longitude = Convert.ToDouble(cityElement.Element("LONGITUDE").Value),
                    Latitude = Convert.ToDouble( cityElement.Element("LATITUDE").Value),
                    TimeZone = cityElement.Element("TIMEZONE").Value,
                    ExternalId = cityElement.Element("EXTERNALID").Value,
                    Enabled = Convert.ToBoolean(cityElement.Element("ENABLED").Value),
                   

                };

                headerViewModel._city.Add(city);
            }
            #endregion


            return headerViewModel; 

        }
    }
}

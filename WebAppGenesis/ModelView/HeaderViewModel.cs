using Layer.DATA.Model;

namespace WebAppGenesis.ModelView
{
    public class HeaderViewModel
    {
        public List<ServerInfo> _serverInfo { get; set; }
        public List<City> _city { get; set; }
        public List<Country> _country { get; set; }
        public List<InfoCustomer> _infocustomer { get; set; }


        public HeaderViewModel()
        {
            _city = new List<City>();
            _country = new List<Country>();
            _infocustomer = new List<InfoCustomer>();
            _serverInfo = new List<ServerInfo>();
        }
    }

    public partial class City
    {
        
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Description { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string State { get; set; } = null!;
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string TimeZone { get; set; } = null!;
        public string ExternalId { get; set; } = null!;
        public bool? Enabled { get; set; }
    }

    public partial class Country
    {
        
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? IsoCode { get; set; }
        public string? IsoCodi { get; set; }
    }

    public partial class InfoCustomer
    {
        
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string? CustomerType { get; set; }
        public string? CustomerSegment { get; set; }
        public string Email { get; set; } = null!;
        public int CustomerBranch { get; set; }
        public int ParentCustomerId { get; set; }
        public string ChildDocumentType { get; set; } = null!;
        public string ChildDocumentNumber { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
    }

    public partial class ServerInfo
    {
        
        public int Id { get; set; }
        public string ServerSource { get; set; } = null!;
        public string ServiceSource { get; set; } = null!;
        public string Chanel { get; set; } = null!;
        public string Funcion { get; set; } = null!;
        public string Languge { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int SesionId { get; set; }
        public string Serverip { get; set; } = null!;
    }

}

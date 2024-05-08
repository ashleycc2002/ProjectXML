using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Layer.DATA.Model
{
    [Table("ServerInfo")]
    public partial class ServerInfo
    {
        [Key]
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

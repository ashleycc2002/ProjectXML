using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Layer.DATA.Model
{
    [Table("City")]
    public partial class City
    {
        [Key]
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
}

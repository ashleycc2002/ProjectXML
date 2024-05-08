using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Layer.DATA.Model
{
    [Table("Country")]
    public partial class Country
    {
        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? IsoCode { get; set; }
        public string? IsoCodi { get; set; }
    }
}

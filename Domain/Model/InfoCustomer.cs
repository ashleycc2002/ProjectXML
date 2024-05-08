using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Layer.DATA.Model
{
    [Table("InfoCustomer")]
    public partial class InfoCustomer
    {
        [Key]
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
}

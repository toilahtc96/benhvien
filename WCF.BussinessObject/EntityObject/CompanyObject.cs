using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class CompanyObject
    {
        [Required]
        public Guid CompanyID { get; set; }

        [DataType("Varchar")]
        [MaxLength(100)]
        public string CompanyName { get; set; }
    }
}
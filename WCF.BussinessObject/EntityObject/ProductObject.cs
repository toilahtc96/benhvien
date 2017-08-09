using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ProductObject
    {
        [Required]
        public Guid ProductID { get; set; }

        [DataType("Varchar")]
        [MaxLength(150)]
        public string ProductName { get; set; }

        [DataType("Varchar")]
        [MaxLength(150)]
        public string ProductSize { get; set; }

        public decimal ProductPrice { get; set; }
        public bool? HomeFlag { get; set; }
        public string Detail { get; set; }
        public double? Sale { get; set; }

        [Required]
        public Guid? CompanyID { get; set; }

        public Guid? CategoryID { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ProductCategoryObject
    {
        [Required]
        public Guid ProductCategoryID { get; set; }

        [DataType("Varchar")]
        [MaxLength(150)]
        public string CategoryName { get; set; }

        [DataType("Varchar")]
        public string CategoryDescription { get; set; }
    }
}
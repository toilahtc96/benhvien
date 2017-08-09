using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ProductImageObject
    {
        [Required]
        public Guid ImageID { get; set; }

        public string URL { get; set; }
        public Guid ProductID { get; set; }
    }
}
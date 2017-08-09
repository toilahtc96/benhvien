using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ShopAddressObject
    {
        [Required]
        public Guid ShopAddressID { get; set; }

        [DataType("Varchar")]
        public string Address { get; set; }
    }
}
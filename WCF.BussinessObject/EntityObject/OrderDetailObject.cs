using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class OrderDetailObject
    {
        [Required]
        public Guid OrderDetailID { get; set; }

        public Guid? ProductID { get; set; }
        public Guid? OrderID { get; set; }
        public int? Quantity { get; set; }
    }
}
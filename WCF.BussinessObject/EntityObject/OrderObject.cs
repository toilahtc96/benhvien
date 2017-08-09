using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class OrderObject
    {
        [Required]
        public Guid OrderID { get; set; }

        public DateTime CreateDate { get; set; }

        [DataType("Varchar")]
        [MaxLength(150)]
        public string CreateBy { get; set; }
        public Guid? UserID { get; set; }
    }
}
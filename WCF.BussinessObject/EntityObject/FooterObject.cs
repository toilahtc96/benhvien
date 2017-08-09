using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class FooterObject
    {
        [Required]
        public Guid FooterID { get; set; }

        [DataType("Varchar")]
        [MaxLength(100)]
        public string FooterName { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class CountryObject
    {
        [Required]
        public Guid CounttryID { get; set; }

        [DataType("Varchar")]
        [MaxLength(50)]
        public string CountryName { get; set; }
    }
}
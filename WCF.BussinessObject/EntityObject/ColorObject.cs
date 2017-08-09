using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ColorObject
    {
        [Required]
        public Guid ColorID { get; set; }

        [DataType("Varchar")]
        [MaxLength(50)]
        public string ColorName { get; set; }
    }
}
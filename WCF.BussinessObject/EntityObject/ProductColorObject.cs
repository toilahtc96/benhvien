using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ProductColorObject
    {
        [Required]
        public Guid ProductColorID { get; set; }

        public Guid? ProductID { get; set; }
        public Guid? ColorID { get; set; }
    }
}
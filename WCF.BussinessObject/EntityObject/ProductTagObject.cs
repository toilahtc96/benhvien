using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ProductTagObject
    {
        [Required]
        public Guid ProductTagID { get; set; }

        public Guid? ProductID { get; set; }
        public Guid? tagID { get; set; }
    }
}
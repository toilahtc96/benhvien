using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class MenuItemObject
    {
        [Required]
        public Guid MenuItemID { get; set; }

        [DataType("Varchar")]
        [MaxLength(150)]
        public string MenuItemName { get; set; }

        public int? Position { get; set; }

        [DataType("Varchar")]
        [MaxLength(200)]
        public string URL { get; set; }

        public Guid? MenuGroupID { get; set; }
    }
}
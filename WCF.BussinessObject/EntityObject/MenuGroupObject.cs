using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class MenuGroupObject
    {
        [Required]
        public Guid MenuGroupID { get; set; }

        [DataType("Varchar")]
        [MaxLength(150)]
        public string MenuGroupName { get; set; }
    }
}
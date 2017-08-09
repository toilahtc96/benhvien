using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class RoleObject
    {
        [Required]
        public Guid RoleID { get; set; }

        [DataType("Varchar")]
        [MaxLength(50)]
        public string RoleName { get; set; }
    }
}
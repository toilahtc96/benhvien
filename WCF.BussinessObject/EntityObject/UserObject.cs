using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class UserObject
    {
        [Required]
        public Guid UserID { get; set; }

        [DataType("Varchar")]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [DataType("Varchar")]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        [DataType("Varchar")]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [DataType("Varchar")]
        [MaxLength(150)]
        public string PassWord { get; set; }

        public string Mobile { get; set; }
        public string Address { get; set; }

        [Required]
        public Guid RoleID { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ContactObject
    {
        [Required]
        public Guid ContactID { get; set; }

        [DataType("Varchar")]
        [MaxLength(100)]
        public string Name { get; set; }

        [DataType("Varchar")]
        [MaxLength(50)]
        public string Email { get; set; }

        [DataType("Varchar")]
        [MaxLength(20)]
        public string Phone { get; set; }

        [DataType("Varchar")]
        public string Message { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
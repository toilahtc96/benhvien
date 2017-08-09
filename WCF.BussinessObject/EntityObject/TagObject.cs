using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class TagObject
    {
        [Required]
        public Guid TagID { get; set; }

        [DataType("Varchar")]
        [MaxLength(100)]
        public string TagName { get; set; }

        [DataType("Varchar")]
        [MaxLength(100)]
        public string TagType { get; set; }
    }
}
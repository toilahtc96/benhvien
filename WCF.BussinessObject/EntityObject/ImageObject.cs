using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ImageObject
    {
        [Required]
        public Guid ImageID { get; set; }

        [DataType("Varchar")]
        [MaxLength(500)]
        public string URL { get; set; }

        public bool BannerFlag { get; set; }
        public bool? LogoFlag { get; set; }
    }
}
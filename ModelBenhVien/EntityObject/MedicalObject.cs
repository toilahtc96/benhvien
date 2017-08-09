using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class MedicalObject
    {
        [Display(Name = "ID")]
        [Required]
        public Guid ID { get; set; }
        [Display(Name = "Tên Khoa")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Mô Tả Khoa")]
        public string Description { get; set; }
        [Display(Name = "Hình Ảnh")]
        public string Image { get; set; }
    }
}
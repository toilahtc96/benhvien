using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class EquipmentObject
    {
        [Required]
        [Display(Name = "ID")]
        public Guid ID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Detail")]
        public string Detail { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
    }
}
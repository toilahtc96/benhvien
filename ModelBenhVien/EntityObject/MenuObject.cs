using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class MenuObject
    {
        [Required]
        public Guid ID { get; set; }
        
        [Display(Name = "MenuItem 1")]
        public string MenuItem1 { get; set; }
        [Display(Name = "MenuItem 2")]
        public string MenuItem2 { get; set; }
        [Display(Name = "MenuItem 3")]
        public string MenuItem3 { get; set; }
        [Display(Name = "MenuItem 4")]
        public string MenuItem4 { get; set; }
        [Display(Name = "MenuItem 5")]
        public string MenuItem5 { get; set; }
        [Display(Name = "MenuItem 6")]
        public string MenuItem6 { get; set; }
      
    }
}
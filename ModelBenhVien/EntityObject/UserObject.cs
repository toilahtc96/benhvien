using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class UserObject
    {
        [Display(Name = "UserName")]
        [Required]
        public string UserName { get; set; }
        [Display(Name = "Name")]

        public string Name { get; set; }
       
        [Display(Name = "PassWord")]
        [Required]
        public string PassWord { get; set; }
    }
}
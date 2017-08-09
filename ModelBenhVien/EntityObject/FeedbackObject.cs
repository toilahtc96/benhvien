using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class FeedbackObject
    {
        [Display(Name = "ID")]
        [Required]
        public Guid ID { get; set; }
        [Display(Name = "Tên Người Nhắn")]
        [Required]
        public string CustomerName { get; set; }
        [Display(Name = "Số Điện Thoại")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Display(Name = "Nội Dung")]
        public string NoiDung { get; set; }
        [Display(Name = "Ngày nhắn")]
        [Required]
        public DateTime CrateDate { get; set; }
    }
}
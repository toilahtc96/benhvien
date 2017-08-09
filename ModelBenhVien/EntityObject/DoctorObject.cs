using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class DoctorObject
    {
        [Display(Name="ID")]
        [Required]
        public Guid ID { get; set; }
        [Display(Name = "ID Trưởng Khoa")]
        [Required(ErrorMessage ="Chưa Nhập Thông Tin")]
        public Guid IDKhoa { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "Chưa Nhập Thông Tin")]
        public bool Status { get; set; }
        [Display(Name = "Tên Bác Sĩ")]
        [Required(ErrorMessage = "Chưa Nhập Thông Tin")]
        public string Name { get; set; }
        [Display(Name = "Mô Tả")]
        public string Description { get; set; }
        [Display(Name = "Hình Ảnh Đại Diện")]
        public string Images { get; set; }
        [Display(Name = "Tên Khoa")]
        public string MedicalName { get; set; }
    }
}
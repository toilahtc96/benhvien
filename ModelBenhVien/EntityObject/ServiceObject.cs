using System;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class ServiceObject
    {
        [Required]
        public Guid ID { get; set; }
        [Display(Name="Dịch Vụ")]
        [Required]
        public string TittleDichVu { get; set; }
        [Display(Name = "Giới Thiệu Về Bệnh Viện")]
        [Required]
        public string TittleGioiThieu { get; set; }
        [Required]
        [Display(Name = "Phòng Khám")]
        public string TittlePhongKham { get; set; }
        [Required]
        [Display(Name = "Cơ Sở Vật Chất")]
        public string TittleCoSoVatChat { get; set; }
        [Display(Name = "Chuyên Khoa")]
        [Required]
        public string TittleChuyenKhoa { get; set; }
        [Display(Name = "Liên Hệ")]
        [Required]
        public string TittleLienHe { get; set; }
        [Display(Name = "Mô Tả Dịch Vụ")]
        
        public string DescriptionDichVu { get; set; }
        [Display(Name = "Mô Tả Bệnh Viện")]
        public string DescriptionGioiThieu { get; set; }
        [Display(Name = "Mô Tả Phòng Khám")]
        public string DescriptionPhongKham { get; set; }
        [Display(Name = "Mô Tả Cơ Sở Vật Chất")]
        public string DescriptionCosoVatChat { get; set; }
        [Display(Name = "Mô Tả Chuyên Khoa")]
        public string DescriptionChuyenKhoa { get; set; }
        [Display(Name = "Mô Tả Liên Hệ")]
        public string DescriptionLienHe { get; set; }
        [Display(Name = "Chi tiêt Dịch Vụ ")]
        public string DetailDichVu { get; set; }
        [Display(Name = "Chi tiêt Giới Thiệu")]
        public string DetailGioiThieu { get; set; }
        [Display(Name = "Chi tiêt Phòng Khám")]
        public string DetailPhongKham { get; set; }
        [Display(Name = "Chi tiêt Cơ Sở Vật Chất")]
        public string DetailCosoVatChat { get; set; }
        [Display(Name = "Chi tiêt Chuyên Khoa")]
        public string DetailChuyenKhoa { get; set; }
        [Display(Name = "Chi tiêt Liên Hệ")]
        public string DetailLienHe { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }
        [Display(Name = "Hình Ảnh Khuôn Viên")]
        [Required]
        public string Image { get; set; }
        [Display(Name = "Hot Line")]
        public string HotLine { get; set; }
        [Display(Name = "Điện Thoại")]
        public string Phone { get; set; }
        [Display(Name = "BackGround")]
        public string BackGround { get; set; }
        [Display(Name = "Logo Image")]
        [Required]
        public string LogoImage { get; set; }

        [Display(Name = "Slogan")]
        public string Slogan { get; set; }
    }
}
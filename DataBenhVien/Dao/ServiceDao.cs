using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataBenhVien.Dao
{
    public class ServiceDao
    {
        private DataModel.benhvienEntities1 db = new DataModel.benhvienEntities1();

        public List<ServiceObject> Service_GetAll()
        {
            var serviec_list = db.SP_Services_GetAll();
            List<ServiceObject> ServiceList = new List<ServiceObject>();
            foreach (var item in serviec_list)
            {
                ServiceObject svo = new ServiceObject();
                svo.ID = item.ID;
                svo.Address = item.Address;
                svo.DescriptionChuyenKhoa = item.DescriptionChuyenKhoa;
                svo.DescriptionCosoVatChat = item.DescriptionCosovatchat;
                svo.DescriptionDichVu = item.DescriptionDichvu;
                svo.DescriptionGioiThieu = item.DescriptionGioithieu;
                svo.DescriptionLienHe = item.DescriptionLienHe;
                svo.DescriptionPhongKham = item.DescriptionPhongkham;
                svo.DetailChuyenKhoa = item.DetailChuyenkhoa;
                svo.DetailCosoVatChat = item.DetailCosovatchat;
                svo.DetailDichVu = item.DetailDichvu;
                svo.DetailGioiThieu = item.DetailGioithieu;
                svo.DetailLienHe = item.DetailLienhe;
                svo.DetailPhongKham = item.DetailPhongkham;
                svo.HotLine = item.HotLine;
                svo.Image = item.Images;
                svo.Phone = item.Phone;
                svo.TittleChuyenKhoa = item.TitleChuyenkhoa;
                svo.TittleCoSoVatChat = item.TitleCosovatchat;
                svo.TittleDichVu = item.TitleDichvu;
                svo.TittleGioiThieu = item.TitleGioiThieu;
                svo.TittleLienHe = item.TitleLienhe;
                svo.TittlePhongKham = item.TitlePhongKham;
                svo.BackGround = item.BackGround;
                svo.LogoImage = item.Logo;
                svo.Slogan = item.Slogan;
                ServiceList.Add(svo);
            }
            return ServiceList;
        }

        public ServiceObject Service_GetByID(Guid id)
        {
            var ser = db.SP_Services_GetByID(id);
            ServiceObject svo = new ServiceObject();
            foreach (var item in ser)
            {
                svo.ID = item.ID;
                svo.Address = item.Address;
                svo.DescriptionChuyenKhoa = item.DescriptionChuyenKhoa;
                svo.DescriptionCosoVatChat = item.DescriptionCosovatchat;
                svo.DescriptionDichVu = item.DescriptionDichvu;
                svo.DescriptionGioiThieu = item.DescriptionGioithieu;
                svo.DescriptionLienHe = item.DescriptionLienHe;
                svo.DescriptionPhongKham = item.DescriptionPhongkham;
                svo.DetailChuyenKhoa = item.DetailChuyenkhoa;
                svo.DetailCosoVatChat = item.DetailCosovatchat;
                svo.DetailDichVu = item.DetailDichvu;
                svo.DetailGioiThieu = item.DetailGioithieu;
                svo.DetailLienHe = item.DetailLienhe;
                svo.DetailPhongKham = item.DetailPhongkham;
                svo.HotLine = item.HotLine;
                svo.Image = item.Images;
                svo.Phone = item.Phone;
                svo.TittleChuyenKhoa = item.TitleChuyenkhoa;
                svo.TittleCoSoVatChat = item.TitleCosovatchat;
                svo.TittleDichVu = item.TitleDichvu;
                svo.TittleGioiThieu = item.TitleGioiThieu;
                svo.TittleLienHe = item.TitleLienhe;
                svo.TittlePhongKham = item.TitlePhongKham;
                svo.BackGround = item.BackGround;
                svo.LogoImage = item.Logo;
                svo.Slogan = item.Slogan;
            }
            return svo;
        }

        public void Service_Update(ServiceObject svo)
        {
            db.SP_Services_UPDATE(svo.ID, svo.TittleDichVu, svo.TittleGioiThieu, svo.TittlePhongKham, 
                svo.TittleCoSoVatChat, svo.TittleChuyenKhoa, svo.TittleLienHe, svo.DescriptionDichVu,
                svo.DescriptionGioiThieu, svo.DescriptionPhongKham, svo.DescriptionCosoVatChat, svo.DescriptionChuyenKhoa,
                svo.DescriptionLienHe, svo.DetailDichVu, svo.DetailGioiThieu, svo.DetailPhongKham,svo.DetailCosoVatChat, svo.DetailChuyenKhoa,
                svo.DetailLienHe, svo.Image, svo.Address, svo.HotLine, svo.Phone,svo.LogoImage,svo.BackGround,svo.Slogan);
        }

        public void Service_Insert(ServiceObject svo)
        {
            db.SP_Services_INSERT(svo.ID, svo.TittleDichVu, svo.TittleGioiThieu, svo.TittlePhongKham,
                svo.TittleCoSoVatChat, svo.TittleChuyenKhoa, svo.TittleLienHe, svo.DescriptionDichVu,
                svo.DescriptionGioiThieu, svo.DescriptionPhongKham, svo.DescriptionCosoVatChat, svo.DescriptionChuyenKhoa,
                svo.DescriptionLienHe, svo.DetailDichVu, svo.DetailGioiThieu, svo.DetailPhongKham, svo.DetailCosoVatChat, svo.DetailChuyenKhoa,
                svo.DetailLienHe, svo.Image, svo.Address, svo.HotLine, svo.Phone,svo.LogoImage,svo.BackGround, svo.Slogan);
        }

        public void Service_delele(Guid id)
        {
            db.SP_Services_DELETE(id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationQlahsVksndtcWindowsFormsApp.PageObject;
using AutomationQlahsVksndtcWindowsFormsApp.PageObjects;
using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;

namespace AutomationQlahsVksndtcWindowsFormsApp.TestCases
{
    class ThuLyPopUpClass:TestCaseClass
    {
        private static ThuLyPopUpClass _instance;
        static string id;
        private ThuLyPopUpClass()
        {

        }
        public static ThuLyPopUpClass Instance(string _id)
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            id = _id;
            if (_instance == null)
            {
                _instance = new ThuLyPopUpClass();
            }
            return _instance;
        }
        public void Go()
        {
            JObject json =  JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();
            

            //ChromeDriver chromeDriver = new ChromeDriver("C:/lqa/automationdotnet");
            ChromeDriver chromeDriver = new ChromeDriver(Application.StartupPath);
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LoginPage lp = new LoginPage();
            lp.driver = chromeDriver;
            lp.Come();

            jsonObject.username = "khanh";
            jsonObject.password = "123456";

            lp.DangNhap(jsonObject);


            ///////Tạo mới vụ án///////Tạo mới vụ án///////Tạo mới vụ án///////
            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            KiemSatDieuTraTruyTo kiemSatDieuTraTruyTo = new KiemSatDieuTraTruyTo();
            kiemSatDieuTraTruyTo.driver = chromeDriver;
            kiemSatDieuTraTruyTo.Come();
            kiemSatDieuTraTruyTo.TimVuAn();

            //ThuLyPopUp thuLyPopUp = new ThuLyPopUp();
            //thuLyPopUp.driver = chromeDriver;
            //thuLyPopUp.DienThongTin(jsonObject);

            //jsonObject["ksvHoTen"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["HoTen"];
            //jsonObject["ksvSoQuyetDinh"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["SoQuyetDinh"];
            //jsonObject["ksvNgayPhanCong"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["NgayPhanCong"];
            //jsonObject["ksvNgayKetThuc"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["NgayKetThuc"];

            jsonObject["ksvHoTen"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["HoTen"];
            jsonObject["ksvSoQuyetDinh"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["SoQuyetDinh"];
            jsonObject["ksvNgayPhanCong"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["NgayPhanCong"];
            jsonObject["ksvNgayKetThuc"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["NgayKetThuc"];

            //PhanCongKiemSatVien phanCongKiemSatVien = new PhanCongKiemSatVien();
            //phanCongKiemSatVien.driver = chromeDriver;
            //phanCongKiemSatVien.FillForm(jsonObject);

            // Bị can
            // Bị can - khởi tố bị can
            jsonObject["bcSoQuyetDinh"] = json["BiCanHoSo"][0]["QDKhoiToBiCan"]["SoQuyetDinh"];
            jsonObject["bcNgayRaQuyetDinh"] = json["BiCanHoSo"][0]["QDKhoiToBiCan"]["NgayRaQuyetDinh"];
            jsonObject[""] = json["BiCanHoSo"][0]["QDKhoiToBiCan"]["TenCoQuan"];
            jsonObject[""] = json["BiCanHoSo"][0]["QDKhoiToBiCan"]["TenDonVi"];

            // Bị can - thông tin bị can
            jsonObject["bcHoTen"] = json["BiCanHoSo"][0]["ThongTinBiCan"]["HoTen"];
            jsonObject["bcTenDanTocCT"] = json["BiCanHoSo"][0]["ThongTinBiCan"]["TenDanToc"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["TenQuocTich"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["SoCMT"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["NoiOHienTai"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["TenNgheNghiep"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["TenDangVien"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaBiCanDauVu"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["TenKhac"];
            jsonObject["bcNgaySinh"] = json["BiCanHoSo"][0]["ThongTinBiCan"]["NgaySinh"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["GioiTinh"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["TenHocVan"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["TenChucVuChinhQuyen"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["SoTienAn"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["SoTienSu"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaCanBoCongNhanVienChuc"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaCoNguoiBaoChua"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaDoiTuongLangThang"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaHanhNgheTonGiao"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaHocSinhTruongChuyenNghiep"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaLuuManh"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaNghienHut"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaTapTrungCaiTaoTuHinhSu"];
            jsonObject[""] = json["BiCanHoSo"][0]["ThongTinBiCan"]["LaThuongBinhBoDoiPhucVien"];

            //BiCan biCan = new BiCan();
            //biCan.driver = chromeDriver;
            //biCan.DienThongTin(jsonObject);

            // Bị can - Quyết định bị can  - thụ lý khởi tố
            jsonObject[""] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["HoTen"];
            jsonObject["qdBcSoQuyetDinh"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]
                ["SoQuyetDinh"] != null ? json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["SoQuyetDinh"] : "0";
            jsonObject["qdBcNgayRaQuyetDinh"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]
                ["NgayRaQuyetDinh"] != null ? json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["NgayRaQuyetDinh"] : "01/01/2019";
            jsonObject["qdBcHieuLuc"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["HieuLucTuNgay"];
            jsonObject[""] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["HieuLucDenNgay"];
            jsonObject[""] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["TenCoQuan"];
            jsonObject[""] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["TenDonVi"];
            jsonObject["qdBcTenloaiCT"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["Tenloai"];
            jsonObject[""] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["NoiDungLyDo"];
            jsonObject[""] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["ThoiHanThucTe"];


            jsonObject["qdBcTenNguoiKy"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]
                ["TenNguoiKy"] != null ? json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["TenNguoiKy"] : "null";
            jsonObject["qdBcTenChucVu"] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]
                ["TenChucVu"] != null ? json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["TenChucVu"] : "null";

            jsonObject["qdBcTenNguoiKy"] = jsonObject["qdBcTenChucVu"] = "aa";

            string g = jsonObject["qdBcTenNguoiKy"].ToString();
            g = jsonObject["qdBcTenChucVu"].ToString();


            jsonObject[""] = json["ThuLyKhoiTo"]["QuyetDinhBiCan"][0]["NoiDung"];

            //QuyetDinhBiCan quyetDinhBiCan = new QuyetDinhBiCan();
            //quyetDinhBiCan.driver = chromeDriver;
            //quyetDinhBiCan.FillForm(jsonObject);

            jsonObject["klSoKetLuanDieuTra"] = json["ThuLyKhoiTo"]["SoKetLuanDieuTra"] != null ? json["ThuLyKhoiTo"]["SoKetLuanDieuTra"] : 0;
            jsonObject["klNgayRaKetLuan"] = json["ThuLyKhoiTo"]["NgayRaKetLuan"] != null ? json["ThuLyKhoiTo"]["NgayRaKetLuan"] : "01/01/2019";
            jsonObject["klNgayHieuLuc"] = json["ThuLyKhoiTo"]["NgayHieuLuc"];
            jsonObject["klNoiDung"] = json["ThuLyKhoiTo"]["NoiDung"];
            jsonObject["klNguoiKy"] = json["ThuLyKhoiTo"]["NguoiKy"] != null ? json["ThuLyKhoiTo"]["NguoiKy"] : "null";
            jsonObject["klChucVu"] = json["ThuLyKhoiTo"]["ChucVu"] != null ? json["ThuLyKhoiTo"]["ChucVu"] : "null";
            jsonObject["klNguoiKy"] = "Nguyen";
            jsonObject["klNguoiKy"] = "Chuc";
            jsonObject["klYKienCuaVKS"] = json["ThuLyKhoiTo"]["YKienCuaVKS"] = "y kien";
            //KetLuanDieuTra ketLuanDieuTra = new KetLuanDieuTra();
            //ketLuanDieuTra.driver = chromeDriver;
            //ketLuanDieuTra.FillForm(jsonObject);


            jsonObject["hsNgayGiaoNhan"] = json["GiaoNhanHoSoKSDT"]["NgayGiaoNhan"] != null ? json["GiaoNhanHoSoKSDT"]["NgayGiaoNhan"] : "01/01/2019";
            jsonObject["hsNguoiGiao"] = json["GiaoNhanHoSoKSDT"]["NguoiGiao"];
            jsonObject["hsNguoiNhan"] = json["GiaoNhanHoSoKSDT"]["NguoiNhan"];
            jsonObject["hsDonViNhan"] = json["GiaoNhanHoSoKSDT"]["DonViNhan"];

            GiaoNhanHoSo giaoNhanHoSo = new GiaoNhanHoSo();
            giaoNhanHoSo.driver = chromeDriver;
            giaoNhanHoSo.FillForm(jsonObject);

            chromeDriver.Quit();
        }
    }
}

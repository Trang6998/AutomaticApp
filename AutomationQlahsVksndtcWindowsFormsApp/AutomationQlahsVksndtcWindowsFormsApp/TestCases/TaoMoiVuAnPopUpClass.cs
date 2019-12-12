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
    class TaoMoiVuAnPopUpClass : TestCaseClass
    {
        private static TaoMoiVuAnPopUpClass _instance;
        static string id;
        static string username;
        static string password;
        static ChromeDriver chromeDriver;
        private TaoMoiVuAnPopUpClass()
        {

        }
        public static TaoMoiVuAnPopUpClass Instance(string _id, string _username, string _password)
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            id = _id;
            username = _username;
            password = _password;
            if (_instance == null)
            {
                _instance = new TaoMoiVuAnPopUpClass();
            }
            return _instance;
        }
        public void Go()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();
            jsonObject["quyetĐinhKhoiToVuAnSo"] = json["QuyetDinhKhoiTo"]["SoQuyetDinh"];
            chromeDriver = new ChromeDriver(Application.StartupPath);
            //ChromeDriver chromeDriver = new ChromeDriver("C:/lqa/automationdotnet");
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LoginPage lp = new LoginPage();
            lp.driver = chromeDriver;
            lp.Come();

            jsonObject.username = username;
            jsonObject.password = password;

            lp.DangNhap(jsonObject);


            ///////Tạo mới vụ án///////Tạo mới vụ án///////Tạo mới vụ án///////
            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            KiemSatDieuTraTruyTo kiemSatDieuTraTruyTo = new KiemSatDieuTraTruyTo();
            kiemSatDieuTraTruyTo.driver = chromeDriver;
            kiemSatDieuTraTruyTo.Come();
            //kiemSatDieuTraTruyTo.TimVuAn();

            kiemSatDieuTraTruyTo.AddVuAn();
            TaoMoiVuAnPopUp taoMoiVuAnPopUp = new TaoMoiVuAnPopUp();
            taoMoiVuAnPopUp.driver = chromeDriver;
            jsonObject["quyetĐinhKhoiToVuAnSo"] = json["QuyetDinhKhoiTo"]["SoQuyetDinh"];
            jsonObject["dieuLuatVu"] = json["ToiDanh"]["NoiDung"];
            jsonObject["donViRaQuyetDinh"] = json["QuyetDinhKhoiTo"]["TenDonVi"];
            jsonObject["tenVuAn"] = json["TenVuAn"];
            jsonObject["maVuCuaToaAn"] = json["MaSoVuAn"];
            jsonObject["loaiToiPham"] = json["LoaiToiPham"];
            jsonObject["txtNgayXayRa"] = json["NgayVuAn"];
            jsonObject["noiXayRa"] = json["NoiXayRa"];
            jsonObject["chiTietNoiXayRa"] = json["NoiXayRa"];
            jsonObject["txtNgayQDKhoiToVuAn"] = json["QuyetDinhKhoiTo"]["NgayRaQuyetDinh"];
            jsonObject["ghiChu"] = json["TomTatSuKienPhamToi"];
            jsonObject["DieuLuatKhoiToVuAn"] = json["DieuLuatKhoiToVuAn"];
            taoMoiVuAnPopUp.DienThongTin(jsonObject);

            taoThuLy();
            taoKiemSatVien();

            TaoBiCan();
            TaoQuyetDinhBiCan();
            TaoQuyetDinhVuAn();
            TaoKetLuanDieuTra();
            TaoGiaoNhanHoSo();

            TaoKiemSatVienTruyTo();
            TaoQuyetDinhBiCanTruyTo();
            TaoQuyetDinhVuAnTruyTo();
            TaoCaoTrang();
            TaoGiaoNhanHoSoTruyTo();
            chromeDriver.Quit();
        }

        public void taoThuLy()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();
            jsonObject["loaiThuLy"] = json["ThuLyKhoiTo"]["LoaiThuLy"];
            jsonObject["thuLySo"] = json["ThuLyKhoiTo"]["SoThuLy"];
            jsonObject["ngayThuLy"] = json["ThuLyKhoiTo"]["NgayThuLy"];
            jsonObject["thoiHanThuLyTuNgay"] = json["ThuLyKhoiTo"]["ThuTyTuNgay"];
            jsonObject["thoiHanThuLyDenNgay"] = json["ThuLyKhoiTo"]["ThuLyDenNgay"];
            jsonObject[""] = json["ThuLyKhoiTo"]["GhiChu"] !=null ? json["ThuLyKhoiTo"]["GhiChu"] : "null";
            jsonObject["anDiem"] = json["ThuLyKhoiTo"]["LoaiAnDiem"];
            jsonObject["luatSu"] = json["ThuLyKhoiTo"]["CoLuatSuThamGia"];
            ThuLyPopUp thuLyPopUp = new ThuLyPopUp();
            thuLyPopUp.driver = chromeDriver;
            thuLyPopUp.DienThongTin(jsonObject);   
        }

        public void taoKiemSatVien() {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();

            //jsonObject["ksvHoTen"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["HoTen"];
            //jsonObject["ksvHoTen"] = "Phan";
            //jsonObject["ksvSoQuyetDinh"] = json["ThuLyKhoiTo"]["KiemSatVienDieuTraVien"][0]["SoQuyetDinh"];
            //jsonObject["ksvNgayPhanCong"] = json["ThuLyKhoiTo"]["KiemSatVienDieuTraVien"][0]["NgayPhanCong"];
            //jsonObject["ksvNgayKetThuc"] = json["ThuLyKhoiTo"]["KiemSatVienDieuTraVien"][0]["NgayKetThuc"];

            PhanCongKiemSatVien phanCongKiemSatVien = new PhanCongKiemSatVien();
            phanCongKiemSatVien.driver = chromeDriver;
            //phanCongKiemSatVien.FillForm(jsonObject);

            //PhanCongKiemSatVien phanCongKiemSatVien = new PhanCongKiemSatVien();
            //phanCongKiemSatVien.driver = chromeDriver;


            JToken[] tksvtt = json["ThuLyKhoiTo"]["KiemSatVienDieuTraVien"].ToArray();

            foreach (JToken jTokenI in tksvtt)
            {
                
                //jsonObject["ksvHoTen"] = jTokenI["HoTen"] != null ? jTokenI["HoTen"] : "Phan";
                //(jTokenI["HoTen"] = "Phạm Thị Ngát") không có trong danh sách
                jsonObject["ksvHoTen"] = jTokenI["HoTen"];
                jsonObject["ksvSoQuyetDinh"] = jTokenI["SoQuyetDinh"];
                jsonObject["ksvNgayPhanCong"] = jTokenI["NgayPhanCong"];
                jsonObject["ksvNgayKetThuc"] = jTokenI["NgayKetThuc"];
                //string temp = jTokenI["NgayKetThuc"].ToString();
                //Console.WriteLine(temp);

                phanCongKiemSatVien.FillForm(jsonObject);
            }
        }
        public void TaoBiCan()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();

            BiCan biCan = new BiCan();
            biCan.driver = chromeDriver;
            JToken[] taoBiCan = json["BiCanHoSo"].ToArray();

            foreach (JToken jTokenI in taoBiCan)
            {
                jsonObject["bcSoQuyetDinh"] = jTokenI["QDKhoiToBiCan"]["SoQuyetDinh"];
                jsonObject["bcNgayRaQuyetDinh"] = jTokenI["QDKhoiToBiCan"]["NgayRaQuyetDinh"];
                jsonObject["bcTenCoQuan"] = jTokenI["QDKhoiToBiCan"]["TenCoQuan"];
                jsonObject["bcTenDonVi"] = jTokenI["QDKhoiToBiCan"]["TenDonVi"];

                // Bị can - thông tin bị can
                jsonObject["bcHoTen"] = jTokenI["ThongTinBiCan"]["HoTen"];
                jsonObject["bcTenDanToc"] = jTokenI["ThongTinBiCan"]["TenDanToc"];
                jsonObject["bcTenQuocTich"] = jTokenI["ThongTinBiCan"]["TenQuocTich"];
                jsonObject["bcCMND"] = jTokenI["ThongTinBiCan"]["SoCMT"] != null ? jTokenI["ThongTinBiCan"]["SoCMT"] : "null";
                jsonObject["bcNoiOHienTai"] = jTokenI["ThongTinBiCan"]["NoiOHienTai"] != null ? jTokenI["ThongTinBiCan"]["NoiOHienTai"] : "null";
                jsonObject["bcTenNgheNghiep"] = jTokenI["ThongTinBiCan"]["TenNgheNghiep"];
                jsonObject["bcTenDangVien"] = jTokenI["ThongTinBiCan"]["TenDangVien"];
                jsonObject["bcLaBiCanDauVu"] = jTokenI["ThongTinBiCan"]["LaBiCanDauVu"];
                jsonObject["bcTenKhac"] = jTokenI["ThongTinBiCan"]["TenKhac"];
                jsonObject["bcNgaySinh"] = jTokenI["ThongTinBiCan"]["NgaySinh"];
                jsonObject["bcGioiTinh"] = jTokenI["ThongTinBiCan"]["GioiTinh"];
                jsonObject["bcTenHocVan"] = jTokenI["ThongTinBiCan"]["TenHocVan"];
                jsonObject["bcTenTonGiao"] = jTokenI["ThongTinBiCan"]["TenTonGiao"];
                jsonObject["bcTenChucVu"] = jTokenI["ThongTinBiCan"]["TenChucVuChinhQuyen"];
                jsonObject["bcSoTienAn"] = jTokenI["ThongTinBiCan"]["SoTienAn"] == null? 0 : jTokenI["ThongTinBiCan"]["SoTienAn"];
                jsonObject["bcSoTienSu"] = jTokenI["ThongTinBiCan"]["SoTienSu"] == null? 0 : jTokenI["ThongTinBiCan"]["SoTienSu"];
                jsonObject["bcNoiOHienTai"] = jTokenI["ThongTinBiCan"]["NoiOHienTai"];
                jsonObject["bcLaCanBoCongNhanVienChuc"] = jTokenI["ThongTinBiCan"]["LaCanBoCongNhanVienChuc"];
                jsonObject["bcLaNgheNghiepKhongOnDinh"] = jTokenI["ThongTinBiCan"]["LaNgheNghiepKhongOnDinh"];
                jsonObject["bcLaCoNguoiBaoChua"] = jTokenI["ThongTinBiCan"]["LaCoNguoiBaoChua"];
                jsonObject["bcLaDoiTuongLangThang"] = jTokenI["ThongTinBiCan"]["LaDoiTuongLangThang"];
                jsonObject["bcLaHanhNgheTonGiao"] = jTokenI["ThongTinBiCan"]["LaHanhNgheTonGiao"];
                jsonObject["bcLaHocSinhTruongChuyenNghiep"] = jTokenI["ThongTinBiCan"]["LaHocSinhTruongChuyenNghiep"];
                jsonObject["bcLaLuuManh"] = jTokenI["ThongTinBiCan"]["LaLuuManh"];
                jsonObject["bcLaNghienHut"] = jTokenI["ThongTinBiCan"]["LaNghienHut"];
                jsonObject["bcLaTapTrungCaiTaoTuHinhSu"] = jTokenI["ThongTinBiCan"]["LaTapTrungCaiTaoTuHinhSu"];
                jsonObject["bcLaThuongBinhBoDoiPhucVien"] = jTokenI["ThongTinBiCan"]["LaThuongBinhBoDoiPhucVien"];
                jsonObject["DieuLuatKhoiTo"] = jTokenI["DieuLuatKhoiTo"];

                biCan.DienThongTin(jsonObject);
            }

            
            //jsonObject["bcSoQuyetDinh"] = jTokenI["QDKhoiToBiCan"]["SoQuyetDinh"];
            //jsonObject["bcNgayRaQuyetDinh"] = jTokenI["QDKhoiToBiCan"]["NgayRaQuyetDinh"];
            //jsonObject[""] = jTokenI["QDKhoiToBiCan"]["TenCoQuan"];
            //jsonObject[""] = jTokenI["QDKhoiToBiCan"]["TenDonVi"];

            //// Bị can - thông tin bị can
            //jsonObject["bcHoTen"] = jTokenI["ThongTinBiCan"]["HoTen"];
            //jsonObject["bcTenDanTocCT"] = jTokenI["ThongTinBiCan"]["TenDanToc"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["TenQuocTich"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["SoCMT"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["NoiOHienTai"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["TenNgheNghiep"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["TenDangVien"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaBiCanDauVu"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["TenKhac"];
            //jsonObject["bcNgaySinh"] = jTokenI["ThongTinBiCan"]["NgaySinh"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["GioiTinh"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["TenHocVan"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["TenChucVuChinhQuyen"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["SoTienAn"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["SoTienSu"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaCanBoCongNhanVienChuc"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaCoNguoiBaoChua"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaDoiTuongLangThang"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaHanhNgheTonGiao"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaHocSinhTruongChuyenNghiep"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaLuuManh"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaNghienHut"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaTapTrungCaiTaoTuHinhSu"];
            //jsonObject[""] = jTokenI["ThongTinBiCan"]["LaThuongBinhBoDoiPhucVien"];

            //BiCan biCan = new BiCan();
            //biCan.driver = chromeDriver;
            //biCan.DienThongTin(jsonObject);
        }

        public void TaoDieuLuatKhoiTo()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();
            jsonObject = json["DieuLuatKhoiToVuAn"][0];
            DieuLuatKhoiTo dieuLuatKhoiTo = new DieuLuatKhoiTo();
            dieuLuatKhoiTo.driver = chromeDriver;
            dieuLuatKhoiTo.FillForm(jsonObject);
        }

        public void TaoQuyetDinhBiCan()
        {
            // Bị can - Quyết định bị can  - thụ lý khởi tố
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();

            QuyetDinhBiCan quyetDinhBiCan = new QuyetDinhBiCan();
            quyetDinhBiCan.driver = chromeDriver;
            //quyetDinhBiCan.FillForm(jsonObject);

            JToken[] ts = json["ThuLyKhoiTo"]["QuyetDinhBiCan"].ToArray();
            //ts = objs["ThuLyTruyTo"]["QuyetDinhBiCan"].ToArray();

            foreach (JToken jTokenI in ts)
            {
                jsonObject["qdBcSoQuyetDinh"] = jTokenI["SoQuyetDinh"] != null ? jTokenI["SoQuyetDinh"] : "0";
                jsonObject["qdBcNgayRaQuyetDinh"] = jTokenI["NgayRaQuyetDinh"];
                jsonObject["qdBcHieuLuc"] = jTokenI["HieuLucTuNgay"];
                jsonObject[""] = jTokenI["HieuLucDenNgay"];
                jsonObject["qdBcTenCoQuan"] = jTokenI["TenCoQuan"];
                jsonObject["qdBcTenDonVi"] = jTokenI["TenDonVi"];
                jsonObject["qdBcTenBiCan"] = jTokenI["HoTen"];
                jsonObject["qdBcTenloai"] = jTokenI["Tenloai"];
                jsonObject[""] = jTokenI["NoiDungLyDo"];
                jsonObject[""] = jTokenI["ThoiHanThucTe"];


                jsonObject["qdBcTenNguoiKy"] = jTokenI
                    ["TenNguoiKy"] != null ? jTokenI["TenNguoiKy"] : "null";
                jsonObject["qdBcTenChucVu"] = jTokenI
                    ["TenChucVu"] != null ? jTokenI["TenChucVu"] : "null";


                jsonObject["qdBcNoiDung"] = jTokenI["NoiDung"];

                quyetDinhBiCan.FillForm(jsonObject);
            }
        }

        public void TaoQuyetDinhVuAn()
        {
            JObject json = JsonDataFromWs.Instance(id).get();
            QuyetDinhVuAn quyetDinhVuAn = new QuyetDinhVuAn();
            quyetDinhVuAn.driver = chromeDriver;
            quyetDinhVuAn.FillForm(json);
        }

        public void TaoKetLuanDieuTra()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();
            string x = json["ThuLyKhoiTo"]["KetLuanDieuTra"].ToString();
            if (json["ThuLyKhoiTo"]["KetLuanDieuTra"].ToString() != "")
            {
                jsonObject["klSoKetLuanDieuTra"] = json["ThuLyKhoiTo"]["KetLuanDieuTra"]["SoKetLuanDieuTra"] != null ? json["ThuLyKhoiTo"]["KetLuanDieuTra"]["SoKetLuanDieuTra"] : 0;
                jsonObject["klNgayRaKetLuan"] = json["ThuLyKhoiTo"]["KetLuanDieuTra"]["NgayRaKetLuan"];
                jsonObject["klNgayHieuLuc"] = json["ThuLyKhoiTo"]["KetLuanDieuTra"]["NgayHieuLuc"];
                jsonObject["klNoiDung"] = json["ThuLyKhoiTo"]["KetLuanDieuTra"]["NoiDung"];
                jsonObject["klNguoiKy"] = !string.IsNullOrWhiteSpace(json["ThuLyKhoiTo"]["KetLuanDieuTra"]["NguoiKy"].ToString()) ? json["ThuLyKhoiTo"]["KetLuanDieuTra"]["NguoiKy"] : "null";
                jsonObject["klChucVu"] =  !string.IsNullOrWhiteSpace(json["ThuLyKhoiTo"]["KetLuanDieuTra"]["ChucVu"].ToString()) ? json["ThuLyKhoiTo"]["KetLuanDieuTra"]["ChucVu"] : "null";
                //jsonObject["klNguoiKy"] = "Nguyen";
                jsonObject["klYKienCuaVKS"] = json["ThuLyKhoiTo"]["KetLuanDieuTra"]["YKienCuaVKS"] != null ? json["ThuLyKhoiTo"]["KetLuanDieuTra"]["YKienCuaVKS"] : "y kien";
                KetLuanDieuTra ketLuanDieuTra = new KetLuanDieuTra();
                ketLuanDieuTra.driver = chromeDriver;
                ketLuanDieuTra.FillForm(jsonObject);
            }
        }

        public void TaoGiaoNhanHoSo()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();
            if (json["GiaoNhanHoSoKSDT"].ToString() != "")
            {
                jsonObject["hsNgayGiaoNhan"] = json["GiaoNhanHoSoKSDT"]["NgayGiaoNhan"] != null ? json["GiaoNhanHoSoKSDT"]["NgayGiaoNhan"] : "01/01/2019";
                jsonObject["hsNguoiGiao"] = json["GiaoNhanHoSoKSDT"]["NguoiGiao"];
                jsonObject["hsNguoiNhan"] = json["GiaoNhanHoSoKSDT"]["NguoiNhan"];
                jsonObject["hsDonViNhan"] = json["GiaoNhanHoSoKSDT"]["DonViNhan"];
                GiaoNhanHoSo giaoNhanHoSo = new GiaoNhanHoSo();
                giaoNhanHoSo.driver = chromeDriver;
                giaoNhanHoSo.FillForm(jsonObject);
            }
           
        }

        public void TaoKiemSatVienTruyTo()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();

            //jsonObject["ksvHoTen"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["HoTen"];
            //jsonObject["ksvHoTen"] = "Phan";
            //jsonObject["ksvSoQuyetDinh"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["SoQuyetDinh"];
            //jsonObject["ksvNgayPhanCong"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["NgayPhanCong"];
            //jsonObject["ksvNgayKetThuc"] = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"][0]["NgayKetThuc"];

            //PhanCongKiemSatVien phanCongKiemSatVien = new PhanCongKiemSatVien();
            //phanCongKiemSatVien.driver = chromeDriver;
            //phanCongKiemSatVien.FillForm(jsonObject);

            PhanCongKiemSatVien phanCongKiemSatVien = new PhanCongKiemSatVien();
            phanCongKiemSatVien.driver = chromeDriver;
            if (json["ThuLyTruyTo"].ToString() != "")
            {
                JToken[] tksvtt = json["ThuLyTruyTo"]["KiemSatVienDieuTraVien"].ToArray();

                foreach (JToken jTokenI in tksvtt)
                {
                    jsonObject["ksvHoTen"] = jTokenI["HoTen"] != null ? jTokenI["HoTen"] : "Phan";
                    //Khong co "Pham Thi Ngat"
                    //jsonObject["ksvHoTen"] = "Phạm";
                    jsonObject["ksvSoQuyetDinh"] = jTokenI["SoQuyetDinh"];
                    jsonObject["ksvNgayPhanCong"] = jTokenI["NgayPhanCong"];
                    jsonObject["ksvNgayKetThuc"] = jTokenI["NgayKetThuc"];

                    phanCongKiemSatVien.FillForm(jsonObject);
                }
            }
        }
        public void TaoQuyetDinhBiCanTruyTo()
        {
            QuyetDinhBiCan quyetDinhBiCan = new QuyetDinhBiCan();
            quyetDinhBiCan.driver = chromeDriver;


            JObject objs = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();

            if (objs["ThuLyTruyTo"].ToString() != "")
            {
                JToken[] ts = objs["ThuLyTruyTo"]["QuyetDinhBiCan"].ToArray();

                foreach (JToken jTokenI in ts)
                {
                    jsonObject["qdBcSoQuyetDinh"] = jTokenI["SoQuyetDinh"] != null ? jTokenI["SoQuyetDinh"] : "0";
                    jsonObject["qdBcNgayRaQuyetDinh"] = jTokenI["NgayRaQuyetDinh"];
                    jsonObject["qdBcHieuLuc"] = jTokenI["HieuLucTuNgay"];
                    jsonObject[""] = jTokenI["HieuLucDenNgay"];
                    jsonObject["qdBcTenCoQuan"] = jTokenI["TenCoQuan"];
                    jsonObject["qdBcTenDonVi"] = jTokenI["TenDonVi"];
                    jsonObject["qdBcTenBiCan"] = jTokenI["HoTen"];
                    jsonObject["qdBcTenloai"] = jTokenI["Tenloai"];
                    jsonObject[""] = jTokenI["NoiDungLyDo"];
                    jsonObject[""] = jTokenI["ThoiHanThucTe"];


                    jsonObject["qdBcTenNguoiKy"] = jTokenI
                        ["TenNguoiKy"] != null ? jTokenI["TenNguoiKy"] : "null";
                    jsonObject["qdBcTenChucVu"] = jTokenI
                        ["TenChucVu"] != null ? jTokenI["TenChucVu"] : "null";


                    jsonObject["qdBcNoiDung"] = jTokenI["NoiDung"];

                    quyetDinhBiCan.FillForm(jsonObject);
                }
            }
        }
        public void TaoQuyetDinhVuAnTruyTo()
        {
            JObject json = JsonDataFromWs.Instance(id).get();
            QuyetDinhVuAn quyetDinhVuAn = new QuyetDinhVuAn();
            quyetDinhVuAn.driver = chromeDriver;
            quyetDinhVuAn.FillFormTruyTo(json);
        }
        public void TaoCaoTrang()
        {
            JObject json = JsonDataFromWs.Instance(id).get();
            dynamic jsonObject = new JObject();
            if (json["CaoTrang"].ToString() != "")
            {
                jsonObject["banCaoTrangSo"] = json["CaoTrang"]["SoBanCaoTrang"];
                jsonObject["ngayVksRaCaoTrang"] = json["CaoTrang"]["NgayVKSRaCaoTrang"];
                jsonObject["ngayHieuLuc"] = json["CaoTrang"]["NgayHieuLuc"];
                jsonObject["noiDung"] = json["CaoTrang"]["Noidung"] == null ? json["CaoTrang"]["Noidung"] : "null";
                jsonObject["nguoiKy"] = json["CaoTrang"]["TenNguoiKy"] == null ? json["CaoTrang"]["TenNguoiKy"] : "null";
                jsonObject["chucVu"] = json["CaoTrang"]["ChucVu"] == null ? json["CaoTrang"]["ChucVu"] : "null";
                jsonObject["yKien"] = json["CaoTrang"]["YKienVKS"] == null ? json["CaoTrang"]["YKienVKS"] : "null";
                CaoTrang caoTrang = new CaoTrang();
                caoTrang.driver = chromeDriver;
                caoTrang.FillForm(jsonObject);
            }

        }
        public void TaoGiaoNhanHoSoTruyTo()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();
            if (json["GiaoNhanHoSoTT"].ToString() != "")
            {

                jsonObject["hsNgayGiaoNhan"] = json["GiaoNhanHoSoTT"]["NgayGiaoNhan"] != null ? json["GiaoNhanHoSoKSDT"]["NgayGiaoNhan"] : "01/01/2019";
                jsonObject["hsNguoiGiao"] = json["GiaoNhanHoSoTT"]["NguoiGiao"];
                jsonObject["hsNguoiNhan"] = json["GiaoNhanHoSoTT"]["NguoiNhan"];
                jsonObject["hsDonViNhan"] = json["GiaoNhanHoSoTT"]["DonViNhan"];

                GiaoNhanHoSoTruyTo giaoNhanHoSo = new GiaoNhanHoSoTruyTo();
                giaoNhanHoSo.driver = chromeDriver;
                giaoNhanHoSo.FillForm(jsonObject);
            }
        }
    }
}

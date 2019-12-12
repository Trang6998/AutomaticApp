using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObject
{
    class BiCan : Page
    {
        Button addDBc;
        TextBox bcSoQuyetDinh;
        TextBox bcNgayRaQuyetDinh;
        Button bcTenCoQuan;
        Button bcTenCoQuanLI;
        TextBox bcTenDonVi;

        Button bcChonBiCanDauVu;
        Button bcLaBiCanDauVu;
        TextBox bcHoTen;
        TextBox bcTenKhac;
        TextBox bcNgaySinh;
        Button bcTenDanToc;
        Button bcTenDanTocLI;
        TextBox bcTenQuocTich;

        Button bcGioiTinh;
        Button bcChonGioiTinh;
        Button bcTenTonGiao;
        Button bcChonTenTonGiao;
        Button bcTenHocVan;
        Button bcChonTenHocVan;
        Button bcTenNgheNghiep;
        Button bcChonTenNgheNghiep;
        Button bcTenChucVu;
        Button bcChonTenChucVu;
        Button bcTenDangVien;
        Button bcChonTenDangVien;
        TextBox bcSoTienAn;
        TextBox bcSoTienSu;
        TextBox bcNoiOHienTai;

        Choice bcLaCanBoCongNhanVienChuc;
        Choice bcLaNgheNghiepKhongOnDinh;
        Choice bcLaCoNguoiBaoChua;
        Choice bcLaDoiTuongLangThang;
        Choice bcLaHanhNgheTonGiao;
        Choice bcLaHocSinhTruongChuyenNghiep;
        Choice bcLaLuuManh;
        Choice bcLaNghienHut;
        Choice bcLaTapTrungCaiTaoTuHinhSu;
        Choice bcLaThuongBinhBoDoiPhucVien;

        Button bcGhiLai;
        Button back;
        TextBox bcCMND;
        Button themDieuLuatKhoiTo;
        public BiCan():base()
        {
            addDBc = new Button("thêm bị can", xpath.D["addBc"],"");
            bcSoQuyetDinh = new TextBox("quyết định số", xpath.D["bcSoQuyetDinh"],"");
            bcNgayRaQuyetDinh = new TextBox("ngày ra qđ", xpath.D["bcNgayRaQuyetDinh"],"");
            bcTenCoQuan = new Button("cơ quan ra qđ", xpath.D["bcTenCoQuan"], "");
            bcTenDonVi = new TextBox("đơn vị qđ", xpath.D["bcTenDonVi"], "");

            bcChonBiCanDauVu = new Button("bị can đầu vụ", xpath.D["bcChonBiCanDauVu"], "");
            bcHoTen = new TextBox("họ tên", xpath.D["bcHoTen"],"");
            bcTenKhac = new TextBox("tên khác", xpath.D["bcTenKhac"], "");
            bcNgaySinh = new TextBox("ngày sinh", xpath.D["bcNgaySinh"],"");
            bcTenDanToc = new Button("dân tộc", xpath.D["bcTenDanToc"],"");
            bcTenQuocTich = new TextBox("quốc tịch", xpath.D["bcTenQuocTich"], "");
            bcCMND = new TextBox("số CMND", xpath.D["bcCMND"], "");

            bcGioiTinh = new Button("giới tính", xpath.D["bcGioiTinh"],"");
            bcTenTonGiao = new Button("tôn giáo", xpath.D["bcTenTonGiao"],"");
            bcTenHocVan = new Button("học vấn", xpath.D["bcTenHocVan"],"");
            bcTenNgheNghiep = new Button("nghề nghiệp", xpath.D["bcTenNgheNghiep"], "");
            bcTenChucVu = new Button("chức vụ", xpath.D["bcTenChucVu"], "");
            bcTenDangVien = new Button("đảng viên", xpath.D["bcTenDangVien"], "");
            bcSoTienAn = new TextBox("số tiền án", xpath.D["bcSoTienAn"], "");
            bcSoTienSu = new TextBox("số tiền sự", xpath.D["bcSoTienSu"], "");
            bcNoiOHienTai = new TextBox("nơi ở hiện tại", xpath.D["bcNoiOHienTai"],"");

            bcLaNgheNghiepKhongOnDinh = new Choice("là nghề nghiệp không ổn định", xpath.D["bcLaNgheNghiepKhongOnDinh"], "");
            bcLaLuuManh = new Choice("là lưu manh", xpath.D["bcLaLuuManh"], "");
            bcLaCanBoCongNhanVienChuc = new Choice("là cán bộ công nhân viên chức", xpath.D["bcLaCanBoCongNhanVienChuc"], "");
            bcLaNghienHut = new Choice("là nghiện hút", xpath.D["bcLaNghienHut"], "");
            bcLaTapTrungCaiTaoTuHinhSu = new Choice("là tập trung cải tạo hình sự", xpath.D["bcLaTapTrungCaiTaoTuHinhSu"], "");
            bcLaHocSinhTruongChuyenNghiep = new Choice("là học sinh trường chuyên nghiệp", xpath.D["bcLaHocSinhTruongChuyenNghiep"], "");
            bcLaHanhNgheTonGiao = new Choice("là hành nghề tôn giáo", xpath.D["bcLaHanhNgheTonGiao"], "");
            bcLaThuongBinhBoDoiPhucVien = new Choice("là thương binh bộ đội", xpath.D["bcLaThuongBinhBoDoiPhucVien"], "");
            bcLaDoiTuongLangThang = new Choice("là đối tượng lang thang", xpath.D["bcLaDoiTuongLangThang"], "");
            bcLaCoNguoiBaoChua = new Choice("là có người bào chữa", xpath.D["bcLaCoNguoiBaoChua"], "");

            bcGhiLai = new Button("ghi lại", xpath.D["bcGhiLai"],"");
            back = new Button("quay lại", xpath.D["bcBack"], "");
            //themDieuLuatKhoiTo = new Button("thêm điều luật khởi tố", xpath.D["them dieu luat khoi to"],"");

        }

        public void DienThongTin(JObject jObject)
        {
            bcTenCoQuanLI = new Button("chọn cơ quan", xpath.g(jObject["bcTenCoQuan"].ToString(), "bcTenCoQuanLI"), "");
            bcTenDanTocLI = new Button("chọn dân tộc", xpath.g(jObject["bcTenDanToc"].ToString(), "bcTenDanTocLI"), "");
            bcChonTenNgheNghiep = new Button("chọn nghề nghiệp", xpath.g(jObject["bcTenNgheNghiep"].ToString(), "bcTenNgheNghiepLI"), "");
            bcLaBiCanDauVu = Convert.ToBoolean(jObject["bcLaBiCanDauVu"]) != true ? new Button("bị can thường", xpath.D["bcLaBiCanThuong"], ""): new Button("bị can đầu vụ", xpath.D["bcLaBiCanDauVu"], "") ;
            if (jObject["bcGioiTinh"] == null)
            {
                bcChonGioiTinh = new Button("giới tính không xác định", xpath.D["bcGioiTinhKhongXD"], "");
            }
            else
            {
                bcChonGioiTinh = Convert.ToBoolean(jObject["bcGioiTinh"]) == true ? new Button("giới tính nam", xpath.D["bcGioiTinhNam"], "")
                                                                                  : new Button("giới tính nữ", xpath.D["bcGioiTinhNu"], "");
            }
            bcChonTenTonGiao = new Button("chọn tôn giáo", xpath.g(jObject["bcTenTonGiao"].ToString(), "bcTenTonGiaoLI"), "");
            bcChonTenHocVan = new Button("chọn học vấn", xpath.g(jObject["bcTenHocVan"].ToString(), "bcTenHocVanLI"), "");
            bcChonTenChucVu = new Button("chọn chức vụ", xpath.g(jObject["bcTenChucVu"].ToString(), "bcTenChucVuLI"), "");
            bcChonTenDangVien = new Button("chọn loại đảng viên", xpath.g(jObject["bcTenDangVien"].ToString(), "bcTenDangVienLI"), "");

            jsClick(addDBc);
            Sleep();
            SendKeys(jObject["bcSoQuyetDinh"].ToString(), bcSoQuyetDinh);
            Click(bcNgayRaQuyetDinh);
            SendKeys(jObject["bcNgayRaQuyetDinh"].ToString(), bcNgayRaQuyetDinh);
            //Click(bcTenCoQuan);
            //Click(bcTenCoQuanLI);
            Click(bcTenDonVi);
            Clear(bcTenDonVi);
            SendKeys(jObject["bcTenDonVi"].ToString(), bcTenDonVi);
            SendKeys(Keys.Enter, bcTenDonVi);

            Click(bcChonBiCanDauVu);
            Click(bcLaBiCanDauVu);

            Click(bcHoTen);
            SendKeys(jObject["bcHoTen"].ToString(), bcHoTen);
            Click(bcTenKhac);
            SendKeys(jObject["bcTenKhac"].ToString(), bcTenKhac);
            Click(bcNgaySinh);
            SendKeys(jObject["bcNgaySinh"].ToString(), bcNgaySinh);
                      
           
            if(!string.IsNullOrWhiteSpace(jObject["bcTenQuocTich"].ToString()))
            {
                Click(bcTenQuocTich);
                Clear(bcTenQuocTich);
                SendKeys(jObject["bcTenQuocTich"].ToString(), bcTenQuocTich);
                SendKeys(Keys.Enter, bcTenQuocTich);
            }

            Click(bcTenDanToc);
            Click(bcTenDanTocLI);

            Click(bcGioiTinh);
            Click(bcChonGioiTinh);

            Click(bcTenTonGiao);
            Click(bcChonTenTonGiao);

            Click(bcCMND);
            SendKeys(jObject["bcCMND"].ToString(), bcCMND);

            Click(bcTenHocVan);
            Click(bcChonTenHocVan);

            Click(bcNoiOHienTai);
            SendKeys(jObject["bcNoiOHienTai"].ToString(), bcNoiOHienTai);

            Click(bcTenNgheNghiep);
            Click(bcChonTenNgheNghiep);

            Click(bcTenChucVu);
            Click(bcChonTenChucVu);

            Click(bcTenDangVien);
            Click(bcChonTenDangVien);

            Click(bcSoTienAn);
            Clear(bcSoTienAn);
            SendKeys(jObject["bcSoTienAn"].ToString(), bcSoTienAn);

            Click(bcSoTienSu);
            Clear(bcSoTienSu);
            SendKeys(jObject["bcSoTienSu"].ToString(), bcSoTienSu);

            if (Convert.ToBoolean(jObject["bcLaCanBoCongNhanVienChuc"]))
                Click(bcLaCanBoCongNhanVienChuc);
            if (Convert.ToBoolean(jObject["bcLaNgheNghiepKhongOnDinh"]))
                Click(bcLaNgheNghiepKhongOnDinh);
            if (Convert.ToBoolean(jObject["bcLaCoNguoiBaoChua"]))
                Click(bcLaCoNguoiBaoChua);
            if (Convert.ToBoolean(jObject["bcLaDoiTuongLangThang"]))
                Click(bcLaDoiTuongLangThang);
            if (Convert.ToBoolean(jObject["bcLaHanhNgheTonGiao"]))
                Click(bcLaHanhNgheTonGiao);
            if (Convert.ToBoolean(jObject["bcLaHocSinhTruongChuyenNghiep"]))
                Click(bcLaHocSinhTruongChuyenNghiep);
            if (Convert.ToBoolean(jObject["bcLaLuuManh"]))
                Click(bcLaLuuManh);
            if (Convert.ToBoolean(jObject["bcLaNghienHut"]))
                Click(bcLaNghienHut);
            if (Convert.ToBoolean(jObject["bcLaTapTrungCaiTaoTuHinhSu"]))
                Click(bcLaTapTrungCaiTaoTuHinhSu);
            if (Convert.ToBoolean(jObject["bcLaThuongBinhBoDoiPhucVien"]))
                Click(bcLaThuongBinhBoDoiPhucVien);

            Sleep();

            JToken[] ts = jObject["DieuLuatKhoiTo"].ToArray();
            foreach (JToken jToken in ts)
            {
                DieuLuatKhoiTo dieuLuatKhoiTo = new DieuLuatKhoiTo();
                dieuLuatKhoiTo.driver = this.driver;
                dieuLuatKhoiTo.FillForm(jToken);
            }
            Sleep();
            jsClick(bcGhiLai);

            Sleep();
            jsClick(back);
            Sleep();
            // them dieu luat khoi to
        }
    }
}

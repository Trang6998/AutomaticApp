using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObjects
{
    class KiemSatDieuTraTruyTo : G3
    {
        //TextBox BaoCaoTrangSo;
        //DateTimePicker KLDTraTuNgay, KLDTraDenNgay, BCTraTuNgay, BCTraDenNgay;
        Button themMoiButton;

        TextBox maVuAnG3, tenVuAnG3, ngayQDKhoiToTuNgayText;
        TextBox soQuyetDinhKhoiTo;
        DateTimePicker ngayBatDauQDKhoiTo, ngayKetThucQDKhoiTo;
        ComboBox coQuanraQD, loaiToiPham, loaiToiPhamChuaXacDinh;
        DateTimePicker ngayBatDau, ngayKetThuc, ngaySinhTu, ngaySinhDen, ngayBatDauThuLy, ngayKetThucThuLy, ngayBatDauraBanAn, ngayKetThucraBanAn;
        TextBox chiTietNoidkhktt, banAnSo, chiTietNoiOHienTai, thuLySo, tenKiemSatVien;
        ComboBox TinhTrang;
        TextBox donVi, chiTietVuAn, coQuanRaQDtxtSearch;
        Button capNhatThongtin, timKiem, capNhapThongTin;
        Other od1, od2, congAn, od3;
        Other lineData;
        TextBox maVuAnTestThuLy;

        public KiemSatDieuTraTruyTo() : base()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/search.jsf";
            //BaoCaoTrangSo = new TextBox();

            //KLDTraTuNgay = new DateTimePicker();
            //KLDTraDenNgay = new DateTimePicker();
            //BCTraTuNgay = new DateTimePicker();
            //BCTraDenNgay = new DateTimePicker();

            themMoiButton = new Button("thêm mới", xpath.D["addVuAn"], "");
            soQuyetDinhKhoiTo = new TextBox("quyết định khởi tố vụ án số", xpath.D["quyetDinhKhoiTo"], "");
            ngayBatDauQDKhoiTo = new DateTimePicker("ngày quyết định khởi tố từ ngày", xpath.D["ngayQDKhoiToTuNgay"], "");
            ngayQDKhoiToTuNgayText = new TextBox("ngày quyết định khởi tố từ ngày text", xpath.D["ngayQDKhoiToTuNgayText"], "");
            //soQuyetDinhKhoiTo = new TextBox("toiDanh", xpath.D["toiDanh"], "");
            //soQuyetDinhKhoiTo = new TextBox("tenBiCan", xpath.D["tenBiCan"], "");
            //soQuyetDinhKhoiTo = new TextBox("tenVuAn", xpath.D["tenVuAn"], "");
            //soQuyetDinhKhoiTo = new TextBox("timKiem", xpath.D["timKiem"], "");
            //da implement o lop cha
            maVuAnG3 = new TextBox("mã vụ án của G3 và G4", xpath.D["maVuAnG3"], "");
            tenVuAnG3 = new TextBox("tên vụ án của G3 và G4", xpath.D["tenVuAnG3"], "");
            coQuanraQD = new ComboBox("cơ quan ra quyết định", xpath.D["coQuanRaQuyetDinh"], "");
            coQuanRaQDtxtSearch = new TextBox("cơ quan ra quyết định", xpath.D["coQuanRaQDtxtSearch"], "");
            congAn = new Other("cong an", xpath.D["congAn"], "");
            ngayKetThucQDKhoiTo = new DateTimePicker("ngày quyết định khởi tố đến ngày", xpath.D["ngayQDKhoiToDenNgay"], "");
            loaiToiPham = new ComboBox("loại tội phạm", xpath.D["loaiToiPham"], "");
            loaiToiPhamChuaXacDinh = new ComboBox("loại tội phạm chưa xác định", xpath.D["loaiToiPhamChuaXacDinh"], "");
            ngayBatDau = new DateTimePicker("ngày xảy ra từ ngày", xpath.D["ngayXayRaTuNgay"], "");
            ngaySinhTu = new DateTimePicker("ngaySinhTu", xpath.D["ngaySinhTu"], "");
            chiTietNoidkhktt = new TextBox("chi tiết nơi đăng kí hộ khẩu thường trú", xpath.D["chiTietNoiDKHKTT"], "");
            TinhTrang = new ComboBox("tình trạng", xpath.D["tinhTrang"], "");
            ngayBatDauThuLy = new DateTimePicker("thụ lý từ ngày", xpath.D["thuLyTuNgay"], "");
            banAnSo = new TextBox("bản án số", xpath.D["banAnSo"], "");
            ngayBatDauraBanAn = new DateTimePicker("ngày ra bản án từ ngày", xpath.D["ngayRaBanAnTuNgay"], "");
            ngayKetThuc = new DateTimePicker("ngày xảy ra đến ngày", xpath.D["ngayXayRaDenNgay"], "");
            ngaySinhDen = new DateTimePicker("ngaySinhDen", xpath.D["ngaySinhDen"], "");
            chiTietNoiOHienTai = new TextBox("chi tiết nơi ở hiện tại", xpath.D["chiTietNoiOHienTai"], "");
            thuLySo = new TextBox("thụ lý số", xpath.D["thuLySo"], "");
            ngayKetThucThuLy = new DateTimePicker("thụ lý đến ngày", xpath.D["thuLyDenNgay"], "");
            tenKiemSatVien = new TextBox("tên kiểm sát viên", xpath.D["tenKiemSatVien"], "");
            ngayKetThucraBanAn = new DateTimePicker("ngày ra bản án đến ngày", xpath.D["ngayRaBanAnDenNgay"], "");
            donVi = new TextBox("đơn vị", xpath.D["donVi"], "");
            capNhatThongtin = new Button("cập nhật thông tin", xpath.D["capNhatThongTin"], "");
            chiTietVuAn = new TextBox("chi tiết vụ án", xpath.D["chiTietVuAn"], "");
            //searchResult = new TextBox("searchResult", xpath.D["searchResult"], "");

            ngayBatDauQDKhoiTo = new DateTimePicker("Ngày QĐ khởi tố từ ngày",
                xpath.D["ngayQDKhoiToTuNgay"], "");
            //ttttttttttt
            od1 = new Other("Ngày QĐ khởi tố từ ngày",
                xpath.D["ngay10"], "");

            ngayKetThucQDKhoiTo = new DateTimePicker("Ngày QĐ khởi tố đến ngày",
                 xpath.D["ngayQDKhoiToDenNgay"], "");
            od2 = new Other("Ngày QĐ khởi tố từ ngày",
                xpath.D["ngay20"], "");
            od3 = new Other("tội vu khống", xpath.D["toidanhG3"], "");
            tenBiCan = new TextBox("tên bị can", xpath.D["tenBiCanG3"], "");

            ngayBatDau = new DateTimePicker();

            maVuAn = new TextBox("mã vụ án", xpath.D["maVuAn"], "");
            timKiem = new Button("tìm kiếm", xpath.D["timKiem"], "");

            lineData = new Other("dòng Data sau khi tìm kiếm", xpath.D["lineData"], "");
            maVuAnTestThuLy = new TextBox("mã vụ án", xpath.D["maVuAnTestThuLy"], "");
            capNhapThongTin = new Button("capNhapThongTin", xpath.D["capNhapThongTin"], "");
        }

        public void DienThongTin(JObject jsonObject)
        {
            //SendKeys(obj["maVuAn"].ToString(), maVuAnG3);
            SendKeys(jsonObject["tenVuAn"].ToString(), tenVuAnG3);
            SendKeys(jsonObject["soQuyetDinhKhoiTo"].ToString(), soQuyetDinhKhoiTo);

            Click(coQuanraQD);
            SendKeys(jsonObject["coQuanRaQDtxtSearch"].ToString(), coQuanRaQDtxtSearch);
            SendKeys(Keys.Enter, coQuanRaQDtxtSearch);
            Click(congAn);
            SendKeys(jsonObject["donVi"].ToString(), donVi);
            SendKeys(Keys.Enter, donVi);
            Click(ngayQDKhoiToTuNgayText);
            SendKeys("10102019", ngayQDKhoiToTuNgayText);
            //Click(ngayBatDauQDKhoiTo);
            //Click(od1);
            //Click(ngayKetThucQDKhoiTo);
            //Click(od2);
            //SendKeys(jsonObject["toidanh"].ToString(), toiDanh);
            ////Click(od3);
            //SendKeys(Keys.Enter, toiDanh);

            //SendKeys(obj["loaiToiPham"].ToString(), loaiToiPham);
            //Click(loaiToiPham);
            //Click(loaiToiPhamChuaXacDinh);
            //Click(loaiToiPham);

            //SendKeys(obj["tenbican"].ToString(), tenBiCan);
        }
        public void AddVuAn()
        {
            Click(themMoiButton);
        }

        public void TimKiem()
        {
            Click(timKiem);
            Sleep(); 
            Sleep();
        }

        public void TimVuAn()
        {
            SendKeys("000637304", maVuAnTestThuLy);
            Click(timKiem);
            Click(lineData);
            Click(capNhapThongTin);
        }
    }
}

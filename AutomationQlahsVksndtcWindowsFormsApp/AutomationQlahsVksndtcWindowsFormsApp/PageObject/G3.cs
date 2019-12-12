using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObjects
{
    class G3 : Page
    {

        TextBox maVuAnG3, tenVuAnG3;
        TextBox soQuyetDinhKhoiTo;
        DateTimePicker ngayBatDauQDKhoiTo, ngayKetThucQDKhoiTo;
        ComboBox coQuanraQD, loaiToiPham, loaiToiPhamChuaXacDinh;
        DateTimePicker ngayBatDau, ngayKetThuc, ngaySinhTu, ngaySinhDen, ngayBatDauThuLy, ngayKetThucThuLy, ngayBatDauraBanAn, ngayKetThucraBanAn;
        TextBox chiTietNoidkhktt, banAnSo, chiTietNoiOHienTai, thuLySo, tenKiemSatVien;
        ComboBox TinhTrang;
        TextBox donVi, chiTietVuAn, coQuanRaQDtxtSearch;
        Button capNhatThongtin, timKiem;
        Other od1, od2, congAn, od3;
        

        public G3() : base()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/search_G3.jsf";
            soQuyetDinhKhoiTo = new TextBox("quyết định khởi tố vụ án số", xpath.D["quyetDinhKhoiTo"], "");
            ngayBatDauQDKhoiTo = new DateTimePicker("ngày quyết định khởi tố từ ngày", xpath.D["ngayQDKhoiToTuNgay"], "");
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
        }

        public void DienThongTin(JObject obj)
        {
            SendKeys(obj["maVuAn"].ToString(), maVuAnG3);
            SendKeys(obj["tenVuAn"].ToString(), tenVuAnG3);
            SendKeys(obj["soQuyetDinhKhoiTo"].ToString(), soQuyetDinhKhoiTo);

            Click(coQuanraQD);
            SendKeys(obj["coQuanRaQDtxtSearch"].ToString(), coQuanRaQDtxtSearch);
            SendKeys(Keys.Enter, coQuanRaQDtxtSearch);
            Click(congAn);
            SendKeys(obj["donVi"].ToString(), donVi);
            SendKeys(Keys.Enter, donVi);
            Click(ngayBatDauQDKhoiTo);
            Click(od1);
            Click(ngayKetThucQDKhoiTo);
            Click(od2);
            SendKeys(obj["toidanh"].ToString(), toiDanh);
            Click(od3);

            //SendKeys(obj["loaiToiPham"].ToString(), loaiToiPham);
            Click(loaiToiPham);
            Click(loaiToiPhamChuaXacDinh);
            //Click(loaiToiPham);

            SendKeys(obj["tenbican"].ToString(), tenBiCan);

            //SendKeys(obj["ngayBatDau"].ToString(), ngayBatDau);
            //Click(ngayBatDau);
            ////Click(ngayBatDau);
            //SendKeys(obj["ngaySinhTu"].ToString(), ngaySinhTu);
            //Click(ngaySinhTu);
            ////Click(ngaySinhTu);
            //SendKeys(obj["chiTietNoidkhktt"].ToString(), chiTietNoidkhktt);
            //SendKeys(obj["TinhTrang"].ToString(), TinhTrang);
            //Click(TinhTrang);
            ////Click(TinhTrang); 
            //SendKeys(obj["ngayBatDauThuLy"].ToString(), ngayBatDauThuLy);
            //Click(ngayBatDauThuLy);
            ////Click(ngayBatDauThuLy);
            //SendKeys(obj["banAnSo"].ToString(), banAnSo);
            //SendKeys(obj["ngayBatDauraBanAn"].ToString(), ngayBatDauraBanAn);
            //Click(ngayBatDauraBanAn);
            ////Click(ngayBatDauraBanAn);
            //SendKeys(obj["ngayKetThuc"].ToString(), ngayKetThuc);
            //Click(ngayKetThuc);
            ////Click(ngayKetThuc);
            //SendKeys(obj["ngaySinhDen"].ToString(), ngaySinhDen);
            //Click(ngaySinhDen);
            ////Click(ngaySinhDen);
            //SendKeys(obj["chiTietNoiOHienTai"].ToString(), chiTietNoiOHienTai);
            //SendKeys(obj["thuLySo"].ToString(), thuLySo);
            //SendKeys(obj["ngayKetThucThuLy"].ToString(), ngayKetThucThuLy);
            //Click(ngayKetThucThuLy);
            ////Click(ngayKetThucThuLy);
            //SendKeys(obj["tenKiemSatVien"].ToString(), tenKiemSatVien);
            //SendKeys(obj["ngayKetThucraBanAn"].ToString(), ngayKetThucraBanAn);
            //Click(ngayKetThucraBanAn);
            ////Click(ngayKetThucraBanAn);
            //SendKeys(obj["donVi"].ToString(), donVi);
            //Click(capNhatThongtin);
            //SendKeys(obj["chiTietVuAn"].ToString(), chiTietVuAn);
            //Click(ngayKetThuc);
            ////Click(ngayKetThuc);
            
        }

        public void TimKiem()
        {
            Click(timKiem);
            Sleep(); Sleep();
        }
    }
}

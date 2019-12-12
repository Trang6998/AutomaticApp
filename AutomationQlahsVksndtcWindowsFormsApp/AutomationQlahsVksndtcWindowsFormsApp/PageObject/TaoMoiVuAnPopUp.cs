using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp
{

    class TaoMoiVuAnPopUp :Page
    {
        #region Controls definition  
        TextBox quyetĐinhKhoiToVuAnSo;
        TextBox dieuLuatVu;
        DateTimePicker ngayQuyetDinhKhoiToVuAn;
        Other ngayQd;
        Other ngayQdMot;
        Other toiVuKhong;
        ComboBox coQuanRaQuyetDinh;
        Other coQuanCongAn;
        TextBox donViRaQuyetDinh;
        TextBox tenVuAn;
        TextBox maVuCuaToaAn;
        CheckBox clickLoaiToiPham;
        Button chonLoaiToiPham;
        Button btnLoaiToiPhamChuaXD;
        Button btnLoaiToiPhamItNghiemTrong;
        Button btnLoaiToiPhamNghiemTrong;
        Button btnLoaiToiPhamRatNghiemTrong;
        Button btnLoaiToiPhamDacBietNghiemTrong;
        DateTimePicker ngayXayRa;
        TextBox txtNgayXayRa;
        TextBox thang;
        TextBox nam;
        TextBox gio;
        TextBox noiXayRa;
        TextBox chiTietNoiXayRa;
        TextBox ghiChu;
        TextBox ngayQDKhoiToTuNgayText, ngayQDKhoiToDenNgayText, txtNgayQDKhoiToVuAn;

        CheckBox ghiAmGhiHinhBiMat;
        CheckBox ngheDienThoaiBiMat;
        CheckBox thuThapBiMatDuLieuDienTu;

        Button ghiLai;
        Button quayLai;

        Other o;
        #endregion
        Xpath x;
        

        public TaoMoiVuAnPopUp()
        {
            x = new Xpath();    
            #region Controls initialize  
            quyetĐinhKhoiToVuAnSo = new TextBox("quyết định khởi tố vụ án số",x.D["inputQuyetDinhKhoiToVuAnSo"],"");
            ngayQuyetDinhKhoiToVuAn = new DateTimePicker("chọn ngày", x.D["buttonNgayQuyetDinhKhoiToVuAn"], "");
            ngayQdMot = new Other("ngày 1", x.D["ngayMot"], "");
            ngayQd = new Other("chọn ngày", x.D["Ngay15QuyetDinhKhoiToVuAn"], "");
            coQuanRaQuyetDinh = new ComboBox("cơ quan ra QĐ", x.D["dropdownCoQuanRaQuyetDinh"], "");
            coQuanCongAn = new Other("cơ quan công an", x.D["coQuanCongAn"], "");
            dieuLuatVu = new TextBox("điều luật vụ", x.D["inputDieuLuatVu"], "");
            toiVuKhong = new Other("tội vu khống", x.D["toiVuKhong"], "");
            donViRaQuyetDinh = new TextBox("đơn vị ra QĐ", x.D["inputDonViRaQuyetDinh"], ""); 
            tenVuAn = new TextBox("tên vụ án", x.D["inputTenVuAn"], ""); 
            maVuCuaToaAn = new TextBox("mã vụ của tòa án", x.D["inputMaVuCuaToaAn"], "");
            clickLoaiToiPham = new CheckBox("loại tội phạm check", x.D["clickLoaiToiPham"], "");
            btnLoaiToiPhamChuaXD = new Button("chưa xác định", x.D["btnLoaiToiPhamChuaXD"], "");
            chonLoaiToiPham = new Button("chọn loại tội phạm", x.D["chonLoaiToiPham"], "");
            btnLoaiToiPhamItNghiemTrong = new Button("ít nghiêm trọng", x.D["btnLoaiToiPhamItNghiemTrong"], "");
            btnLoaiToiPhamNghiemTrong = new Button("nghiêm trọng", x.D["btnLoaiToiPhamNghiemTrong"], "");
            btnLoaiToiPhamRatNghiemTrong = new Button("rất nghiêm trọng", x.D["btnLoaiToiPhamRatNghiemTrong"], "");
            btnLoaiToiPhamDacBietNghiemTrong = new Button("đặc biệt nghiêm trọng", x.D["btnLoaiToiPhamDacBietNghiemTrong"], "");
            txtNgayXayRa = new TextBox("ngày xảy ra", x.D["txtNgayXayRa"], "");
            ngayXayRa = new DateTimePicker("ngày xảy ra", x.D["inputThang"], "");
            thang = new TextBox("tháng", x.D["inputThang"], "");
            nam = new TextBox("năm", x.D["inputNam"], "");
            gio = new TextBox("giờ", x.D["inputGio"], "");
            noiXayRa = new TextBox("nơi xảy ra", x.D["inputNoiXayRa"], "");
            chiTietNoiXayRa = new TextBox("chi tiết nơi xảy ra", x.D["inputChiTietNoiXayRa"], "");
            ghiChu = new TextBox("ghi chú", x.D["inputGhiChu"], "");

            ghiAmGhiHinhBiMat = new CheckBox();
            ngheDienThoaiBiMat = new CheckBox();
            thuThapBiMatDuLieuDienTu = new CheckBox();

            ghiLai = new Button("buttonGhiLai", x.D["buttonGhiLai"], "");
            quayLai = new Button("buttonQuayLai", x.D["buttonQuayLai"], "");
            ngayQDKhoiToTuNgayText = new TextBox("txt ngày quyết định khởi tố", x.D["ngayQDKhoiToTuNgayText"], "");
            ngayQDKhoiToDenNgayText = new TextBox("txt ngày quyết định khởi tố", x.D["ngayQDKhoiToDenNgayText"], "");
            txtNgayQDKhoiToVuAn = new TextBox("text ngày quyết định khởi tố vụ án", x.D["txtNgayQDKhoiToVuAn"], "");
            o = new Other();

         
            #endregion
            //x = new Xpath();
            //this.driver = driver; 
        }

        public void DienThongTin(JObject jVuAn)
        {

            string s = jVuAn["txtNgayXayRa"].ToString();

            SendKeys(jVuAn["quyetĐinhKhoiToVuAnSo"].ToString(), quyetĐinhKhoiToVuAnSo);
            Click(txtNgayQDKhoiToVuAn);
            SendKeys(jVuAn["txtNgayQDKhoiToVuAn"].ToString(), txtNgayQDKhoiToVuAn);

            //Click(ngayQdMot);
            //Click(coQuanRaQuyetDinh);
            //SendKeys("C", coQuanRaQuyetDinh);
            //SendKeys(Keys.Down, coQuanRaQuyetDinh);
            //SendKeys(Keys.Enter, coQuanRaQuyetDinh);
            //Click(coQuanCongAn);
            Click(dieuLuatVu);
            SendKeys(jVuAn["dieuLuatVu"].ToString(), dieuLuatVu);
            SendKeys(Keys.Enter, dieuLuatVu);
            Click(tenVuAn);
            Other _dieuLuatVu = new Other("điều luật vụ", "//input[@type='hidden'][@name='bodyForm:lawcode_hinput']", "");

            var firstName = FindElementByXPath(_dieuLuatVu);
            String value = firstName.GetAttribute("value");
            
            if (value == null || value == "")
            {
                Clear(dieuLuatVu);
                SendKeys(" ", dieuLuatVu);
                SendKeys(Keys.Enter, dieuLuatVu);
            }
            SendKeys(jVuAn["donViRaQuyetDinh"].ToString(), donViRaQuyetDinh);
            SendKeys(Keys.Enter, donViRaQuyetDinh);
            Click(tenVuAn);
            SendKeys(jVuAn["tenVuAn"].ToString(), tenVuAn);

            Click(clickLoaiToiPham);
            Click(chonLoaiToiPham);
            if ((int)jVuAn["loaiToiPham"] == 2)
                Click(btnLoaiToiPhamItNghiemTrong);
            else if ((int)jVuAn["loaiToiPham"] == 3)
                Click(btnLoaiToiPhamNghiemTrong);
            else if ((int)jVuAn["loaiToiPham"] == 4)
                Click(btnLoaiToiPhamRatNghiemTrong);
            else if ((int)jVuAn["loaiToiPham"] == 5)
                Click(btnLoaiToiPhamDacBietNghiemTrong);
            else
                Click(btnLoaiToiPhamChuaXD);

            Click(txtNgayXayRa);            
            SendKeys(jVuAn["txtNgayXayRa"].ToString(), txtNgayXayRa);
            if (string.IsNullOrWhiteSpace(jVuAn["txtNgayXayRa"].ToString()))
            {
                Click(nam);
                SendKeys("2019", nam); //thay bang send key txtNgayXayRa

            }

            Clear(noiXayRa);
            SendKeys(jVuAn["noiXayRa"].ToString(), noiXayRa);
            SendKeys(Keys.Enter, noiXayRa);
            SendKeys(jVuAn["ghiChu"].ToString(), ghiChu);

            Sleep();
            Sleep();

            jsClick(ghiLai);
            Sleep();
            JToken[] ts = jVuAn["DieuLuatKhoiToVuAn"].ToArray();
            foreach(JToken jToken in ts)
            {
                SendKeys((string)jToken["NoiDung"], new TextBox(
                    "toi danh", xpath.D["bsdlToiDanh"], ""
                ));
                SendKeys(Keys.Enter, new TextBox(
                    "toi danh", xpath.D["bsdlToiDanh"], ""
                ));
                Click(new Button("ghi lai dieu luat",xpath.D["bsdlGhiLaiDieuLuat"],""));
                Sleep();
                // 		ghi lai dieu luat
            }
             
            jsClick(quayLai);
            Sleep();
            Sleep();
             
        }
    }
}




//SendKeys("QD khởi tố VA số 1", By.Id("bodyForm:casebeginSetnum"));
//Click(By.XPath("//*[@id='bodyForm:casebeginIndate']/button"));
//Click(By.XPath("//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[3]/a"));
//SendKeys("1", By.Id("bodyForm:lawcode_input"));
//wait(3);
//chromeDriver.FindElement(By.Id("bodyForm:lawcode_input")).SendKeys(Keys.Enter);
//SendKeys("1", By.Id("bodyForm:casesppspcid2_input"));
//Click(By.XPath("//*[@id='bodyForm:casesppspcid2_panel']/ul/li[1]"));
//SendKeys("vụ án số 1", By.Id("bodyForm:casecasename"));
//Click(By.XPath("//*[@id='bodyForm:casecrimdate']/button"));
//Click(By.XPath("//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[3]/a"));
//chromeDriver.FindElement(By.Id("bodyForm:casecrimwhere_input")).Clear();
//SendKeys("01", By.Id("bodyForm:casecrimwhere_input"));
//wait(3);
//chromeDriver.FindElement(By.Id("bodyForm:casecrimwhere_input")).SendKeys(Keys.Enter);
//wait(3);
//SendKeys("Thành Công", By.Id("bodyForm:casecrimwhere1"));
//SendKeys("Q.Ba Đình -TP.Hà Nội", By.Id("bodyForm:caseaddress"));
//SendKeys("Thành Công", By.Id("bodyForm:caseremark"));
//Click(By.Id("bodyForm:case_ghihinh"));
//Click(By.Id("bodyForm:j_idt1087"));
//wait(3);
//chromeDriver.Navigate().GoToUrl("http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/search.jsf");//
//SendKeys("vụ án số 1", By.Id("bodyForm:casename"));
//Click(By.Id("bodyForm:btnSearch"));
//Click(By.XPath("//*[@id='bodyForm:resultTable_data']/tr"));
//Click(By.Id("bodyForm:j_idt266"));
//Click(By.Id("bodyForm:j_idt341"));
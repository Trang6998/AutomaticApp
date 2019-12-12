using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp
{

    class ThuLyPopUp : Page
    {
        #region Controls definition  

        ComboBox loaiThuLy;

        Button ghiLaiTestThuLy;
        Button quayLai;
        Button capNhapThongTin, themMoiThuLy;
        TextBox thuLySo, ngayThuLy, thoiHanThuLyTuNgay, thoiHanThuLyDenNgay;
        TextBox maVuAnTestThuLy;
        CheckBox luatSu, anDiem;
        Other lineData;

        //Other o;
        #endregion


        public ThuLyPopUp()
        {
            #region Controls initialize  
            loaiThuLy = new ComboBox("loại thụ lý", xpath.D["loaiThuLy"], "");
            thuLySo = new TextBox("thụ lý số", xpath.D["thuLySo"], "");
            maVuAnTestThuLy = new TextBox("mã vụ án", xpath.D["maVuAnTestThuLy"], "");
            ngayThuLy = new TextBox("thụ lý số", xpath.D["ngayThuLy"], "");
            thoiHanThuLyTuNgay = new TextBox("thụ lý số", xpath.D["thoiHanThuLyTuNgay"], "");
            thoiHanThuLyDenNgay = new TextBox("thụ lý số", xpath.D["thoiHanThuLyDenNgay"], "");
            lineData = new Other("dòng Data sau khi tìm kiếm", xpath.D["lineData"], "");
            anDiem = new CheckBox("là án điểm", xpath.D["tlAnDiem"], "");
            luatSu = new CheckBox("có luật sư bào chữa", xpath.D["tlLuatSu"], "");
            ghiLaiTestThuLy = new Button("ghiLaiTestThuLy", xpath.D["ghiLaiTestThuLy"], "");
            quayLai = new Button("quay lại", xpath.D["tlBack"],"");
            capNhapThongTin = new Button("capNhapThongTin", xpath.D["capNhapThongTin"], "");
            themMoiThuLy = new Button("themMoiThuLy", xpath.D["themMoiThuLy"], "");
            //ngayQDKhoiToTuNgayText = new TextBox("txt ngày quyết định khởi tố", x.D["ngayQDKhoiToTuNgayText"], "");
            //ngayQDKhoiToDenNgayText = new TextBox("txt ngày quyết định khởi tố", x.D["ngayQDKhoiToDenNgayText"], "");
            //txtNgayQDKhoiToVuAn = new TextBox("text ngày quyết định khởi tố vụ án", x.D["txtNgayQDKhoiToVuAn"], "");
            //o = new Other();


            #endregion
            //x = new Xpath();
            //this.driver = driver; 
        }

        public void DienThongTin(JObject jVuAn)
        {
           
            Click(themMoiThuLy);
            Click(loaiThuLy);
            SendKeys(jVuAn["loaiThuLy"].ToString(), loaiThuLy);
            SendKeys(Keys.Enter, loaiThuLy);
            Click(thuLySo);
            Clear(thuLySo);
            SendKeys(jVuAn["thuLySo"].ToString(), thuLySo);

            Click(ngayThuLy);
            SendKeys(jVuAn["ngayThuLy"].ToString(), ngayThuLy);
            Click(thoiHanThuLyTuNgay);
            SendKeys(jVuAn["thoiHanThuLyTuNgay"].ToString(), thoiHanThuLyTuNgay);

            if(jVuAn["thoiHanThuLyDenNgay"] != null)
            {
                Click(thoiHanThuLyDenNgay);
                SendKeys(jVuAn["thoiHanThuLyDenNgay"].ToString(), thoiHanThuLyDenNgay);
            }

            if (Convert.ToBoolean(jVuAn["anDiem"]))
                Click(anDiem);
            if (Convert.ToBoolean(jVuAn["luatSu"]))
                Click(luatSu);

            jsClick(ghiLaiTestThuLy);
            jsClick(quayLai);
            Sleep();
            Sleep();
        }
    }
}

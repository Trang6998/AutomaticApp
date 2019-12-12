using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObjects
{
    class G6:Page
    {
        TextBox maThuLy, VKSNhapBanAn, nguoiChapHanhAn;
        DateTimePicker BanAnRaTuNgay, BanAnRaDenNgay;
        Other BanAnRaTuNgayMot, BanAnRaDenNgayMot;
        ComboBox TrangThaiThuLy, daThuLy, chuaThuLy;
        Choice ThuLy, UyThac;
        Button timKiemG6, doiGiaoDien;
        Other chonVKS;

        public G6() : base()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/search_G6.jsf";

            //maVuAn, tenVuAn implement Page
            maThuLy = new TextBox("mã thụ lý", xpath.D["maThuLy"], "");
            VKSNhapBanAn = new TextBox("VKS nhập bản án", xpath.D["VKSNhapBanAn"], "");
            BanAnRaTuNgay = new DateTimePicker("Bản án ra từ ngày", xpath.D["banAnRaTuNgay"], "");
            BanAnRaDenNgay = new DateTimePicker("Bản án ra đến ngày", xpath.D["banAnRaDenNgay"], "");
            BanAnRaTuNgayMot = new Other("Bản án ra từ ngày một", xpath.D["banAnRaTuNgayMot"], "");
            BanAnRaDenNgayMot = new Other("Bản án ra đến ngày một", xpath.D["banAnRaDenNgayMot"], "");
            nguoiChapHanhAn = new TextBox("Người chấp hành án", xpath.D["nguoiChapHanhAn"], "");
            ThuLy = new Choice("Thụ lý", xpath.D["thuLy"], "");
            UyThac = new Choice("Thụ lý", xpath.D["uyThac"], "");
            TrangThaiThuLy = new ComboBox("Trạng thái thụ lý", xpath.D["trangThaiThuLy"], "");
            daThuLy = new ComboBox("Đã thụ lý", xpath.D["daThuLy"], "");
            chuaThuLy = new ComboBox("Chưa thụ lý", xpath.D["chuaThuLy"], "");
            timKiemG6 = new Button("Tìm kiếm của G6", xpath.D["timKiemG6"], "");
            chonVKS = new Other("chọn VKS", xpath.D["chonVKS"], "");

        }

        public void DienThongTin(JObject obj)
        {
            Click(UyThac);
            Click(ThuLy);
            SendKeys(obj["maVuAn"].ToString(), maVuAn);
            SendKeys(obj["tenVuAn"].ToString(), tenVuAn);
            SendKeys(obj["maThuLy"].ToString(), maThuLy);
            SendKeys(obj["VKSNhapBanAn"].ToString(), VKSNhapBanAn);
            Click(chonVKS);
            Click(BanAnRaTuNgay);
            Click(BanAnRaTuNgayMot);
            Click(BanAnRaDenNgay);
            Click(BanAnRaDenNgayMot);
            SendKeys(obj["nguoiChapHanhAn"].ToString(), nguoiChapHanhAn);
            Click(TrangThaiThuLy);
            Click(daThuLy);
            Click(TrangThaiThuLy);
            Click(chuaThuLy);
            Sleep();

            Click(timKiemG6);
            Sleep();
            Sleep();
            Sleep();
            Sleep();
            Sleep();
        }

    }

    

}

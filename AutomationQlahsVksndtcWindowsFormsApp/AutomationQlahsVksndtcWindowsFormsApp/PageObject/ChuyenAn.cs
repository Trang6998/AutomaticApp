using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObjects
{
    class ChuyenAn:Page
    {
        DateTimePicker ngayBatdau, ngayKetThuc;
        Choice chuaChuyen, daChuyen;
        TextBox tenKiemSatVien;
        Other ngayMotBD, ngayMotKT;

        public ChuyenAn()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/SppSpp/SppSpp_Send/search.jsf";
            ngayKetThuc = new DateTimePicker("đến ngày", xpath.D["denNgay"], ""); 
            ngayBatdau = new DateTimePicker("từ ngày",xpath.D["tuNgay"],"");
            ngayMotBD = new Other("ngày một bắt đầu", xpath.D["ngayMotBD"], "");
            ngayMotKT = new Other("ngày một kết thúc", xpath.D["ngayMotKT"], "");

            chuaChuyen = new Choice("chưa chuyển", xpath.D["chuaChuyen"], "");
            daChuyen = new Choice("đã chuyển", xpath.D["daChuyen"], "");
            tenKiemSatVien = new TextBox("tên KS viên", xpath.D["tenVKSNhan"], "");
        }

        public void DienThongTin(JObject obj)
        {
            SendKeys(obj["maVuAn"].ToString(), maVuAn);
            SendKeys(obj["tenVuAn"].ToString(), tenVuAn);
            //SendKeys(obj["tenKiemSatVien"].ToString(), tenKiemSatVien);
            Click(ngayBatdau);
            Click(ngayMotBD);
            //Click(ngayBatdau);
            Click(ngayKetThuc);
            Click(ngayMotKT);
            //Click(ngayKetThuc);
            Click(chuaChuyen);
            //Click(daChuyen);

            Sleep();
            Sleep();
        }

        public void TimKiem()
        {
            Click(timKiem);
            Sleep();
            Sleep();
            Sleep();
            Sleep();
        }
    }
}

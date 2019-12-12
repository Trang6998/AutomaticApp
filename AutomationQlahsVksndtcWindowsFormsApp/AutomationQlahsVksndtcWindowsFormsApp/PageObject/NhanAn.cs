using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObjects
{
    class NhanAn : Page
    {
        TextBox VKSgiao, tuNgayNhanAn, denNgayNhanAn;
        DateTimePicker ngayBatDau, ngayKetThuc;
        Choice chuaNhan, daNhan;
        Other ngayMotBD, ngayMotKT;

        public NhanAn()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/SppSpp/SppSpp_Receive/search.jsf";
            VKSgiao = new TextBox("tên KS viên giao", xpath.D["vienKiemSoatGiao"], "");

            ngayBatDau = new DateTimePicker("từ ngày", xpath.D["tuNgay"], "");
            ngayMotBD = new Other("ngày một bắt đầu", xpath.D["ngayMotBD"], "");
            ngayKetThuc = new DateTimePicker("đến ngày", xpath.D["denNgay"], "");
            ngayMotKT = new Other("ngày một bắt đầu", xpath.D["ngayMotKT"], "");
            tuNgayNhanAn = new TextBox("từ ngày nhận án", xpath.D["tuNgayNhanAn"], "");
            denNgayNhanAn = new TextBox("đến ngày nhận án", xpath.D["denNgayNhanAn"], "");
            chuaNhan = new Choice();
            daNhan = new Choice();

        }

        public void DienThongTin(JObject obj)
        {
            SendKeys(obj["maVuAn"].ToString(), maVuAn);
            SendKeys(obj["tenVuAn"].ToString(), tenVuAn);
            Click(tuNgayNhanAn);
            SendKeys("10102019", tuNgayNhanAn);
            //Click(ngayMotBD);
            //Click(ngayBatdau);
            Click(denNgayNhanAn);
            SendKeys("11102019", denNgayNhanAn);
            //Click(ngayMotKT);
            //Click(ngayKetThuc);
            SendKeys(obj["VKSgiao"].ToString(), VKSgiao);
            Click(chuaNhan);
            //Click(daNhan);
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

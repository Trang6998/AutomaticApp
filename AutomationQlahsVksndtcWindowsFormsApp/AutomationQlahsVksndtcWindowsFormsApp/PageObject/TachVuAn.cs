using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObjects
{
    class TachVuAn :Page
    {
        TextBox danToc, trinhDoHocVan, CMND, noiCuTru, QuocTich;
        Choice biCaoDaTach, biCaoChuaTach, vuAnDaTach, vuAnChuaTach;
        ComboBox tachBiCao, tachVuAnComboBox, chonLoaiTach;
        Button xoa;
        TextBox maVuAnTachVuAn, tenVuAnTachVuAn, tenBiCanTachVuAn, noiDKHKTTTachVuAn;

        public TachVuAn() : base()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/SppAccuSplit/search.jsf";
            chonLoaiTach = new ComboBox("chọn loại tách", xpath.D["chonLoaiTach"], "");

            //Da implement o lop cha
            //soQuyetDinhKhoiTo = new TextBox("mã vụ án", xpath.D["maVuAn"], "");
            //soQuyetDinhKhoiTo = new TextBox("tên bị can", xpath.D["tenBican"], "");
            //soQuyetDinhKhoiTo = new TextBox("nơi đăng kí hộ khẩu thường trú", xpath.D["noiDKHKTT"], "");
            //soQuyetDinhKhoiTo = new TextBox("tên vụ án", xpath.D["tenVuAn"], "");
            //soQuyetDinhKhoiTo = new Button("tìm kiếm", xpath.D["timKiem"], "");

            noiDKHKTTTachVuAn = new TextBox("nơi DKHKTT tách vụ án", xpath.D["noiDKHKTTTachVuAn"], "");
            tenBiCanTachVuAn = new TextBox("tên bị can tách vụ án", xpath.D["tenBiCanTachVuAn"], "");
            danToc = new TextBox("dân tộc", xpath.D["danToc"], "");
            trinhDoHocVan = new TextBox("trình độ học vấn", xpath.D["trinhDoHocVan"], "");
            biCaoChuaTach = new Choice("các bị can bị cáo chưa tách", xpath.D["cacBiCanBiCaoChuaTach"], "");
            biCaoDaTach = new Choice("các bị can bị cáo đã tách", xpath.D["cacBiCanBiCaoDaTach"], "");
            vuAnChuaTach = new Choice("các vụ án chưa tách", xpath.D["cacVuAnChuaTach"], "");
            vuAnDaTach = new Choice("các vụ án đã tách", xpath.D["cacVuAnDaTach"], "");
            CMND = new TextBox("chứng minh nhân dân", xpath.D["CMND"], "");
            noiCuTru = new TextBox("nơi cư trú", xpath.D["noiCuTru"], "");
            QuocTich = new TextBox("quốc tịch", xpath.D["quocTich"], "");
            //chua co:
            //soQuyetDinhKhoiTo = new TextBox("chi tiết", xpath.D["chiTiet"], "");
            tachVuAnComboBox = new ComboBox("tách vụ án", xpath.D["tachVuAnComboBox"], "");
            tachBiCao = new ComboBox("tách bị cáo", xpath.D["tachBiCao"], "");
            xoa = new Button("xóa", xpath.D["xoa"], "");
            //soQuyetDinhKhoiTo = new TextBox("searchResult", xpath.D["searchResult"], "");
            maVuAnTachVuAn = new TextBox("mã vụ án của tách vụ án", xpath.D["maVuAnTachVuAn"], "");
            tenVuAnTachVuAn = new TextBox("tên vụ án của tách vụ án", xpath.D["tenVuAnTachVuAn"], "");


        }
        public void DienThongTin(JObject obj)
        {
            //SendKeys(obj["chonLoaiTach"].ToString(), chonLoaiTach);
            Click(chonLoaiTach);
            Click(tachVuAnComboBox);
            Click(chonLoaiTach);
            Click(tachBiCao);
            //Click(chonLoaiTach);
            //SendKeys(obj["danToc"].ToString(), danToc);
            //SendKeys(obj["TrinhdoHocVan"].ToString(), TrinhdoHocVan);
            Click(vuAnDaTach);
            Click(vuAnChuaTach);
            //SendKeys(obj["CMND"].ToString(), CMND);
            //SendKeys(obj["noiCuTru"].ToString(), noiCuTru);
            //SendKeys(obj["QuocTich"].ToString(), QuocTich);
            //SendKeys(obj["tachVuAn"].ToString(), tachVuAn);
            //Click(tachVuAn);
            //Click(tachVuAn);
            //Click(xoa);

            SendKeys(obj["maVuAn"].ToString(), maVuAnTachVuAn);
            //SendKeys(obj["noiDKHKTT"].ToString(), noiDKHKTT);
            SendKeys(obj["tenVuAn"].ToString(), tenVuAnTachVuAn);
            SendKeys(obj["tenBiCan"].ToString(), tenBiCanTachVuAn);
            SendKeys(obj["CMND"].ToString(), CMND);
            SendKeys(obj["noiDKHKTT"].ToString(), noiDKHKTTTachVuAn);
            SendKeys(Keys.Enter, noiDKHKTTTachVuAn);
            SendKeys(obj["noiCuTru"].ToString(), noiCuTru);
            SendKeys(Keys.Enter, noiCuTru);
            SendKeys(obj["danToc"].ToString(), danToc);
            SendKeys(Keys.Enter, danToc);
            SendKeys(obj["quocTich"].ToString(), QuocTich);
            SendKeys(Keys.Enter, QuocTich);
            SendKeys(obj["trinhDoHocVan"].ToString(), trinhDoHocVan);
            SendKeys(Keys.Enter, trinhDoHocVan);
            Sleep();
            Click(timKiem);
            Sleep();
            Sleep();
            Sleep();
            Sleep();

        }
    }
}

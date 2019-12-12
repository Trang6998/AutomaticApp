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
    class GiaoNhanHoSoTruyTo : Page
    {
        Button btnThemMoi;
        Choice cheoicBoxTaVks;
        TextBox textBoxNgayGiaoNhan;
        TextBox textBoxNguoiGiao;
        TextBox textBoxNguoiNhan;
        TextBox textBoxToaAn;
        Button buttonGhiLai, back;
        public GiaoNhanHoSoTruyTo()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/update.jsf";

            btnThemMoi = new Button("Thêm mới", xpath.D[
                //"AddGnhs"
                "AddGnhsTt"
                ], "");
            cheoicBoxTaVks = new Choice("TA-VKS", xpath.D["hsTaVks"], "");

            textBoxNgayGiaoNhan = new TextBox("Ngày giao nhận", xpath.D["hsNgayGiaoNhan"], "");
            textBoxNguoiGiao = new TextBox("Người giao", xpath.D["hsNguoiGiao"], "");

            textBoxNguoiNhan = new TextBox("Người nhận", xpath.D["hsNguoiNhan"], "");
            textBoxToaAn = new TextBox("Đơn vị giao nhận", xpath.D["hsToaAn"], "");
            buttonGhiLai = new Button("Ghi lại", xpath.D["hsGhiLai"], "");
            back = new Button("Quay lại", xpath.D["hsBack"], "");

        }
        public void FillForm(JObject obj)
        {
            jsClick(btnThemMoi);
            Sleep();
            //Click(cheoicBoxTaVks);

            Click(textBoxNgayGiaoNhan);
            SendKeys(obj["hsNgayGiaoNhan"].ToString(), textBoxNgayGiaoNhan);
            Click(textBoxNguoiGiao);
            SendKeys(obj["hsNguoiGiao"].ToString(), textBoxNguoiGiao);
            Click(textBoxNguoiNhan);
            SendKeys(obj["hsNguoiNhan"].ToString(), textBoxNguoiNhan);
            Click(textBoxToaAn);
            SendKeys(obj["hsDonViNhan"].ToString(), textBoxToaAn);
            SendKeys(Keys.Enter, textBoxToaAn);
            jsClick(buttonGhiLai);
            Sleep();
            jsClick(back);
            Sleep();
        }
    }
}

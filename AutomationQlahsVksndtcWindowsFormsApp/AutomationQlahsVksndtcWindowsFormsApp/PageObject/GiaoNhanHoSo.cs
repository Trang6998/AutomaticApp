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
    class GiaoNhanHoSo :Page
    {
        Button btnThemMoi;
        TextBox textBoxNgayGiaoNhan;
        TextBox textBoxNguoiGiao;
        TextBox textBoxNguoiNhan;
        TextBox textBoxDonViGiaoNhan;
        Button buttonGhiLai, back;
        public GiaoNhanHoSo()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/update.jsf";

            btnThemMoi = new Button("Thêm mới", xpath.D["AddGnhs"], "");
            //*[@id="bodyForm:j_idt440"]
            textBoxNgayGiaoNhan = new TextBox("Ngày giao nhận", xpath.D["hsNgayGiaoNhan"], "");
            textBoxNguoiGiao = new TextBox("Người giao", xpath.D["hsNguoiGiao"], "");

            textBoxNguoiNhan = new TextBox("Người nhận", xpath.D["hsNguoiNhan"], "");
            textBoxDonViGiaoNhan = new TextBox("Đơn vị giao nhận", xpath.D["hsDonViNhan"], "");
            buttonGhiLai = new Button("Ghi lại", xpath.D["hsGhiLai"], "");
            back = new Button("Quay lại", xpath.D["hsBack"], "");

        }
        public void FillForm(JObject obj)
        {
            jsClick(btnThemMoi);
            SendKeys(obj["hsNgayGiaoNhan"].ToString(), textBoxNgayGiaoNhan);
            Click(textBoxNguoiGiao);
            SendKeys(obj["hsNguoiGiao"].ToString(), textBoxNguoiGiao);
            Click(textBoxNguoiNhan);
            SendKeys(obj["hsNguoiNhan"].ToString(), textBoxNguoiNhan);
            Click(textBoxDonViGiaoNhan);
            SendKeys(obj["hsDonViNhan"].ToString(), textBoxDonViGiaoNhan);
            SendKeys(Keys.Enter, textBoxDonViGiaoNhan);
            jsClick(buttonGhiLai);
            Sleep();
            jsClick(back);
            Sleep();
        }
    }
}

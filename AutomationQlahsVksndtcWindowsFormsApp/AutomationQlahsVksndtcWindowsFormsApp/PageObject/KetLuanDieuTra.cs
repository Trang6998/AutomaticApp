using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObject
{
    class KetLuanDieuTra : Page
    {
        TextBox textBoxSoKetLuan;
        TextBox textBoxNgayRaQd;
        TextBox textBoxNgayHieuLuc;
        TextBox textBoxNoiDung;
        TextBox textBoxNguoiKy;
        TextBox textBoxChucVu;
        TextBox textBoxYKien;
        Button buttonGhiLai, buttonAdd, buttonBack;


        public KetLuanDieuTra(){
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/update.jsf";
            buttonAdd = new Button("thêm mới", xpath.D["addKldt"], "");
  
            textBoxSoKetLuan = new TextBox("Kết luận điều tra số",xpath.D["klSoKetLuanDieuTra"],"");

            textBoxNgayRaQd = new TextBox("Ngày CQ ra KLĐT",xpath.D["klNgayRaKetLuan"],"");

            textBoxNgayHieuLuc = new TextBox("Ngày hiệu lực",xpath.D["klNgayHieuLuc"],"");

            textBoxNoiDung = new TextBox("Nội dung	",xpath.D["klNoiDung"],"");  

             textBoxNguoiKy = new TextBox("Người ký",xpath.D["klNguoiKy"],"");

            textBoxChucVu = new TextBox("Chức vụ", xpath.D["klChucVu"], "");

            textBoxYKien = new TextBox("Ý kiến của VKS	",xpath.D["klYKienCuaVKS"],"");
            buttonGhiLai = new Button("Ghi lại",xpath.D["klGhiLai"],"");
            buttonBack = new Button("Ghi lại", xpath.D["klBack"], "");



        }
        public void FillForm(JObject obj){
            jsClick(buttonAdd);
            Click(textBoxSoKetLuan);
            SendKeys(obj["klSoKetLuanDieuTra"].ToString(),textBoxSoKetLuan);
            Click(textBoxNgayRaQd);
            SendKeys(obj["klNgayRaKetLuan"].ToString(),textBoxNgayRaQd);
            SendKeys(Keys.Enter, textBoxNgayRaQd);
            Sleep();
            Sleep();
            SendKeys(Keys.Tab, textBoxNgayRaQd);
            Click(textBoxNgayHieuLuc);
            SendKeys(obj["klNgayHieuLuc"].ToString(),textBoxNgayHieuLuc);
            SendKeys(Keys.Enter, textBoxNgayHieuLuc);
            Sleep();
            Click(textBoxNoiDung);
            SendKeys(obj["klNoiDung"].ToString(),textBoxNoiDung);
            string text="";
            if (obj["klNguoiKy"].ToString()
                .Equals(""))
            {
                text = "null";
            }
            else
            {
                text = obj["klNguoiKy"].ToString();
            }
            Click(textBoxNguoiKy);
            SendKeys(text,textBoxNguoiKy);

            SendKeys(Keys.Enter, textBoxNguoiKy);
            Click(textBoxChucVu);
            SendKeys(obj["klChucVu"].ToString(),textBoxChucVu);
            SendKeys(Keys.Enter, textBoxChucVu);
            Click(textBoxYKien);
            string g = obj["klYKienCuaVKS"].ToString();
            SendKeys(obj["klYKienCuaVKS"].ToString(),textBoxYKien);
            jsClick(buttonGhiLai);
            Sleep();
            jsClick(buttonBack);
            Sleep();


        }
    }
}
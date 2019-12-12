using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObject
{
    class DieuLuatKhoiTo : Page
    {
        Button add, find, thaoTac, backOfBican, btnBoLuat, liBoLuat;
        TextBox dieu, khoan, diem, txtBoLuat; 
        public DieuLuatKhoiTo() : base()
        {
            add = new Button("Them dieu luat", xpath.D["dlThem"], "");
            btnBoLuat = new Button("chon bo luat", xpath.D["dlChonBoLuat"], "");
            dieu = new TextBox("dieu", xpath.D["dlDieu"], "");
            khoan = new TextBox("khoan", xpath.D["dlKhoan"], "");
            diem = new TextBox("diem", xpath.D["dlDiem"], "");
            find = new Button("Tim kiem", xpath.D["dlTimKiem"],"");
            thaoTac = new Button("Chon", xpath.D["dlThaoTac"], "");
            backOfBican = new Button("save", xpath.D["bcBack"], "");
        }

        public void  FillForm(JToken jsonObject)
        {
            Sleep();
            liBoLuat = new Button("click chon bo luat", xpath.g(jsonObject["BoLuat"].ToString(), "dlClickBoLuat"), "");

            jsClick(add);
            Click(btnBoLuat);
            //Clear(txtBoLuat);
            //SendKeys(jsonObject["BoLuat"].ToString(), txtBoLuat);
            Click(liBoLuat);

            Click(dieu);
            Clear(dieu);
            SendKeys(jsonObject["DieuLuat"].ToString(), dieu);
            Click(khoan);
            Clear(khoan);
            SendKeys(jsonObject["KhoanLuat"].ToString(), khoan);
            Click(diem);
            Clear(diem);
            SendKeys(jsonObject["DiemLuat"].ToString(), diem);
            jsClick(find);
            jsClick(thaoTac);
            //jsClick(backOfBican);
            Sleep();
        }
    }
}

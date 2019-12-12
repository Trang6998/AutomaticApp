using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationQlahsVksndtcWindowsFormsApp
{
    class LoginPage : Page
    {
        // taikhoan
        TextBox taiKhoanTextBox;
        TextBox matKhauTextBox;
        Button dangNhapButton;
        Label messagesErrorLabel;
        public LoginPage()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/login.jsf";
            taiKhoanTextBox = new TextBox("tài khoản", xpath.D["userid"],"");
            matKhauTextBox = new TextBox("mật khẩu", xpath.D["password"], "");
            dangNhapButton = new Button("đăng nhập", xpath.D["login"], "");
            messagesErrorLabel = new Label();
        }

        public void DangNhap(JObject obj)
        {
            SendKeys(obj["username"].ToString(), taiKhoanTextBox);
            SendKeys(obj["password"].ToString(), matKhauTextBox);
            Click(dangNhapButton);
        }

       
    }
   
}

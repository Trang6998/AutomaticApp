using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationQlahsVksndtcWindowsFormsApp.PageObjects;
using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;

namespace AutomationQlahsVksndtcWindowsFormsApp.TestCases
{
    class NhanAnClass :TestCaseClass
    {
        private static NhanAnClass _instance;
        private NhanAnClass()
        {

        }
        public static NhanAnClass Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new NhanAnClass();
            }

            return _instance;
        }
        public void Go()
        {
            //ChromeDriver chromeDriver = new ChromeDriver("C:/lqa/automationdotnet");
            ChromeDriver chromeDriver = new ChromeDriver(Application.StartupPath);
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LoginPage lp = new LoginPage();
            lp.driver = chromeDriver;
            lp.Come();

            dynamic jsonObject = new JObject();
            jsonObject.username = "khanh";
            jsonObject.password = "123456";

            lp.DangNhap(jsonObject);

            //////Nhận án//////Nhận án//////Nhận án//////Nhận án//////
            /////+++++++++++++++++++++++++++++++++++++++++++++++++++++
            NhanAn nhanAn = new NhanAn();
            nhanAn.driver = chromeDriver;
            nhanAn.Come();
            jsonObject["maVuAn"] = "000257347";
            jsonObject["tenVuAn"] = "Nguy";
            jsonObject["VKSgiao"] = "1";

            nhanAn.DienThongTin(jsonObject);
            nhanAn.TimKiem();
            //////////////////////////////////////////////////////////

            //chromeDriver.FindElementByXPath("xzcvzxvzxcv").Click();

            chromeDriver.Quit();
        }
    }
}

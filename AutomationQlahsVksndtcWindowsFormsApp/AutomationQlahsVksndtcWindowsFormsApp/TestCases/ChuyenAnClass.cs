using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationQlahsVksndtcWindowsFormsApp.PageObjects;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;

namespace AutomationQlahsVksndtcWindowsFormsApp.TestCases
{
    class ChuyenAnClass : TestCaseClass
    {
        private static ChuyenAnClass _instance;
        private ChuyenAnClass()
        {

        }
        public static ChuyenAnClass Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new ChuyenAnClass();
            }

            return _instance;
        }
        public void Go()
        {
            //ChromeDriver chromeDriver = new ChromeDriver("C:/lqa/automationdotnet");
            //ChromeDriver chromeDriver = new ChromeDriver("D:/chromedriver_win32");
            ChromeDriver chromeDriver = new ChromeDriver(Application.StartupPath);
            
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LoginPage lp = new LoginPage();
            lp.driver = chromeDriver;
            lp.Come();

            dynamic jsonObject = new JObject();
            jsonObject.username = "khanh";
            jsonObject.password = "123456";

            lp.DangNhap(jsonObject);

            ///////Chuyển án///////Chuyển án///////Chuyển án///////Chuyển án///////
            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            ChuyenAn chuyenAn = new ChuyenAn();
            chuyenAn.driver = chromeDriver;
            chuyenAn.Come();

            jsonObject["maVuAn"] = "000320688";
            jsonObject["tenVuAn"] = "Nguy";

            chuyenAn.DienThongTin(jsonObject);
            chuyenAn.TimKiem();
            /////////////////////////////////////////////////

            //chromeDriver.FindElementByXPath("xzcvzxvzxcv").Click();

            chromeDriver.Quit();
        }
    }
}

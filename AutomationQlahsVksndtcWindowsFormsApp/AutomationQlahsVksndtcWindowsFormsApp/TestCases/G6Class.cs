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
    class G6Class :TestCaseClass
    {
        private static G6Class _instance;
        private G6Class()
        {

        }
        public static G6Class Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new G6Class();
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

            G6 g6 = new G6();
            g6.driver = chromeDriver;
            g6.Come();

            jsonObject["maVuAn"] = "0001111";
            jsonObject["tenVuAn"] = "VU AN SO 1";
            jsonObject["maThuLy"] = "0011";
            jsonObject["VKSNhapBanAn"] = "1";
            jsonObject["nguoiChapHanhAn"] = "NGUYEN VAN A";

            g6.DienThongTin(jsonObject);

            //chromeDriver.FindElementByXPath("xzcvzxvzxcv").Click();

            chromeDriver.Quit();
        }
    }
}

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
    class TachVuAnClass :TestCaseClass
    {
        private static TachVuAnClass _instance;
        private TachVuAnClass()
        {

        }
        public static TachVuAnClass Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new TachVuAnClass();
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

            TachVuAn tachVuAn = new TachVuAn();
            tachVuAn.driver = chromeDriver;
            tachVuAn.Come();

            jsonObject["maVuAn"] = "000553882";
            jsonObject["tenVuAn"] = "v";
            jsonObject["tenBiCan"] = "v";
            jsonObject["CMND"] = "123456789";
            jsonObject["noiDKHKTT"] = "01";
            jsonObject["noiCuTru"] = "01";
            jsonObject["danToc"] = "Kinh";
            jsonObject["quocTich"] = "VN";
            jsonObject["trinhDoHocVan"] = "24";

            tachVuAn.DienThongTin(jsonObject);


            //chromeDriver.FindElementByXPath("xzcvzxvzxcv").Click();

            chromeDriver.Quit();
        }
    }
}

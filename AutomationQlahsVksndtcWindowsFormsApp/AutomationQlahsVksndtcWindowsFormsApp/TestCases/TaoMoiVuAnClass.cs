using AutomationQlahsVksndtcWindowsFormsApp.PageObjects;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationQlahsVksndtcWindowsFormsApp.TestCases
{
    class TaoMoiVuAnClass : TestCaseClass
    {
        private static TaoMoiVuAnClass instance = null;
        private TaoMoiVuAnClass()
        {

        }
        public static TaoMoiVuAnClass Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaoMoiVuAnClass();
                }
                return instance;
            }
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

            KiemSatDieuTraTruyTo kiemSatDieuTraTruyTo = new KiemSatDieuTraTruyTo();
            kiemSatDieuTraTruyTo.driver = chromeDriver;
            kiemSatDieuTraTruyTo.Come();
            kiemSatDieuTraTruyTo.AddVuAn();

            TaoMoiVuAnPopUp taoMoiVuAnPopUp = new TaoMoiVuAnPopUp();
            taoMoiVuAnPopUp.driver = chromeDriver;

            jsonObject["quyetĐinhKhoiToVuAnSo"] = "vu an so";
            jsonObject["dieuLuatVu"] = "tội vu khống";
            jsonObject["donViRaQuyetDinh"] = "1";
            jsonObject["tenVuAn"] = "VU AN SO 1";
            jsonObject["maVuCuaToaAn"] = "TOA AN SO 1";
            jsonObject["thang"] = "1";
            jsonObject["nam"] = "2019";
            jsonObject["gio"] = "10:00";
            jsonObject["noiXayRa"] = "HA NOI";
            jsonObject["chiTietNoiXayRa"] = "THANH PHO HA NOI";
            jsonObject["diaChiLuuTruHoSo"] = "HA NOI";
            jsonObject["ghiChu"] = "VU AN O HA NOI";

            taoMoiVuAnPopUp.DienThongTin(jsonObject);

            //chromeDriver.FindElementByXPath("xzcvzxvzxcv").Click();

            chromeDriver.Quit();
        }
    }
}

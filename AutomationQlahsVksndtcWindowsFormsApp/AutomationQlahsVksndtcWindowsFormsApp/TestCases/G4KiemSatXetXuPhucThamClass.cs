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
    class G4KiemSatXetXuPhucThamClass :TestCaseClass
    {
        private static G4KiemSatXetXuPhucThamClass instance = null;
        private G4KiemSatXetXuPhucThamClass()
        {

        }
        public static G4KiemSatXetXuPhucThamClass Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new G4KiemSatXetXuPhucThamClass();
                }
                return instance;
            }
        }

        public void Go()
        {
            //r.Text += "Go\n";
            //ChromeDriver chromeDriver = new ChromeDriver("D:/chromedriver_win32");
            ChromeDriver chromeDriver = new ChromeDriver(Application.StartupPath);
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            // r.Text += "new ChromeDriver\n";
            LoginPage lp = new LoginPage();
            lp.driver = chromeDriver;
            //lp.r = r;
            lp.Come();

            dynamic jsonObject = new JObject();
            jsonObject.username = "khanh";
            jsonObject.password = "123456";

            lp.DangNhap(jsonObject);

            dynamic obj = new JObject();
            obj["soQuyetDinhKhoiTo"] = 1;
            obj["ngayBatDauQDKhoiTo"] = 1;
            obj["coQuanraQD"] = 1;
            obj["coQuanRaQDtxtSearch"] = "Công an";
            obj["ngayKetThucQDKhoiTo"] = 1;
            obj["loaiToiPham"] = 1;
            obj["ngayBatDau"] = 1;
            obj["ngaySinhTu"] = 1;
            obj["chiTietNoidkhktt"] = 1;
            obj["TinhTrang"] = 1;
            obj["ngayBatDauThuLy"] = 1;
            obj["banAnSo"] = 1;
            obj["ngayBatDauraBanAn"] = 1;
            obj["ngayKetThuc"] = 1;
            obj["ngaySinhDen"] = 1;
            obj["chiTietNoiOHienTai"] = 1;
            obj["thuLySo"] = 1;
            obj["ngayKetThucThuLy"] = 1;
            obj["tenKiemSatVien"] = 1;
            obj["ngayKetThucraBanAn"] = 1;
            obj["donVi"] = 1;
            obj["chiTietVuAn"] = 1;


            obj["maVuAn"] = 1;
            obj["tenVuAn"] = 1;
            obj["toidanh"] = "tội vu khống";
            obj["tenbican"] = "Nguyen";
            G4 g4 = new G4();
            g4.driver = chromeDriver;
            //g4.r = r;
            g4.Come();
            g4.DienThongTin(obj);
            g4.TimKiem();

            chromeDriver.Quit();
        }
    }
}


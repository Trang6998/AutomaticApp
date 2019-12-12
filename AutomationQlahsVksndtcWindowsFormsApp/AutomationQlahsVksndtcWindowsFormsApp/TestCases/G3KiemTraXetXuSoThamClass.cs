using AutomationQlahsVksndtcWindowsFormsApp.PageObjects;
using AutomationQlahsVksndtcWindowsFormsApp.Resources;
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
    //https://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/search_G3.jsf
    class G3KiemTraXetXuSoThamClass : TestCaseClass
    {
        private static G3KiemTraXetXuSoThamClass _instance;
        static string id;
        static string username;
        static string password;
        static ChromeDriver chromeDriver;
        private G3KiemTraXetXuSoThamClass()
        {

        }
        public static G3KiemTraXetXuSoThamClass Instance(string _id, string _username, string _password)
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            id = _id;
            username = _username;
            password = _password;
            if (_instance == null)
            {
                _instance = new G3KiemTraXetXuSoThamClass();
            }
            return _instance;
        }
        public void Go()
        {
            JObject json = JsonDataFromWs.Instance(id).get();//    null;//
            dynamic jsonObject = new JObject();
            jsonObject["quyetĐinhKhoiToVuAnSo"] = json["QuyetDinhKhoiTo"]["SoQuyetDinh"];
            chromeDriver = new ChromeDriver(Application.StartupPath);
            //ChromeDriver chromeDriver = new ChromeDriver("C:/lqa/automationdotnet");
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LoginPage lp = new LoginPage();
            lp.driver = chromeDriver;
            lp.Come();

            jsonObject.username = username;
            jsonObject.password = password;

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

            G3 g3 = new G3();
            g3.driver = chromeDriver;
            //g3.r = r;
            g3.Come();
            g3.DienThongTin(obj);
            g3.TimKiem();

            chromeDriver.Quit();
        }
    }
}

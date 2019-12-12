using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObject
{
    class PhanCongKiemSatVien : Page
    {
        TextBox textBoxKiemSatVien;
        TextBox textBoxQuyetDinhPhanCongSo;
        TextBox textBoxNgayPhanCong;
        TextBox textBoxNgayKetThuc;
        Button buttonDieuTraVien,buttonKiemSatVien,save,add, back;
        public PhanCongKiemSatVien(){
                        url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/update.jsf";


            add = new Button("Thêm", xpath.D["addKsv"], "");

            textBoxKiemSatVien =new TextBox("Tên kiểm sát viên",xpath.D["ksvHoTen"],"");
            textBoxQuyetDinhPhanCongSo=new TextBox("Quyết định số",xpath.D["ksvSoQuyetDinh"],"");

            textBoxNgayPhanCong=new TextBox("Ngày phân công",xpath.D["ksvNgayPhanCong"],"");

            textBoxNgayKetThuc=new TextBox("Ngày kết thúc",xpath.D["ksvNgayKetThuc"],"");
            buttonDieuTraVien = new Button("Điều tra viên",xpath.D["ksvLaDieuTraVien1"],"");
            buttonKiemSatVien = new Button("Kiểm sát viên",xpath.D["ksvLaDieuTraVien0"],"");
            save = new Button("Lưu lại",xpath.D["saveKsv"],"");
            back = new Button("Quay lại", xpath.D["backKsv"], "");
        }
        public void FillForm(JObject obj){
            jsClick(add);
            //if(obj["position"].ToString() == "0") {
            //    Click(buttonKiemSatVien);
            //} else Click(buttonDieuTraVien);

            Click(textBoxKiemSatVien);
            SendKeys(obj["ksvHoTen"].ToString(), textBoxKiemSatVien);
            SendKeys(Keys.Enter, textBoxKiemSatVien);

            Click(textBoxQuyetDinhPhanCongSo);
            Other _textBoxKiemSatVien = new Other("họ tên", "//*[@id='bodyForm:inspcodef_hinput']", "");

            var firstName = FindElementByXPath(_textBoxKiemSatVien);
            string value = firstName.GetAttribute("value");

            if (value == null || value == "")
            {
                Clear(textBoxKiemSatVien);
                SendKeys(" ", textBoxKiemSatVien);
                SendKeys(Keys.Enter, textBoxKiemSatVien);
            }

            Click(textBoxQuyetDinhPhanCongSo);
            SendKeys(obj["ksvSoQuyetDinh"].ToString(), textBoxQuyetDinhPhanCongSo);

            Click(textBoxNgayPhanCong);
            SendKeys(obj["ksvNgayPhanCong"].ToString(), textBoxNgayPhanCong);

            Click(textBoxNgayKetThuc);
            SendKeys(obj["ksvNgayKetThuc"].ToString(), textBoxNgayKetThuc);
            Sleep();

            jsClick(save);
            Sleep();
            jsClick(back);
            Sleep();
        }
    }
}
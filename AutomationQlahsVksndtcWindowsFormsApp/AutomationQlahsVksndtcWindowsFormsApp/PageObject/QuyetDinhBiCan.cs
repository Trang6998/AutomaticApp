using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObject
{
    class QuyetDinhBiCan : Page
    {
        Button edit, add, qdBiCan;
        TextBox quyetDinhSo;
        TextBox ngay;

        TextBox vienKiemSat;

        TextBox hieuLuc;

        TextBox nguoiKy;

        TextBox chucVu;
        Button tenCoQuan;
        Button tenCoQuanCT; 
        Button tenBiCan;
        Button tenBiCanCT;
        Button tenDonVi;
        Button loai;
        Button loaiCT;
        Button save;
        Button back;
        Button backFromBiCan;

        public QuyetDinhBiCan()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/update.jsf";
            edit = new Button("edit", xpath.D["bcEdit"], "");
            add = new Button("add", xpath.D["addQdBc"], "");
            qdBiCan = new Button("qdBiCan", xpath.D["qdBiCan"], "");

            quyetDinhSo = new TextBox("Quyết định số", xpath.D["qdBcSoQuyetDinh"], "");
            ngay = new TextBox("Ngày", xpath.D["qdBcNgayRaQuyetDinh"], "");
            //hieuLuc = new TextBox("Hiệu Lực", xpath.D["qdBcHieuLuc"], "");
            nguoiKy = new TextBox("người ký", xpath.D["qdBcTenNguoiKy"], "");
            tenCoQuan = new Button("tên cơ quan", xpath.D["qdBcTenCoQuan"], "");
            tenDonVi = new Button("tên đơn vị", xpath.D["qdBcTenDonVi"], "");
            tenBiCan = new Button("tên bị can", xpath.D["qdBcTenBiCan"], "");
            loai = new Button("loại", xpath.D["qdBcTenloai"], "");
            save = new Button("ghi lại", xpath.D["qdBcSave"], "");
            chucVu = new TextBox("chức vụ", xpath.D["qdBcTenChucVi"], "");
            back = new Button("quay lại", xpath.D["qdBcBack"], "");
            backFromBiCan = new Button("quay lại từ bị can", xpath.D["bcBack"], "");
           

        }
        public void FillForm(JObject obj)
        {
            loaiCT = new Button("chọn loại quyết định", xpath.g(obj["qdBcTenloai"].ToString(), "qdBcTenloaiCT"), "");
            tenCoQuanCT = new Button("chọn loại cơ quan", xpath.g(obj["qdBcTenCoQuan"].ToString(), "qdBcTenCoQuanCT"), "");
            tenBiCanCT = new Button("chọn bị can", xpath.g(obj["qdBcTenBiCan"].ToString(), "qdBcTenBiCanCT"), "");

            //Click(edit);
            //Sleep();
            //Click(add);
            jsClick(qdBiCan);
            Click(quyetDinhSo);
            SendKeys(obj["qdBcSoQuyetDinh"].ToString(), quyetDinhSo);
            Click(ngay);
            SendKeys(obj["qdBcNgayRaQuyetDinh"].ToString(), ngay);

            Click(tenCoQuan);
            Click(tenCoQuanCT);
            Click(tenDonVi);
            Clear(tenDonVi);
            SendKeys(obj["qdBcTenDonVi"].ToString(), tenDonVi);
            SendKeys(Keys.Enter, tenDonVi);
            //SendKeys(obj["qdBcHieuLuc"].ToString(), hieuLuc);
            Click(tenBiCan);
            Click(tenBiCanCT);

            Click(loai);
            Click(loaiCT);
            var tenloai = new Other("tên loại qđ", "//*[@id='bodyForm:deciid:input_label'][contains(text(" + obj["qdBcTenloai"].ToString() + "),'')]", "");
            try 
            {
                FindElementByXPath(tenloai);
            } catch
            {
                loaiCT = new Button("chọn lại loại quyết định", xpath.g(" ", "qdBcTenloaiCT"), "");
                Click(loaiCT);
            }
            Click(nguoiKy);
            string g = obj["qdBcTenChucVu"].ToString();
            SendKeys(obj["qdBcTenNguoiKy"].ToString(), nguoiKy);
            SendKeys(Keys.Enter, nguoiKy);
            Click(chucVu);
            g = obj["qdBcTenChucVu"].ToString();
            SendKeys(obj["qdBcTenChucVu"].ToString(), chucVu);
            SendKeys(Keys.Enter, chucVu);
            

            jsClick(save);
            Sleep();
            jsClick(back);
            Sleep();
            //jsClick(backFromBiCan);
            //Sleep();


        }
    }
}
using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObject
{
    class CaoTrang : Page
    {
        TextBox banCaoTrangSo;
        DateTimePicker ngayVksRaCaoTrang;
        DateTimePicker ngayHieuLuc;
        TextBox noiDung;
        TextBox nguoiKy;
        TextBox chucVu;
        TextBox yKien;
        Button add, save, quayLai;
        public CaoTrang() : base()
        {
            add = new Button("Ban Cao Trang So", xpath.D["ctAdd"], ""); 
            banCaoTrangSo = new TextBox("Ban Cao Trang So", xpath.D["ctBanCaoTrangSo"], "");
            ngayVksRaCaoTrang = new DateTimePicker("Ngay Vks Ra Cao Trang", xpath.D["ctNgayVksRaCaoTrang"], "");
            ngayHieuLuc = new DateTimePicker("Ngay Hieu Luc", xpath.D["ctNgayHieuLuc"], "");
            noiDung = new TextBox("Noi Dung", xpath.D["ctNoiDung"], "");
            nguoiKy = new TextBox("Nguoi Ky", xpath.D["ctNguoiKy"], "");
            chucVu = new TextBox("Chuc Vu", xpath.D["ctChucVu"], "");
            yKien = new TextBox("Y Kien", xpath.D["ctYKien"], "");
            save = new Button("Ghi Lai", xpath.D["ctSave"], "");
            quayLai = new Button("Back", xpath.D["ctBack"], "");
        }

        public void FillForm(JObject jObject)
        {
            jsClick(add);
            Click(ngayVksRaCaoTrang);
            SendKeys(jObject["ngayVksRaCaoTrang"].ToString(), ngayVksRaCaoTrang);
            
            SendKeys(jObject["banCaoTrangSo"].ToString(), banCaoTrangSo);
            Click(ngayHieuLuc);
            SendKeys(jObject["ngayHieuLuc"].ToString(), ngayHieuLuc);
            //Click(noiDung);
            SendKeys(jObject["noiDung"].ToString(), noiDung);
            //Click(nguoiKy);
            SendKeys(jObject["nguoiKy"].ToString(), nguoiKy);
            //Click(chucVu);
            SendKeys(jObject["chucVu"].ToString(), chucVu);
            //Click(yKien);
            SendKeys(jObject["yKien"].ToString(), yKien);
            Click(save);
            Click(quayLai);

        }
    }
}

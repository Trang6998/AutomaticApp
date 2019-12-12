using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System.Linq;

namespace AutomationQlahsVksndtcWindowsFormsApp.PageObject
{
    class QuyetDinhVuAn : Page
    {
        Button loaiQuyetDinh,loaiquyetdinhCt;
        Button menuTenQuyetDinh,tenQuyetDinh;
        Button menuDonVi, donVi;
        TextBox vienKiemSat, quyetDinhSo,ngayQuyetDinh,thoiHan,tuNgay,denNgay,thoiHanThucTe,nguoiKy,chucVu;
        public QuyetDinhVuAn(){
            loaiQuyetDinh = new Button("Menu loai quyet dinh",xpath.D[""],"");
            loaiquyetdinhCt = new Button("Menu loai quyet dinh",xpath.D[""],"");
            menuTenQuyetDinh = new Button("loai quyet dinh",xpath.D[""],"");
            tenQuyetDinh = new Button("Menu ten quyet dinh",xpath.D[""],"");
            menuDonVi = new Button("ten quyet dinh",xpath.D[""],"");
            donVi = new Button("Don vi",xpath.D[""],"");


        }
        public void FillForm(JObject json)
        {
            string xpath = "";
            string text = "";
            JToken[] ts = json["ThuLyKhoiTo"]["QuyetDinhVuAn"].ToArray();
            foreach (JToken jTokenI in ts)
            {
                jsClick(new Control("them moi",
                    "//*[@id='bodyForm:j_idt295']", "")
                );
                Click(new Control("hieu luc den",
                    "//*[@id='bodyForm:todate1_input']", "")
                );

                SendKeys(json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["HieuLucDenNgay"].ToString(),
                    new Control("Hieu luc den ngay", "//*[@id='bodyForm:todate1_input']", "")
                );
                Click(new Control("hieu luc tu",
                   "//*[@id='bodyForm:fromdate1_input']", "")
               );
                //SendKeys(json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["HieuLucTuNgay"].ToString(),
                //    new Control("Hieu luc tu ngay", "//*[@id='bodyForm:fromdate1_input']", "")
                //);
                SendKeys("01/1/2019",
                    new Control("Hieu luc tu ngay", "//*[@id='bodyForm:fromdate1_input']", "")
                );


                Click(new Control("ngay quyet dinh",
                    "//*[@id='bodyForm:indate1_input']", "")
                );
                SendKeys("01/11/2019",
                    new Control("ngay quyet dinh", "//*[@id='bodyForm:indate1_input']", "")
                );
                //SendKeys(json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["NgayRaQuyetDinh"].ToString(),
                //    new Control("ngay quyet dinh", "//*[@id='bodyForm:indate1_input']", "")
                //);

                Click(new Control("ten quyet dinh",
                    "//*[@id='bodyForm:cboDeciid_label']", "")
                );
                //SendKeys(json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["Tenloai"].ToString(),
                //    new Control("chon ten", "//*[@id='bodyForm:cboDeciid_filter']", "")
                //);
                Click(new Control("khoi to vu an",
                    "//*[@id='bodyForm:cboDeciid_panel']/div[2]/ul/li[2]", "")
                );//random
                Click(new Control("don vi ra quyet dinh",
                    "//*[@id='bodyForm:cboDonViRaQD_label]", "")
                );
                if (json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["TenCoQuan"].ToString().Contains
                    ("Công an"))
                {
                    xpath = "//*[@id='bodyForm:cboDonViRaQD_panel']/div/ul/li[1]";
                }
                if (json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["TenCoQuan"].ToString().Contains
                    ("Viện kiểm sát"))
                {
                    xpath = "//*[@id='bodyForm:cboDonViRaQD_panel']/div/ul/li[7]";
                }
                Click(new Control("chon don vi ra quyet dinh", xpath, ""));





                Click(new Control("nguoi ky",
                   "//*[@id='bodyForm:fromdate1_input']", "")
                );
                if (json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["TenNguoiKy"].ToString()
                    .Equals(""))
                {
                    text = "null";
                }
                else
                {
                    text = json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["TenNguoiKy"].ToString();
                }
                SendKeys(text, new Control("nguoi ky", "//*[@id='bodyForm:inspcode_input']", "")
                );

                Click(new Control("nguoi ky",
                    "//*[@id='bodyForm:signoffice1_input']", "")
                );
                SendKeys(json["ThuLyKhoiTo"]["QuyetDinhVuAn"][0]["TenChucVu"].ToString(),
                    new Control("chuc vu", "//*[@id='bodyForm:signoffice1_input']", "")
                );

                Click(new Control("ghi lai",
                    "//*[@id='bodyForm:btnsavedeci']", "")
                );
                Sleep();
                Click(new Control("OK",
                    "//*[@id='bodyForm:j_idt3116']", "")
                );
                Sleep();
                Click(new Control("quay lai",
                    "//*[@id='bodyForm:j_idt2552']", "")
                );
                Sleep();

            }



        }

        public void FillFormTruyTo(JObject json)
        {
            string xpath = "";
            string text = "";
            if (json["ThuLyTruyTo"].ToString() != "")
            {
                JToken[] ts = json["ThuLyTruyTo"]["QuyetDinhVuAn"].ToArray();
                foreach (JToken jTokenI in ts)
                {
                    jsClick(new Control("them moi",
                    "//*[@id='bodyForm:j_idt295']", "")
                    );

                    Click(new Control("ten quyet dinh",
                        "//*[@id='bodyForm:cboDeciid_label']", "")
                    );
                    //SendKeys(json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["Tenloai"].ToString(),
                    //    new Control("chon ten", "//*[@id='bodyForm:cboDeciid_filter']", "")
                    //);
                    Click(new Control("khoi to vu an",
                        "//*[@id='bodyForm:cboDeciid_panel']/div[2]/ul/li[2]", "")
                    );//random

                    Click(new Control("hieu luc tu",
                        "//*[@id='bodyForm:fromdate1_input']", "")
                    );
                    SendKeys((json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["HieuLucTuNgay"]).ToString(),
                        new Control("ngay quyet dinh", "//*[@id='bodyForm:fromdate1_input']", "")
                    );

                    Click(new Control("don vi ra quyet dinh",
                        "//*[@id='bodyForm:cboDonViRaQD_label]", "")
                    );
                    if (json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["TenCoQuan"].ToString().Contains
                        ("Công an"))
                    {
                        xpath = "//*[@id='bodyForm:cboDonViRaQD_panel']/div/ul/li[1]";
                    }
                    if (json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["TenCoQuan"].ToString().Contains
                        ("Viện kiểm sát"))
                    {
                        xpath = "//*[@id='bodyForm:cboDonViRaQD_panel']/div/ul/li[7]";
                    }
                    Click(new Control("chon don vi ra quyet dinh", xpath, ""));

                    Clear(new Control("ten don vi ra quyet dinh", "//*[@id='bodyForm:lbCboSPP_input']", ""));
                    Click(new Control("hieu luc den",
                        "//*[@id='bodyForm:todate1_input']", "")
                    );
                    SendKeys((json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["HieuLucDenNgay"]).ToString(),
                        new Control("hieu luc den", "//*[@id='bodyForm:todate1_input']", "")
                    );
                    SendKeys(json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["TenDonVi"].ToString(),
                       new Control("ten don vi ra quyet dinh", "//*[@id='bodyForm:lbCboSPP_input']", "")
                    );
                    SendKeys(Keys.Enter, new Control("ten don vi ra quyet dinh", "//*[@id='bodyForm:lbCboSPP_input']", ""));
                    SendKeys((json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["SoQuyetDinh"]).ToString(),
                        new Control("quyet dinh so", "//*[@id='bodyForm:setnum1']", "")
                    );
                    Click(new Control("ngay quyet dinh",
                        "//*[@id='bodyForm:indate1_input']", "")
                    );
                    SendKeys(json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["NgayRaQuyetDinh"].ToString(),
                        new Control("ngay quyet dinh", "//*[@id='bodyForm:indate1_input']", "")
                    );

                    //Click(new Control("nguoi ky",
                    //   "//*[@id='bodyForm:fromdate1_input']", "")
                    //);
                    if (json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["TenNguoiKy"].ToString()
                        .Equals(""))
                    {
                        text = "null";
                    }
                    else
                    {
                        text = json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["TenNguoiKy"].ToString();
                    }
                    SendKeys(text, new Control("nguoi ky", "//*[@id='bodyForm:inspcode_input']", "")
                    );

                    Click(new Control("nguoi ky",
                        "//*[@id='bodyForm:signoffice1_input']", "")
                    );
                    SendKeys(json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["TenChucVu"].ToString(),
                        new Control("chuc vu", "//*[@id='bodyForm:signoffice1_input']", "")
                    );


                    string temp = "";
                    if (json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["NoiDung"].ToString()
                        .Equals(""))
                    {
                        temp = "null";
                    }
                    else
                    {
                        temp = json["ThuLyTruyTo"]["QuyetDinhVuAn"][0]["NoiDung"].ToString();
                    }
                    SendKeys(temp, new Control("ghi chu", "//*[@id='bodyForm:content1']", "")
                    );

                    Click(new Control("ghi lai",
                        "//*[@id='bodyForm:btnsavedeci']", "")
                    );
                    Sleep();
                    Click(new Control("quay lai",
                        "//*[@id='bodyForm:j_idt2552']", "")
                    );
                    Sleep();
                }

            }
        }
    }
}
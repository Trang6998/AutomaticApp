using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQlahsVksndtcWindowsFormsApp.Resources
{
    class Xpath
    {
        Dictionary<string, string> dictionary;
        public Dictionary<string, string> D
        {
            get { return dictionary; }

        }
        public string g(string value, string key)
        {
            string xpath = dictionary[key];
            string rr = xpath.Replace("aaa", value);
            return rr;
        }
        public Xpath()
        {
            Console.WriteLine("dictionary = new Dictionary<string, string>();");
            dictionary = new Dictionary<string, string>();
            dictionary.Add("userid", "//*[@id='j_idt8:userid']");
            //dictionary.Add("userid", "//*[@id='j_idt8:j_idt20']");
            dictionary.Add("password", "//*[@id='j_idt8:password']");
            dictionary.Add("login", "//*[@id='j_idt8:j_idt31']");
            
            //*[@id="bodyForm:casebeginIndate"]/button
            //*[@id="bodyForm:casebeginSetnum"]
            //*[@id="bodyForm:casebeginSetnum"]
            //keyValuePairs.Add()
            //dictionary.Add("textcoQuanRaQuyetDinh", "//a/span[text()='Qu?n lý án Hình s?']/..");
            dictionary.Add("inputQuyetDinhKhoiToVuAnSo", "//*[@id='bodyForm:casebeginSetnum']");
            dictionary.Add("buttonNgayQuyetDinhKhoiToVuAn", "//*[@id='bodyForm:casebeginIndate']/button");
            dictionary.Add("txtNgayQDKhoiToVuAn", "//*[@id='bodyForm:casebeginIndate_input']");
            dictionary.Add("Ngay15QuyetDinhKhoiToVuAn", "//*[@id='bodyForm:casebeginIndate']/button");

            //dictionary.Add("inputDieuLuatVu", "bodyForm:lawcode_input");
            //*[@id="bodyForm:lawcode_input"]
            dictionary.Add("inputDieuLuatVu", "//*[@id='bodyForm:lawcode_input']");
            //dictionary.Add("inputDonViRaQuyetDinh", "bodyForm:casesppspcid2_input");
                                                       //*[@id="bodyForm:casesppspcid2_input"]
            dictionary.Add("txtNgayXayRa", "//*[@id='bodyForm:casecrimdate_input']");
            dictionary.Add("inputDonViRaQuyetDinh", "//*[@id='bodyForm:casesppspcid2_input']");
                                                     //*[@id="bodyForm:casesppspcid2_input"]
            dictionary.Add("", "//*[@id='bodyForm:casesppspcid2_panel']/ul/li[1]");
            //dictionary.Add("inputTenVuAn", "bodyForm:casecasename");
            dictionary.Add("inputTenVuAn", "//*[@id='bodyForm:casecasename']");
            dictionary.Add("inputMaVuCuaToaAn", "//*[@id='bodyForm:casespccasecode']");
            dictionary.Add("clickLoaiToiPham", "//*[@id='bodyForm:caseautolaw']/div[2]");
            dictionary.Add("chonLoaiToiPham", "//*[@id='bodyForm:casecasetype_label']");
            dictionary.Add("btnLoaiToiPhamChuaXD", "//*[@id='bodyForm:casecasetype_panel']/div/ul/li[1]");
            dictionary.Add("btnLoaiToiPhamItNghiemTrong", "//*[@id='bodyForm:casecasetype_panel']/div/ul/li[2]");
            dictionary.Add("btnLoaiToiPhamNghiemTrong", "//*[@id='bodyForm:casecasetype_panel']/div/ul/li[3]");
            dictionary.Add("btnLoaiToiPhamRatNghiemTrong", "//*[@id='bodyForm:casecasetype_panel']/div/ul/li[4]");
            dictionary.Add("btnLoaiToiPhamDacBietNghiemTrong", "//*[@id='bodyForm:casecasetype_panel']/div/ul/li[5]");
            dictionary.Add("buttonNgayXayRa", "//*[@id='bodyForm:casecrimdate']/button");
            dictionary.Add("inputThang", "//*[@id='bodyForm:casecmonth']");
            dictionary.Add("inputNam", "//*[@id='bodyForm:casecyear']");
            dictionary.Add("inputGio", "//*[@id='bodyForm:casecrimtime']");
            //dictionary.Add("inputNoiXayRa", "bodyForm:casecrimwhere_input");
            //*[@id="bodyForm:casecrimwhere_input"]
            dictionary.Add("inputNoiXayRa", "//*[@id='bodyForm:casecrimwhere_input']");
            //dictionary.Add("inputChiTietNoiXayRa", "bodyForm:casecrimwhere1");
            dictionary.Add("inputChiTietNoiXayRa", "//*[@id='bodyForm:casecrimwhere1']");
            //dictionary.Add("inputDiaChiLuuTruHoSo", "bodyForm:caseaddress");
            dictionary.Add("inputDiaChiLuuTruHoSo", "//*[@id='bodyForm:caseaddress']");
            //dictionary.Add("inputGhiChu", "bodyForm:caseremark");
            dictionary.Add("inputGhiChu", "//*[@id='bodyForm:caseremark']");
            //dictionary.Add("inputGhiAmGhiHinhBiMat", "bodyForm:case_ghihinh");
            dictionary.Add("inputGhiAmGhiHinhBiMat", "//*[@id='bodyForm:case_ghihinh']");
            //dictionary.Add("buttonGhiLai", "bodyForm:j_idt1087");
            //dictionary.Add("buttonGhiLai", "//*[@id='bodyForm:j_idt1087']");
            //dictionary.Add("buttonLoaiToiPham", "bodyForm:btnSearch");
            dictionary.Add("checkBLoaiToiPham", "//*[@id='bodyForm:caseautolaw_input']/..");

            dictionary.Add("bsdlToiDanh", "//*[@id='bodyForm:casetxtLaw_input']");
            dictionary.Add("bsdlGhiLaiDieuLuat", "//*[@id='bodyForm:casebtnUpdate']");
            

            //dictionary.Add("inputMaVuAn", "bodyForm:casecode");
            //dictionary.Add("inputTenVuAn", "bodyForm:casename");
            //dictionary.Add("inputQuyetDinhKhoiToVuAnSo", "bodyForm:bengin_setnum");
            //*[@id="bodyForm:casesid"]
            dictionary.Add("dropdownCoQuanRaQuyetDinh", "//*[@id='bodyForm:casesid']");
            //dictionary.Add("coQuanCongAn", "//*[@id='bodyForm:casesid_panel']/div/ul/li[1]");
            dictionary.Add("coQuanCongAn", "//*[@id='bodyForm:casesid_panel']/div/ul/li[1]");

            dictionary.Add("ngayMot", "//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[3]/a");
            dictionary.Add("toiVuKhong", "//*[@id='bodyForm:lawcode_panel']/ul/li[4]");
            dictionary.Add("buttonGhiLai", "//*[@id='bodyForm:j_idt1087']");
            dictionary.Add("buttonQuayLai", "//*[@id='bodyForm:j_idt1088']");
            
            dictionary.Add("buttondatepickerQuyetDinhKhoiToTuNgay", "//*[@id='bodyForm:begin_indatefrom']/button");
            dictionary.Add("buttondatepickerQuyetDinhKhoiToDenNgay", "//*[@id='bodyForm:begin_indateto']/button");
            dictionary.Add("inputToiDanh", "//input[@id='bodyForm:casetxtLaw_input']");
            dictionary.Add("dropdownLoaiToiPham", "//*[@id='bodyForm:casetype']/div[2]");
            dictionary.Add("liLoaiToiPhamItNghiemTrong", "//*[@id='bodyForm:casetype_panel']/div[2]/ul/li[3]");
            dictionary.Add("inputTenBiCan", "//input[@id='bodyForm:fullname']");
            dictionary.Add("toidanhG3", "//*[@id='bodyForm:casetxtLaw_panel']/ul/li[4]");
            

            //input[@id='bodyForm:txtCasecode']
            //input[@id='bodyForm:txtCrimdate_from_input']
            //input[@id='bodyForm:txtCasename']
            //input[@id='bodyForm:txtCrimdate_to_input']
            //input[@id='bodyForm:status:0']
            //input[@id='bodyForm:status:1']
            //input[@id='bodyForm:spcnamet']
            //button[@id='bodyForm:btnSearch']
            //button[@id='bodyForm:btnDetail']
            //button[@id='bodyForm:btnThuLy']
            //button[@id='bodyForm:btnEdit']
            //button[@id='bodyForm:btnDelete']
            //tbody[@id='bodyForm:resultTable_data']/tr[1]
            dictionary.Add("maVuAn", "//input[@id='bodyForm:txtCasecode']");
			dictionary.Add("maVuAnG3", "//input[@id='bodyForm:casecode']");
            //dictionary.Add("inputTenBiCan", "//input[@id='bodyForm:txtCrimdate_from_input']");
            //dictionary.Add("inputTenBiCan", "//input[@id='bodyForm:txtCasename']");
            //dictionary.Add("inputTenBiCan", "//input[@id='bodyForm:txtCrimdate_to_input']");
            //dictionary.Add("inputTenBiCan", "//input[@id='bodyForm:status:0']");
            //dictionary.Add("inputTenBiCan", "//input[@id='bodyForm:status:1']");
            //dictionary.Add("inputTenBiCan", "//input[@id='bodyForm:spcnamet']");
            dictionary.Add("timKiem", "//button[@id='bodyForm:btnSearch']");
            dictionary.Add("timKiemG6", "//*[@id='bodyForm:btnSearch']");
            //dictionary.Add("inputTenBiCan", "//button[@id='bodyForm:btnDetail']");
            //dictionary.Add("inputTenBiCan", "//button[@id='bodyForm:btnThuLy']");
            //dictionary.Add("inputTenBiCan", "//button[@id='bodyForm:btnEdit'	");
            //dictionary.Add("inputTenBiCan", "//button[@id='bodyForm:btnDelete']");
            //dictionary.Add("inputTenBiCan", "//tbody[@id='bodyForm:resultTable_data']/tr[1]");
            dictionary.Add("noiDkhktt", "//input[@id='bodyForm:localid_input']");
            dictionary.Add("chiTietNoiOHienTai", "//input[@id='bodyForm:addrname:input']");
            dictionary.Add("tenKsVien", "//*[@id='bodyForm:inspectorname']");
            dictionary.Add("bcCMND", "//*[@id='bodyForm:a_identify:input']");
            //dictionary.Add("thuLySo", "//*[@id='bodyForm:regisetnum']");
            dictionary.Add("QDkhoitotungay", "//*[@id='bodyForm:begin_indatefrom_input']");

            //1
            //dictionary.Add("maVuAn", "//input[@id='bodyForm:txtCasecode']");
            //dictionary.Add("tuNgay", "//input[@id='bodyForm:txtCrimdate_from_input']");
            dictionary.Add("tuNgay", "//*[@id='bodyForm:txtCrimdate_from']/button");
            dictionary.Add("ngayMotBD", "//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[3]/a");
            dictionary.Add("tenVuAn", "//input[@id='bodyForm:txtCasename']");
            dictionary.Add("tenVuAnG3", "//input[@id='bodyForm:casename']");
            //dictionary.Add("denNgay", "//input[@id='bodyForm:txtCrimdate_to_input']");
            dictionary.Add("denNgay", "//*[@id='bodyForm:txtCrimdate_to']/button");
            dictionary.Add("ngayMotKT", "//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[3]/a");
            dictionary.Add("chuaChuyen", "//input[@id='bodyForm:status:0']");
            dictionary.Add("daChuyen", "//input[@id='bodyForm:status:1']");
            dictionary.Add("tenVKSNhan", "//input[@id='bodyForm:spcnamet']");
            //dictionary.Add("timKiem", "//button[@id='bodyForm:btnSearch']");
            dictionary.Add("chiTiet", "//button[@id='bodyForm:btnDetail']");
            dictionary.Add("themMoi", "//button[@id='bodyForm:btnThuLy']");
            dictionary.Add("sua", "//button[@id='bodyForm:btnEdit']");
            dictionary.Add("xoa", "//button[@id='bodyForm:btnDelete']");
            dictionary.Add("searchResult", "//tbody[@id='bodyForm:resultTable_data']/tr[1]");
            //2
            //dictionary.Add("maVuAn", "//input[@id='bodyForm:txtCasecode']");
            //dictionary.Add("tuNgay", "//input[@id='bodyForm:txtCrimdate_from_input']");
            //dictionary.Add("tenVuAn", "//input[@id='bodyForm:txtCasename']");
            //dictionary.Add("denNgay", "//input[@id='bodyForm:txtCrimdate_to_input']");
            dictionary.Add("vienKiemSoatGiao", "//input[@id='bodyForm:spcnamet']");
            dictionary.Add("chuaNhan", "//input[@id='bodyForm:status:0']");
            dictionary.Add("daNhan", "//input[@id='bodyForm:status:1']");
            //dictionary.Add("timKiem", "//button[@id='bodyForm:btnSearch']");
            //dictionary.Add("chiTiet", "//button[@id='bodyForm:btnDetail']");
            dictionary.Add("nhanAn", "//button[@id='bodyForm:btnEdit']");
            //dictionary.Add("xoa", "//button[@id='bodyForm:btnDelete']");
            //dictionary.Add("searchResult", "//tbody[@id='bodyForm:resultTable_data']/tr[1]");
            //3
            //dictionary.Add("chonLoaiTach", "//select[@id='bodyForm:choice1_input']");
            dictionary.Add("chonLoaiTach", "//*[@id='bodyForm:choice1']");
            dictionary.Add("tachBiCao", "//*[@id='bodyForm:choice1_panel']/div/ul/li[1]");
            //dictionary.Add("maVuAn", "//input[@id='bodyForm:casecode']");
            dictionary.Add("tenBiCanTachVuAn", "//*[@id='bodyForm:fullname']");
            dictionary.Add("noiDKHKTT", "//input[@id='bodyForm:localid_input']");
            dictionary.Add("noiDKHKTTTachVuAn", "//*[@id='bodyForm:localid_input']");
            dictionary.Add("danToc", "//*[@id='bodyForm:natiid_input']");
            //dictionary.Add("trinhDoHocVan", "//input[@id='bodyForm:levelid_input']");
            dictionary.Add("trinhDoHocVan", "//*[@id='bodyForm:levelid_input']");
            //dictionary.Add("cacBiCanBiCaoChuaTach", "//input[@id='bodyForm:choice:0']");
            dictionary.Add("cacBiCanBiCaoChuaTach", "//*[@id='bodyForm:choice']/tbody/tr/td[1]/div/div[2]");
            //dictionary.Add("cacBiCanBiCaoDaTach", "//input[@id='bodyForm:choice:1']");
            dictionary.Add("cacBiCanBiCaoDaTach", "//*[@id='bodyForm:choice']/tbody/tr/td[3]/div/div[2]");
            dictionary.Add("cacVuAnChuaTach", "//*[@id='bodyForm:choice']/tbody/tr/td[1]/div/div[2]");
            dictionary.Add("cacVuAnDaTach", "//*[@id='bodyForm:choice']/tbody/tr/td[3]/div/div[2]");
            dictionary.Add("maVuAnTachVuAn", "//*[@id='bodyForm:casecode']");
            dictionary.Add("tenVuAnTachVuAn", "//*[@id='bodyForm:casename']");
            //dictionary.Add("tenVuAn", "//input[@id='bodyForm:casename']");
            //dictionary.Add("CMND", "//input[@id='bodyForm:identify']");
            dictionary.Add("CMND", "//*[@id='bodyForm:identify']");
            dictionary.Add("noiCuTru", "//*[@id='bodyForm:address_input']");
            //dictionary.Add("timKiem", "//button[@id='bodyForm:btnSearch']");
            //dictionary.Add("chiTiet", "//button[@id='bodyForm:j_idt121']");
            //dictionary.Add("tachVuAn", "//button[@id='bodyForm:j_idt122']");
            dictionary.Add("tachVuAnComboBox", "//*[@id='bodyForm:choice1_panel']/div/ul/li[2]");

            //ThuLy
            dictionary.Add("loaiThuLy", "//*[@id='bodyForm:r_transfer:input_input']");
            dictionary.Add("thuLySo", "//*[@id='bodyForm:r_setnum:input']");
            dictionary.Add("ngayThuLy", "//*[@id='bodyForm:r_indate:input_input']");
            dictionary.Add("thoiHanThuLyDenNgay", "//*[@id='bodyForm:r_todate:input_input']");
            dictionary.Add("thoiHanThuLyTuNgay", "//*[@id='bodyForm:r_fromdate:input_input']");
            dictionary.Add("ghiLaiThuLy", "//*[@id='bodyForm:j_idt1619']");
            dictionary.Add("lineData", "//*[@id='bodyForm:resultTable_data']");
            dictionary.Add("capNhapThongTin", "//*[@id='bodyForm:j_idt265']");
            dictionary.Add("themMoiThuLy", "//*[@id='bodyForm:j_idt207']");
            dictionary.Add("maVuAnTestThuLy", "//*[@id='bodyForm:casecode']"); 
            dictionary.Add("ghiLaiTestThuLy", "//*[@id='bodyForm:j_idt1619']");

            //Nhận án
            //*[@id="bodyForm:txtCrimdate_from_input"]
            dictionary.Add("tuNgayNhanAn", "//*[@id='bodyForm:txtCrimdate_from_input']");
            dictionary.Add("denNgayNhanAn", "//*[@id='bodyForm:txtCrimdate_to_input']");

            //dictionary.Add("xoa", "//button[@id='bodyForm:j_idt123']");
            //dictionary.Add("searchResult", "//tbody[@id='bodyForm:resultTable_data']/tr[1]");
            //G3
            //dictionary.Add("maVuAn", "//input[@id='bodyForm:casecode']");
            dictionary.Add("quyetDinhKhoiTo", "//input[@id='bodyForm:bengin_setnum']");
            //dictionary.Add("ngayQDKhoiToTuNgay", "//input[@id='bodyForm:begin_indatefrom_input']");
            dictionary.Add("toiDanh", "//input[@id='bodyForm:casetxtLaw_input']");
            //Ngày QĐ khởi tố từ ngày
            dictionary.Add("ngayQDKhoiToTuNgay", "//*[@id='bodyForm:begin_indatefrom']/button");
            dictionary.Add("ngayQDKhoiToTuNgayText", "//*[@id='bodyForm:begin_indatefrom_input']");
            dictionary.Add("ngay10","//*[@id='ui-datepicker-div']/table/tbody//a[text()='10']");
            dictionary.Add("tenBiCanG3", "//input[@id='bodyForm:fullname:input']");
            //dictionary.Add("tenVuAn", "//input[@id='bodyForm:casename']");
            
            dictionary.Add("coQuanRaQuyetDinh", "//*[@id='bodyForm:sid']/div[2]");
            dictionary.Add("coQuanRaQDtxtSearch", "//*[@id='bodyForm:sid_filter']");
            dictionary.Add("congAn", "//*[@id='bodyForm:sid_panel']/div[2]/ul/li[2]");
			//dictionary.Add("coQuanRaQuyetDinh", "//select[@id='bodyForm:sid_input']");
            

            dictionary.Add("ngayQDKhoiToDenNgay", "//*[@id='bodyForm:begin_indateto']/button");
            dictionary.Add("ngayQDKhoiToDenNgayText", "//*[@id='bodyForm:begin_indateto_input']");
            dictionary.Add("ngay20", "//*[@id='ui-datepicker-div']/table/tbody//a[text()='20']");
            //*[@id="bodyForm:fullname:input"]

            //dictionary.Add("loaiToiPham", "//select[@id='bodyForm:casetype_input']");
            dictionary.Add("loaiToiPham", "//*[@id='bodyForm:casetype']");
            dictionary.Add("loaiToiPhamChuaXacDinh", "//*[@id='bodyForm:casetype_panel']/div[2]/ul/li[2]");
            dictionary.Add("ngayXayRaTuNgay", "//input[@id='bodyForm:crimdate_from_input']");
            dictionary.Add("ngaySinhTu", "//input[@id='bodyForm:birthdayfrom:input_input']");
            dictionary.Add("chiTietNoiDKHKTT", "//input[@id='bodyForm:locaname:input']");
            dictionary.Add("tinhTrang", "//select[@id='bodyForm:regiclosed_input']");
            dictionary.Add("thuLyTuNgay", "//input[@id='bodyForm:indate_from_input']");
            dictionary.Add("banAnSo", "//input[@id='bodyForm:centsetnum']");
            dictionary.Add("ngayRaBanAnTuNgay", "//input[@id='bodyForm:centindate_from_input']");
            dictionary.Add("ngayXayRaDenNgay", "//input[@id='bodyForm:crimdate_to_input']");
            dictionary.Add("ngaySinhDen", "//input[@id='bodyForm:birthdayto:input_input']");
            //dictionary.Add("chiTietNoiOHienTai", "//input[@id='bodyForm:addrname:input']");
            //dictionary.Add("thuLySo", "//input[@id='bodyForm:regisetnum']");
            dictionary.Add("thuLyDenNgay", "//input[@id='bodyForm:indate_to_input']");
            dictionary.Add("tenKiemSatVien", "//input[@id='bodyForm:inspectorname']");
            dictionary.Add("ngayRaBanAnDenNgay", "//input[@id='bodyForm:centindate_to_input']");
            //dictionary.Add("donVi", "//input[@id='bodyForm:sppspcid3_input']");
            dictionary.Add("donVi", "//*[@id='bodyForm:sppspcid2_input']");
            //dictionary.Add("timKiem", "//button[@id='bodyForm:btnSearch']");
            dictionary.Add("capNhatThongTin", "//button[@id='bodyForm:j_idt265']");
            dictionary.Add("chiTietVuAn", "//button[@id='bodyForm:j_idt267']");
            //dictionary.Add("searchResult", "//tbody[@id='bodyForm:resultTable_data']/tr[1]");
            //G4
            //dictionary.Add("maVuAn", "//input[@id='bodyForm:casecode']");
            dictionary.Add("quyetDinhKhoiToVuAnSo", "//input[@id='bodyForm:bengin_setnum']");
            //dictionary.Add("ngayQDKhoiToTuNgay", "//input[@id='bodyForm:begin_indatefrom_input']");
            //dictionary.Add("toiDanh", "//input[@id='bodyForm:casetxtLaw_input']");
            //dictionary.Add("tenBiCan", "//input[@id='bodyForm:fullname:input']");
            //dictionary.Add("tenVuAn", "//input[@id='bodyForm:casename']");
            //dictionary.Add("coQuanRaQuyetDinh", "//select[@id='bodyForm:sid_input']");
            //dictionary.Add("ngayQDKhoiToDenNgay", "//input[@id='bodyForm:begin_indateto_input']");
            //dictionary.Add("loaiToiPham", "//select[@id='bodyForm:casetype_input']");
            //dictionary.Add("ngayXayRaTuNgay", "//input[@id='bodyForm:crimdate_from_input']");
            //dictionary.Add("ngaySinhTu", "//input[@id='bodyForm:birthdayfrom:input_input']");
            //dictionary.Add("chiTietNoiDKHKTT", "//input[@id='bodyForm:locaname:input']");
            //dictionary.Add("tinhTrang", "//select[@id='bodyForm:regiclosed_input']");
            //dictionary.Add("thuLyTuNgay", "//input[@id='bodyForm:indate_from_input']");
            //dictionary.Add("banAnSo", "//input[@id='bodyForm:centsetnum']");
            //dictionary.Add("ngayRaBanAnTuNgay", "//input[@id='bodyForm:centindate_from_input']");
            //dictionary.Add("ngayXayRaDenNgay", "//input[@id='bodyForm:crimdate_to_input']");
            //dictionary.Add("ngaySinhDen", "//input[@id='bodyForm:birthdayto:input_input']");
            //dictionary.Add("chiTietNoiOHienTai", "//input[@id='bodyForm:addrname:input']");
            //dictionary.Add("thuLySo", "//input[@id='bodyForm:regisetnum']");
            //dictionary.Add("thuLyDenNgay", "//input[@id='bodyForm:indate_to_input']");
            //dictionary.Add("tenKiemSatVien", "//input[@id='bodyForm:inspectorname']");
            //dictionary.Add("ngayRaBanAnDenNgay", "//input[@id='bodyForm:centindate_to_input']");
            dictionary.Add("donViG4", "//input[@id='bodyForm:sppspcid5_input']");
            //dictionary.Add("timKiem", "//button[@id='bodyForm:btnSearch']");
            //dictionary.Add("capNhatThongTin", "//button[@id='bodyForm:j_idt265']");
            //dictionary.Add("chiTietVuAn", "//button[@id='bodyForm:j_idt267']");
            //G5
            //dictionary.Add("maVuAn", "//input[@id='bodyForm:casecode']");
            //dictionary.Add("quyetDinhKhoiToVuAnSo", "//input[@id='bodyForm:bengin_setnum']");
            //dictionary.Add("ngayQDKhoiToTuNgay", "//input[@id='bodyForm:begin_indatefrom_input']");
            //dictionary.Add("toiDanh", "//input[@id='bodyForm:casetxtLaw_input']");
            //dictionary.Add("tenBiCan", "//input[@id='bodyForm:fullname:input']");
            //dictionary.Add("tenVuAn", "//input[@id='bodyForm:casename']");
            //dictionary.Add("coQuanRaQuyetDinh", "//select[@id='bodyForm:sid_input']");
            //dictionary.Add("ngayQDKhoiToDenNgay", "//input[@id='bodyForm:begin_indateto_input']");
            //dictionary.Add("loaiToiPham", "//select[@id='bodyForm:casetype_input']");
            //dictionary.Add("ngayXayRaTuNgay", "//input[@id='bodyForm:crimdate_from_input']");
            // dictionary.Add("ngaySinhTu", "//input[@id='bodyForm:birthdayfrom:input_input']");
            //dictionary.Add("chiTietNoiDKHKTT", "//input[@id='bodyForm:locaname:input']");
            //dictionary.Add("tinhTrang", "//select[@id='bodyForm:regiclosed_input']");
            //dictionary.Add("thuLyTuNgay", "//input[@id='bodyForm:indate_from_input']");
            //dictionary.Add("banAnSo", "//input[@id='bodyForm:centsetnum']");
            //dictionary.Add("ngayRaBanAnTuNgay", "//input[@id='bodyForm:centindate_from_input']");
            //dictionary.Add("ngayXayRaDenNgay", "//input[@id='bodyForm:crimdate_to_input']");
            //dictionary.Add("ngaySinhDen", "//input[@id='bodyForm:birthdayto:input_input']");
            //dictionary.Add("chiTietNoiOHienTai", "//input[@id='bodyForm:addrname:input']");
            //dictionary.Add("thuLySo", "//input[@id='bodyForm:regisetnum']");
            //dictionary.Add("thuLyDenNgay", "//input[@id='bodyForm:indate_to_input']");
            //dictionary.Add("tenKiemSatVien", "//input[@id='bodyForm:inspectorname']");
            //dictionary.Add("ngayRaBanAnDenNgay", "//input[@id='bodyForm:centindate_to_input']");
            //dictionary.Add("donVi", "//input[@id='bodyForm:sppspcid5_input']");
            //dictionary.Add("timKiem", "//button[@id='bodyForm:btnSearch']");
            //dictionary.Add("capNhatThongTin", "//button[@id='bodyForm:j_idt265']");
            //dictionary.Add("chiTietVuAn", "//button[@id='bodyForm:j_idt267']");
            //G6
            //dictionary.Add("maVuAn", "//input[@id='bodyForm:txtCasecode']");
            //dictionary.Add("maThuLy", "//input[@id='bodyForm:txtRegicode']");
            dictionary.Add("maThuLy", "//*[@id='bodyForm:txtRegicode']");
            //dictionary.Add("banAnRaTuNgay", "//input[@id='bodyForm:crimdate_from_input']");
            dictionary.Add("banAnRaTuNgay", "//*[@id='bodyForm:crimdate_from']/button");
            //dictionary.Add("nguoiChapHanhAn", "//input[@id='bodyForm:txtFullname']");
            dictionary.Add("nguoiChapHanhAn", "//*[@id='bodyForm:txtFullname']");
            dictionary.Add("banAnRaTuNgayMot", "//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[3]/a");
            dictionary.Add("banAnRaDenNgayMot", "//*[@id='ui-datepicker-div']/table/tbody/tr[1]/td[3]/a");
            //dictionary.Add("trangThaiThuLy", "//select[@id='bodyForm:chkTrangThaiTL_input']");
            dictionary.Add("trangThaiThuLy", "//*[@id='bodyForm:chkTrangThaiTL']");
            dictionary.Add("daThuLy", "//*[@id='bodyForm:chkTrangThaiTL_panel']/div/ul/li[2]");
            dictionary.Add("chuaThuLy", "//*[@id='bodyForm:chkTrangThaiTL_panel']/div/ul/li[1]");
            //dictionary.Add("tenVuAn", "//input[@id='bodyForm:txtCasename']");
            //dictionary.Add("VKSNhapBanAn", "//input[@id='bodyForm:lbCboSPP_input']");
            dictionary.Add("VKSNhapBanAn", "//*[@id='bodyForm:lbCboSPP_input']");
            //dictionary.Add("banAnRaDenNgay", "//input[@id='bodyForm:crimdate_to_input']");
            dictionary.Add("banAnRaDenNgay", "//*[@id='bodyForm:crimdate_to']/button");
            //dictionary.Add("thuLy", "//input[@id='bodyForm:j_idt134:0']");
            dictionary.Add("thuLy", "//*[@id='bodyForm:j_idt134']/tbody/tr/td[1]/div/div[2]");
            //dictionary.Add("uyThac", "//input[@id='bodyForm:j_idt134:1']");
            dictionary.Add("uyThac", "//*[@id='bodyForm:j_idt134']/tbody/tr/td[3]/div/div[2]");
            dictionary.Add("trangThaithiHanhAn", "//select[@id='bodyForm:chkTrangThaiTHA_input']");
            //dictionary.Add("timKiem", "//button[@id='bodyForm:btnSearch']");
            //dictionary.Add("capNhatThongTin", "//button[@id='bodyForm:j_idt285']");
            //dictionary.Add("chiTietVuAn", "//button[@id='bodyForm:j_idt286']");
            dictionary.Add("uyThacButton", "//button[@id='bodyForm:j_idt279']");
            dictionary.Add("xoaUyThac", "//button[@id='bodyForm:btndeleteUT']");
            dictionary.Add("chiTietUyThac", "//button[@id='bodyForm:j_idt282']");
            //dictionary.Add("searchResult", "//tbody[@id='bodyForm:resultTable_data']/tr[1]");
            dictionary.Add("nhanUyThac", "//button[@id='bodyForm:j_idt280']");
            dictionary.Add("xoaTuChoi", "//button[@id='bodyForm:btndeleteUT']");
            dictionary.Add("suaNhanUyThac", "//button[@id='bodyForm:j_idt281']");
            dictionary.Add("xoaNhanUyThac", "//button[@id='bodyForm:btndeleteUT']");
            dictionary.Add("chonVKS", "//*[@id='bodyForm:lbCboSPP_panel']");

            dictionary.Add("addVuAn", "//*[@id='bodyForm:j_idt264']");
            
            
            //thu ly
            dictionary.Add("addTL", "//*[@id='bodyForm:j_idt207']");

            dictionary.Add("tlThuLySo", "//*[@id='bodyForm:r_setnum:input']");
            dictionary.Add("tlLoai", "//*[@id='bodyForm:r_transfer:input_label']");
            dictionary.Add("tlThoiHan", "//*[@id='bodyForm:r_indate:input_input']");
            dictionary.Add("tlThoiHanTuNgay", "//*[@id='bodyForm:r_fromdate:input_input']");
            dictionary.Add("tlThoiHanDenNgay", "//*[@id='bodyForm:r_todate:input_input']");
            dictionary.Add("tlAnDiem", "//*[@id='bodyForm:r_speci']/div[2]");
            dictionary.Add("tlLuatSu", "//*[@id='bodyForm:r_lawyer1']/div[2]");

            dictionary.Add("tlSave", "//*[@id='bodyForm:j_idt1619']");
            dictionary.Add("tlBack", "//*[@id='bodyForm:j_idt1620']");
            //thu ly end

            //ksv/dtv
            dictionary.Add("addKsv", "//*[@id='bodyForm:j_idt211']");
            dictionary.Add("ksvLaDieuTraVien0", "//*[@id='bodyForm:position:0']");
            dictionary.Add("ksvLaDieuTraVien1", "//*[@id='bodyForm:position:1']");
            dictionary.Add("ksvHoTen", "//*[@id='bodyForm:inspcodef_input']");
            dictionary.Add("ksvSoQuyetDinh", "//*[@id='bodyForm:setnum2']");
            dictionary.Add("ksvNgayPhanCong", "//*[@id='bodyForm:assigndate_input']");
            dictionary.Add("ksvNgayKetThuc", "//*[@id='bodyForm:finishdate_input']");

            dictionary.Add("saveKsv", "//*[@id='bodyForm:btnsavepropoassign']");
            dictionary.Add("backKsv", "//*[@id='bodyForm:j_idt2630']");
            //ksv/dtv end

            //thong tin bi can 
            dictionary.Add("addBc", "//*[@id='bodyForm:j_idt290']");
            dictionary.Add("bcSoQuyetDinh", "//*[@id='bodyForm:a_begin_setnum:input']");
            dictionary.Add("bcNgayRaQuyetDinh", "//*[@id='bodyForm:a_begin_indate:input_input']");
            dictionary.Add("bcTenCoQuan", "//*[@id='bodyForm:a_begin_pol:input_label']");
            //dictionary.Add("bcTenCoQuanCT", "//*[@id='bodyForm:a_begin_pol:input_filter']");
            dictionary.Add("bcTenCoQuanLI", "//*[@id='bodyForm:a_begin_pol:input_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("bcTenDonVi", "//*[@id='bodyForm:a_begin_police:input_input']");

            
            dictionary.Add("bcLaBiCanThuong", "//*[@id='bodyForm:a_firstacc:input_panel']/div[2]/ul/li[1]");            
            dictionary.Add("bcLaBiCanDauVu", "//*[@id='bodyForm:a_firstacc:input_panel']/div[2]/ul/li[2]");
            
            dictionary.Add("bcChonBiCanDauVu", "//*[@id='bodyForm:a_firstacc:input_label']");
            //dictionary.Add("bcBiCanDauVuCT", "//*[@id='bodyForm:a_firstacc:input_filter']");
            //dictionary.Add("bcBiCanDauVuLI", "//*[@id='bodyForm:a_firstacc:input_panel']/div[2]/ul/li[1]");
            dictionary.Add("bcHoTen", "//*[@id='bodyForm:a_fullname:input']");
            dictionary.Add("bcTenKhac", "//*[@id='bodyForm:a_othername:input']");
            dictionary.Add("bcNgaySinh", "//*[@id='bodyForm:a_birthday:input_input']");
            dictionary.Add("bcTenQuocTich", "//*[@id='bodyForm:a_counid_input']");
            dictionary.Add("bcTenDanToc", "//*[@id='bodyForm:a_natiid_label']");
            //dictionary.Add("bcTenDanTocCT", "//*[@id='bodyForm:a_natiid_filter']");
            dictionary.Add("bcTenDanTocLI", "//*[@id='bodyForm:a_natiid_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("bcGioiTinh", "//*[@id='bodyForm:a_sex_label']");
            //dictionary.Add("bcGioiTinhCT", "//*[@id='bodyForm:a_sex_filter']"); 
            dictionary.Add("bcGioiTinhNam", " //*[@id='bodyForm:a_sex_panel']/div[2]/ul/li[1]");
            dictionary.Add("bcGioiTinhNu", " //*[@id='bodyForm:a_sex_panel']/div[2]/ul/li[2]");
            dictionary.Add("bcGioiTinhKhongXD", " //*[@id='bodyForm:a_sex_panel']/div[2]/ul/li[3]");

            dictionary.Add("bcTenTonGiao", "//*[@id='bodyForm:a_religion_label']");
            //dictionary.Add("bcTenTonGiaoCT", "//*[@id='bodyForm:a_religion_filter']");
            dictionary.Add("bcTenTonGiaoLI", " //*[@id='bodyForm:a_religion_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("bcTenHocVan", "//*[@id='bodyForm:a_knowledge:input_label']"); 
            //dictionary.Add("bcTenHocVanCT", "//*[@id='bodyForm:a_knowledge:input_filter']");
            dictionary.Add("bcTenHocVanLI", " //*[@id='bodyForm:a_knowledge:input_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("bcHKTT", "//*[@id='bodyForm:a_locaid:input_input']");
            dictionary.Add("bcNoiOHienTai", "//*[@id='bodyForm:a_addrname:input']");
            dictionary.Add("bcTenNgheNghiep", "//*[@id='bodyForm:a_occuid:input_label']");
            //dictionary.Add("bcTenNgheNghiepCT", "//*[@id='bodyForm:a_occuid:input_filter']");
            dictionary.Add("bcTenNgheNghiepLI", "//*[@id='bodyForm:a_occuid:input_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("bcTenChucVu", "//*[@id='bodyForm:a_office:input_label']");
            //dictionary.Add("bcChucVuCT", "//*[@id='bodyForm:a_office:input_filter']");
            dictionary.Add("bcTenChucVuLI", "//*[@id='bodyForm:a_office:input_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("bcTenDangVien", "//*[@id='bodyForm:a_partyid_label']");
            //dictionary.Add("bcDangVienCT", "//*[@id='bodyForm:a_partyid_filter']");
            dictionary.Add("bcTenDangVienLI", "//*[@id='bodyForm:a_partyid_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("bcSoTienAn", "//*[@id='bodyForm:a_conviction_input']");
            dictionary.Add("bcSoTienSu", "//*[@id='bodyForm:a_offence_input']");

            
            dictionary.Add("bcLaNgheNghiepKhongOnDinh", "//*[@id='bodyForm:a_unoccupation']/div[2]");
            dictionary.Add("bcLaLuuManh", "//*[@id='bodyForm:a_occudishonest']/div[2]");
            dictionary.Add("bcLaCanBoCongNhanVienChuc", "//*[@id='bodyForm:a_occuofficer']/div[2]");
            dictionary.Add("bcLaNghienHut", "//*[@id='bodyForm:a_heroin']/div[2]");
            dictionary.Add("bcLaTapTrungCaiTaoTuHinhSu", "//*[@id='bodyForm:a_occureeducate']/div[2]");
            dictionary.Add("bcLaHocSinhTruongChuyenNghiep", "//*[@id='bodyForm:a_occustudent']/div[2]");
            dictionary.Add("bcLaHanhNgheTonGiao", "//*[@id='bodyForm:a_occuteler']/div[2]");
            dictionary.Add("bcLaThuongBinhBoDoiPhucVien", "//*[@id='bodyForm:a_occusoldier']/div[2]");
            dictionary.Add("bcLaDoiTuongLangThang", "//*[@id='bodyForm:a_wander']/div[2]");
            dictionary.Add("bcLaCoNguoiBaoChua", "//*[@id='bodyForm:a_baochua']/div[2]");
            
            dictionary.Add("bcGhiLai", "//*[@id='bodyForm:j_idt1432']");
            dictionary.Add("bcBack", "//*[@id='bodyForm:j_idt1434']");
            //thong tin bi can end

            // qd bi can

            dictionary.Add("bcEdit", "//*[@id='bodyForm:accuTable:0:j_idt276']");
            dictionary.Add("addQdBc", "//*[@id='bodyForm:decisionTable:j_idt1470']");
            dictionary.Add("qdBiCan", "//*[@id='bodyForm:j_idt289']");
            dictionary.Add("qdBcTenBiCan", "//*[@id='bodyForm:accucode:input_label']");
            dictionary.Add("qdBcTenBiCanCT", "//*[@id='bodyForm:accucode:input_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            
            dictionary.Add("qdBcSoQuyetDinh", "//*[@id='bodyForm:setnum:input']");
            dictionary.Add("qdBcNgayRaQuyetDinh", "//*[@id='bodyForm:indate:input_input']");
            dictionary.Add("qdBcTenCoQuan", "//*[@id='bodyForm:polid:input_label']");
            dictionary.Add("qdBcTenCoQuanCT", "//*[@id='bodyForm:polid:input_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("qdBcTenDonVi", "//*[@id='bodyForm:sppid:input_input']");
            dictionary.Add("qdBcNoiDung", "//*[@id='bodyForm:content']");
            
            dictionary.Add("qdBcTenNguoiKy", "//*[@id='bodyForm:d_signname_input']");
            dictionary.Add("qdBcTenChucVi", "//*[@id='bodyForm:d_signoffice_input']");
            dictionary.Add("qdBcTenloai", "//*[@id='bodyForm:deciid:input']");
            dictionary.Add("qdBcTenloaiCT", "//*[@id='bodyForm:deciid:input_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("qdBcSave", "//*[@id='bodyForm:j_idt1686']");
            dictionary.Add("qdBcBack", "//*[@id='bodyForm:j_idt1688']");
            // qd bi can end

            //ket luan dieu tra
            dictionary.Add("addKldt","//*[@id='bodyForm:j_idt327']");
            dictionary.Add("klSoKetLuanDieuTra","//*[@id='bodyForm:centsetnum']");
            dictionary.Add("klNgayRaKetLuan","//*[@id='bodyForm:centindate_input']");
            dictionary.Add("klNgayHieuLuc","//*[@id='bodyForm:centactdate_input']");
            dictionary.Add("klNguoiKy","//*[@id='bodyForm:centsignname_input']");
            dictionary.Add("klChucVu","//*[@id='bodyForm:centsignoffice_input']");
            dictionary.Add("klNoiDung","//*[@id='bodyForm:centcontent']");
            dictionary.Add("klYKienCuaVKS","//*[@id='bodyForm:centremark']");
            dictionary.Add("klGhiLai","//*[@id='bodyForm:j_idt2040']");
            dictionary.Add("klBack", "//*[@id='bodyForm:j_idt2041']");
            //end 

            // GiaoNhanHoSo
            //*[@id="bodyForm:ssp_changeid:1"]
            dictionary.Add("AddGnhs","//*[@id='bodyForm:j_idt365']");
            dictionary.Add("AddGnhsTt", "//*[@id='bodyForm:j_idt440']");
            //*[@id="bodyForm:j_idt365"]
            dictionary.Add("hsTaVks", "//*[@id='bodyForm:ssp_changeid']/tbody/tr/td[4]/label");

            dictionary.Add("hsNgayGiaoNhan", "//*[@id='bodyForm:ssp_transdate_input']");
            dictionary.Add("hsNguoiGiao", "//*[@id='bodyForm:ssp_sender1']");
            dictionary.Add("hsNguoiNhan", "//*[@id='bodyForm:ssp_receipter1']");
            dictionary.Add("hsDonViNhan", "//*[@id='bodyForm:ssp_polname_input']");
            dictionary.Add("hsToaAn", "//*[@id='bodyForm:ssp_spcname_input']");
            //*[@id="bodyForm:ssp_spcname_input"]
            dictionary.Add("hsGhiLai", "//*[@id='bodyForm:j_idt1289']");
            dictionary.Add("hsBack", "//*[@id='bodyForm:j_idt1290']");
            // dictionary.Add("hs","");
            // end

            //quyet dinh vu an 
            dictionary.Add("AddQdva","//*[@id='bodyForm:j_idt295']");
            dictionary.Add("qdvaTenQuyetDinh","//*[@id='bodyForm:cboDeciid_label']");
            dictionary.Add("qdvaTenQuyetDinhCT", "//*[@id='bodyForm:cboDeciid_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("qdvaTenCoQuan","//*[@id='bodyForm:cboDonViRaQD_label']");
            dictionary.Add("qdvaTenCoQuanCT", "//*[@id='bodyForm:cboDonViRaQD_panel']/div/ul/li[contains(text(),'aaa')]");
            dictionary.Add("qdvaTenDonVi","//*[@id='bodyForm:lbCboSPP_input']");
            dictionary.Add("qdvaSoQuyetDinh","//*[@id='bodyForm:setnum1']");
            dictionary.Add("qdvaNgayRaQuyetDinh","//*[@id='bodyForm:indate1_input']");
            dictionary.Add("qdvaHieuLucTuNgay","//*[@id='bodyForm:fromdate1_input']");
            dictionary.Add("qdvaHieuLucDenNgay","//*[@id='bodyForm:todate1_input']");
            dictionary.Add("qdvaThoiHanThucTe","//*[@id='bodyForm:txtNumday_input']");
            dictionary.Add("qdvaTenNguoiKy","//*[@id='bodyForm:inspcode_input']");
            dictionary.Add("qdvaTenChucVu","//*[@id='bodyForm:signoffice1_input']");
            // dictionary.Add("qdva","");
            //end

            //caotrang
            //*[@id='bodyForm:btncentG2addnew']
            dictionary.Add("ctAdd", "//*[@id='bodyForm:btncentG2addnew']");
            dictionary.Add("ctBanCaoTrangSo", "//*[@id='bodyForm:centsetnum']");
            dictionary.Add("ctNgayVksRaCaoTrang", "//*[@id='bodyForm:centindate_input']");
            dictionary.Add("ctNgayHieuLuc", "//*[@id='bodyForm:centactdate_input']");

            dictionary.Add("ctNoiDung", "//*[@id='bodyForm:centcontent']");
            dictionary.Add("ctNguoiKy", "//*[@id='bodyForm:centsignname_input']");
            dictionary.Add("ctChucVu", "//*[@id='bodyForm:centsignoffice_input']");

            dictionary.Add("ctYKien", "//*[@id='bodyForm:centremark']");
            dictionary.Add("ctSave", "//*[@id='bodyForm:j_idt2040']");//*[@id="bodyForm:j_idt2040"]
            dictionary.Add("ctBack", "//*[@id='bodyForm:j_idt2041']");

            //caotrang end
            
            dictionary.Add("dlThem", "//*[@id='bodyForm:l_lawcodeTable:j_idt1407']");
            dictionary.Add("dlChonBoLuat", "//*[@id='bodyForm:l_codename:input_label']");
            //dictionary.Add("dlDienBoLuat", "//*[@id='bodyForm:l_codename:input_filter']");
            dictionary.Add("dlClickBoLuat", "//*[@id='bodyForm:l_codename:input_panel']/div[2]/ul/li[contains(text(),'aaa')]");
            dictionary.Add("dlDieu", "//*[@id='bodyForm:l_lawid']");
            dictionary.Add("dlKhoan", "//*[@id='bodyForm:l_item']");
            dictionary.Add("dlDiem", "//*[@id='bodyForm:l_point']");
            dictionary.Add("dlTimKiem", "//*[@id='bodyForm:j_idt2782']");
            dictionary.Add("dlThaoTac", "//*[@id='bodyForm:lawTable_data']/tr/td[6]/div/a");

            //*[@id='bodyForm:l_item']
            //*[@id='bodyForm:l_point']
            //*[@id='bodyForm:j_idt2782']   tim kiem
            //*[@id="bodyForm:lawTable:0:j_idt2802"]

            // thu ly xet xu so tham
            dictionary.Add("tlxxSoThuLy", "//*[@id='bodyForm:r_setnum:input']");
            dictionary.Add("tlxxNgayThuLy", "//*[@id='bodyForm:r_indate:input_input']");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using AutomationQlahsVksndtcWindowsFormsApp.Resources;


namespace AutomationQlahsVksndtcWindowsFormsApp
{
    class HsUpdateInfoSearchPage : Page
    {
        Button themMoiButton;
        public HsUpdateInfoSearchPage()
        {
            url = "http://qlahs.vksndtc.gov.vn/QLA/faces/hs/UpdateInfo/search.jsf";
            themMoiButton = new Button("thêm mới",xpath.D["addVuAn"],"");
        }

        public void ThemMoi()
        {
            Click(themMoiButton);
        }
    }
}

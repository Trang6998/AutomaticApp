using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections;

namespace AutomationQlahsVksndtcWindowsFormsApp
{
    class Page
    {
        public string url;
        public ChromeDriver driver;
        public Xpath xpath;
        public static Queue qq = new Queue();
        public IWebElement FindElementByXPath(Control c)
        {
            File.AppendAllText(System.Windows.Forms.Application.StartupPath +
                "/log.txt", (++actionCount) + " Find " + " " + c.Name + Environment.NewLine);
            qq.Enqueue((++actionCount) + " Find " + " " + c.Name + Environment.NewLine);
            try
            {
                driver.FindElementByXPath(c.Xpath);

            }
            catch (Exception e)
            {
                File.AppendAllText(System.Windows.Forms.Application.StartupPath +
                "/log.txt", (++actionCount) + " not found " + " " + c.Name + Environment.NewLine);
                qq.Enqueue((++actionCount) + " Error " + " " + c.Name + Environment.NewLine);

            }
            return driver.FindElementByXPath(c.Xpath);
        }
        public IWebElement FindElementById(Control c)
        {
            return driver.FindElementById(c.Id);
        }
        public void SendKeys(string text, Control c)
        {
            try
            {
                File.AppendAllText(System.Windows.Forms.Application.StartupPath + "/log.txt", (++actionCount) + " SendKeys " + text + " " + c.Name + Environment.NewLine);
                Sleep(); Sleep();
                SendKeysByXpath(text, c);
                qq.Enqueue((++actionCount) + " SendKeys " + text + " " + c.Name + Environment.NewLine);
            }
            catch (Exception e)
            {
                File.AppendAllText(System.Windows.Forms.Application.StartupPath +
                "/log.txt", (++actionCount) + " not found " + text + " " + c.Name + Environment.NewLine);
                qq.Enqueue((++actionCount) + " Error " + " " + c.Name + Environment.NewLine);
            }

        }
        public void SendKeysById(string text, Control c)
        {
            //FindElementById(c).Clear();
            FindElementById(c).SendKeys(text);
        }
        public void SendKeysByXpath(string text, Control c)
        {
            //FindElementByXPath(c).Clear();
            FindElementByXPath(c).SendKeys(text);
        }
        public void Click(Control c)
        {
            try
            {

                File.AppendAllText(
                System.Windows.Forms.Application.StartupPath + "/log.txt", (++actionCount) + " Click " + c.Name + Environment.NewLine);
                Sleep(); Sleep();
                ClickByXPath(c);
                qq.Enqueue((++actionCount) + " Click " + c.Name + Environment.NewLine);
            }
            catch (Exception e)
            {
                string g = c.Name;
                g = c.Xpath;
            }

        }

        //public void Select(string type, Control c,string value)
        //{
        //    var education = FindElementByXPath(c);
        //    var selectElement = new SelectElement(education);
        //    if(type=="value")
        //        selectElement.SelectByValue(value);
        //    if (type == "text")// select by 
        //        selectElement.SelectByText(value);
        //}
        public void jsClick(Control c)
        {
            var element = FindElementByXPath(c);
            driver.ExecuteScript("return arguments[0].click();", element);
        }
        public void ClickById(Control c)
        {
            FindElementById(c).Click();
        }
        public void ClickByXPath(Control c)
        {
            FindElementByXPath(c).Click();
        }

        public void Clear(Control c)
        {
            try
            {
                Console.WriteLine("Clear(Control c)");
                Console.WriteLine(c);
                Sleep();
                ClearByXPath(c);
            }
            catch (Exception e)
            {
                string g = c.Name;
                g = c.Xpath;
            }

        }
        public void ClearByID(Control c)
        {
            FindElementById(c).Clear();
        }
        public void ClearByXPath(Control c)
        {
            FindElementByXPath(c).Clear();
        }


        public void Come()
        {
            Sleep();
            driver.Navigate().GoToUrl(url);
        }

        public TextBox maVuAn, tenVuAn, tenBiCan, toiDanh, QDKhoiToVuAnSo, noiDKHKTT, noiOHienTai, tenKSVien, thuLySo;
        public Button timKiem, doiGiaoDien;
        public static int actionCount = 0;
        public Page()
        {
            //actionCount = 0;
            xpath = new Xpath();

            maVuAn = new TextBox("mã vụ án", xpath.D["maVuAn"], "");
            tenVuAn = new TextBox("tên vụ án", xpath.D["tenVuAn"], "");
            tenBiCan = new TextBox("tên bị can", xpath.D["inputTenBiCan"], "");
            toiDanh = new TextBox("tội danh", xpath.D["inputToiDanh"], "");
            QDKhoiToVuAnSo = new TextBox("tội danh", xpath.D["inputToiDanh"], "");
            noiDKHKTT = new TextBox("nơi đk hộ khẩu thường trú", xpath.D["noiDkhktt"], "");
            noiOHienTai = new TextBox("ct nơi ở hiện tại", xpath.D["chiTietNoiOHienTai"], "");
            tenKSVien = new TextBox("tên KSV", xpath.D["tenKsVien"], "");
            thuLySo = new TextBox("thụ lý số", xpath.D["thuLySo"], "");

            timKiem = new Button("tìm kiếm", xpath.D["timKiem"], "");
            doiGiaoDien = new Button();
        }

        public void Sleep()
        {
            Console.WriteLine("sleep");
            Thread.Sleep(1000);
        }

        public String toSee(By iw)
        {
            driver.FindElement(iw);
            return iw.ToString();
        }
    }
}

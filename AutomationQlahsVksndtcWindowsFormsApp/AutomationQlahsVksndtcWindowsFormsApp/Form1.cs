using AutomationQlahsVksndtcWindowsFormsApp.PageObjects;
using AutomationQlahsVksndtcWindowsFormsApp.Resources;
using AutomationQlahsVksndtcWindowsFormsApp.TestCases;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationQlahsVksndtcWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBox1.SelectedItem = null;
            //comboBox1.SelectedIndex = 0;
            comboBox1.Text = "Kiểm sát Điều tra - Truy tố";
            string g = Application.ExecutablePath;
            g = Application.StartupPath;
            t = comboBox1.Text;
            textBox1MaVuAn.Text = "1066";
            textBox1Username.Text = "khanh";
            textBox2Password.Text = "123456";

        }
        String t;
        private void Button2Chay_Click(object sender, EventArgs e)
        {
            button2Chay.Text = "Run";
            Task task01 = Task.Factory.StartNew(() => controller());
            //string maVuAn = textBox1MaVuAn.Text;
            



            //ChuyenAnClass.Instance().Go();

            //NhanAnClass.Instance().Go();
            //G3KiemTraXetXuSoThamClass.Instance.Go();
            //G4KiemSatXetXuPhucThamClass.Instance.Go();
            //G5KiemSatXetXuGDTTTClass.Instance.Go();
            //TachVuAnClass.Instance().Go();
            //G6Class.Instance().Go();
        }
        private void controller()
        {
            
            if (t.Equals("Nhận án"))
            {
                NhanAnClass.Instance().Go();
            }
            else if (t.Equals("Chuyển án"))
            {
                ChuyenAnClass.Instance().Go();
            }
            else if (t.Equals("Tách vụ án"))
            {
                TachVuAnClass.Instance().Go();
            }
            else if (t.Equals("Kiểm sát Điều tra - Truy tố"))
            {
                // KiemSatDieuTraTruyToClass.Instance(textBox1MaVuAn.Text).Go();
                TaoMoiVuAnPopUpClass.Instance(
                    textBox1MaVuAn.Text,
                    textBox1Username.Text,
                    textBox2Password.Text
                    ).Go();
            }
            else if (t.Equals("Kiểm sát xét xử sơ thẩm"))
            {
                //G3KiemTraXetXuSoThamClass.Instance.Go();
            }
            else if (t.Equals("Kiểm sát xét xử phúc thẩm"))
            {
                G4KiemSatXetXuPhucThamClass.Instance.Go();
            }
            else if (t.Equals("Kiểm sát xét xử GĐT-TT"))
            {
                G5KiemSatXetXuGDTTTClass.Instance.Go();
            }
            else if (t.Equals("Nhập vụ án"))
            {
                //TaoMoiVuAnPopUpClass.Instance(textBox1MaVuAn.Text).Go();
            }
            else if (t.Equals("Thêm Thụ Lý"))
            {
                ThuLyPopUpClass.Instance(textBox1MaVuAn.Text).Go();
            }
            else
            {
                Console.WriteLine("Choose Item");
                richTextBox1.SelectedText = "Choose Item! ";
            }

             
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            t = comboBox1.Text;
        }
         

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += Page.qq.Dequeue().ToString();

            }
            catch (Exception)
            {

            }
            
            
        }

        private void Button1Nap_Click(object sender, EventArgs e)
        {
            JsonDataFromWs.Instance(textBox1MaVuAn.Text);
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }
    }
}

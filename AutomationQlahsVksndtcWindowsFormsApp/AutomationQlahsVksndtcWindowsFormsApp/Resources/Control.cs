using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationQlahsVksndtcWindowsFormsApp.Resources
{
    class Control
    {

        IWebElement webElement;
        public string Name { get; set; }
        public string Xpath { get; set; }
        public string Id { get; set; }

        public bool Visible()
        {
            return true;
        }
        public Control() { }
        public Control(string Name, string Xpath, string Id)
        {
            this.Name = Name;
            this.Xpath = Xpath;
            this.Id = Id;
        }

        public Control(Dictionary<string, string> dic, string keyIsName)
        {
            this.Name = keyIsName;
            this.Xpath = dic[keyIsName];
        }



    }


    class TextBox : Control
    {
        public TextBox()
        {
        }
        public TextBox(string Name, string Xpath, string Id) : base(Name, Xpath, Id)
        {

        }




    }
    class Button : Control
    {
        public Button() { }
        public Button(string Name, string Xpath, string Id) : base(Name, Xpath, Id)
        {

        }


    }
    class Label : Control { }
    class ComboBox : Control
    {
        public ComboBox() { }
        public ComboBox(string Name, string Xpath, string Id) : base(Name, Xpath, Id)
        {

        }
    }
    class CheckBox : Control {
        public CheckBox() { }
        public CheckBox(string Name, string Xpath, string Id) : base(Name, Xpath, Id)
        {

        }
    }
    class DateTimePicker : Control
    {
        public DateTimePicker() { }
        public DateTimePicker(string Name, string Xpath, string Id) : base(Name, Xpath, Id)
        {

        }

    }

    class Choice : Control
    {
        public Choice() { }
        public Choice(string Name, string Xpath, string Id) : base(Name, Xpath, Id)
        {

        }
    }

    class Other : Control
    {
        public Other() { }
        public Other(string Name, string Xpath, string Id) : base(Name, Xpath, Id)
        {

        }

    }
}

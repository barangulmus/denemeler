using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace chatBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://chat.openai.com/");
            System.Threading.Thread.Sleep(20000);
            IWebElement text = driver.FindElement(By.CssSelector("textarea[id='prompt-textarea']"));
            text.Click();
            System.Threading.Thread.Sleep(1000);
            Clipboard.SetText("Bu bir denemedir");
            SendKeys.Send("^V");
            SendKeys.Send("{ENTER}");
        }
    }
}

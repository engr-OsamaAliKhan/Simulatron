using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System.IO;
using AutoIt;
using OpenQA.Selenium.Interactions;
using WindowsInput.Native;
using WindowsInput;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data.SqlClient;

namespace Sumilatron
{
    
    public partial class Form1 : Form
    {
        

        OracleConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        private static void ClearTextByElement(IWebElement element)
        {
            int existingCount = element.Text.Length;
            for (int i = 0; i < existingCount; i++)
            { element.Clear(); }
        }
        public static void VerifyTextonTextBox(IWebElement element, string Text)
        {


            if (element.Text != Text)
            {
                ClearTextByElement(element);
                element.SendKeys(Text);

            }
        }
        public static void Close_all(IWebDriver driver) {

            driver.Dispose();
        }
        public static void Click(IWebDriver driver, IWebElement element)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(40.00));

            //  IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40.00));
            // wait.IgnoreExceptionTypes(new[] { typeof(StaleElementReferenceException), typeof(NoSuchElementException) });

            try
            {
                //   wait.Until(driver2 =>

                // element.Displayed == true);
            }
            catch { }
            Actions Ac = new Actions(driver);
            Ac.Click(element).Build().Perform();
            Thread.Sleep(1000);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10.00));

        }

        public static void SelectFromDropDown(string ApplicationName, string ComboBox, string Value)
        {
            AutoItX.WinActivate(ApplicationName, "");

            AutoItX.ControlCommand(ApplicationName, "", ComboBox, "SelectString", Value);

        }
        String sim1 = "";
        String sim2 = "";
        String sim3 = "";
        String sim4 = "";
        String sim5 = "";
        String sim6 = "";
        String exePath = "D:/Simulatron/ABLHOST/Simulatrix.exe";
        String ubp = "D:/Simulatron/UBPS SIMULATOR/UBPSSIM.exe";

  

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void heading_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ubpssim_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            String ipaddr = GetLocalIPAddress();
            InputSimulator sim = new InputSimulator();
            ipadd.Text = ipaddr;
            
            DesktopOptions options = new DesktopOptions();

            if (t24c1.Checked == true)
            {
                sim1 = "T24C1 Checked ";
                log.Text = sim1;


               
                String updtip = $"update TBLNETWORK set COMMSADDRESS='{ipaddr}' where NETNAME like 'T24C1' or NETNAME like 'T24C2'or NETNAME like 'T24C3'or NETNAME like 'T24C4'or NETNAME like 'T24C5'or NETNAME like 'UBPS-7777' ";
                OracleCommand cmd2 = new OracleCommand(updtip, conn);
                OracleDataReader rd2 = cmd2.ExecuteReader();
                String hp = "select COMMS_PORT from TBLNETWORK where NETNAME like 'T24C1'";
                OracleCommand cmd1 = new OracleCommand(hp, conn); 
                OracleDataReader rd1 = cmd1.ExecuteReader();
                rd1.Read();
                string port = rd1.GetString(0);

                options.ApplicationPath = exePath;
                WiniumDriver driver = new WiniumDriver(@"D:\Simulatron\Driver\Winium.Desktop.Driver", options);

                Thread.Sleep(2000);
          



                AutoItX.WinActivate("Log-In");
                driver.FindElement(By.Name("Admin 1 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn1").Click();
                driver.FindElement(By.Name("Admin 2 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn2").Click();
                driver.FindElementById("Close").Click();

                AutoItX.WinActivate("Simulatrix -- HOST PHX8583 [HBL]");
                Thread.Sleep(1000);
                IWebElement wind=driver.FindElementByName("Simulatrix -- HOST PHX8583 [HBL]");
                IWebElement toolbr = wind.FindElement(By.Id("MainToolStrip"));
               // toolbr.Click();
                IWebElement box = toolbr.FindElement(By.ClassName("WindowsForms10.EDIT.app.0.378734a"));
                box.Click();
                Thread.Sleep(500);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "{TAB}");
                Thread.Sleep(500);
                AutoItX.Send(port);
              
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "!{c}");







            }
            if (t24c2.Checked == true)
            {

                sim2 = "T24C2 Checked ";
                log.Text = sim1+sim2;
                String hp = "select COMMS_PORT from TBLNETWORK where NETNAME like 'T24C2'";
                OracleCommand cmd1 = new OracleCommand(hp, conn);
                OracleDataReader rd1 = cmd1.ExecuteReader();
                rd1.Read();
                string port = rd1.GetString(0);

                options.ApplicationPath = exePath;
                WiniumDriver driver = new WiniumDriver(@"D:\Simulatron\Driver\Winium.Desktop.Driver", options);

                Thread.Sleep(3000);

                AutoItX.WinActivate("Log-In");
                driver.FindElement(By.Name("Admin 1 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn1").Click();
                driver.FindElement(By.Name("Admin 2 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn2").Click();
                driver.FindElementById("Close").Click();
                AutoItX.WinActivate("Simulatrix -- HOST PHX8583 [HBL]");
                Thread.Sleep(2000);
                IWebElement wind = driver.FindElementByName("Simulatrix -- HOST PHX8583 [HBL]");
                IWebElement toolbr = wind.FindElement(By.Id("MainToolStrip"));
                // toolbr.Click();
                IWebElement box = toolbr.FindElement(By.ClassName("WindowsForms10.EDIT.app.0.378734a"));
                box.Click();
                Thread.Sleep(1000);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "{TAB}");
                Thread.Sleep(1000);
                AutoItX.Send(port);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "!{c}");

              




            }
            if(t24c5.Checked == true)
            {
                sim3 = "T24C5 Checked ";
                log.Text = sim1+ sim2+sim3;
                String hp = "select COMMS_PORT from TBLNETWORK where NETNAME like 'T24C5'";
                OracleCommand cmd1 = new OracleCommand(hp, conn);
                OracleDataReader rd1 = cmd1.ExecuteReader();
                rd1.Read();
                string port = rd1.GetString(0);

                options.ApplicationPath = exePath;
                WiniumDriver driver = new WiniumDriver(@"D:\Simulatron\Driver\Winium.Desktop.Driver", options);

                Thread.Sleep(3000);

                AutoItX.WinActivate("Log-In");
                driver.FindElement(By.Name("Admin 1 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn1").Click();
                driver.FindElement(By.Name("Admin 2 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn2").Click();
                driver.FindElementById("Close").Click();
                AutoItX.WinActivate("Simulatrix -- HOST PHX8583 [HBL]");
                Thread.Sleep(2000);
                IWebElement wind = driver.FindElementByName("Simulatrix -- HOST PHX8583 [HBL]");
                IWebElement toolbr = wind.FindElement(By.Id("MainToolStrip"));
                // toolbr.Click();
                IWebElement box = toolbr.FindElement(By.ClassName("WindowsForms10.EDIT.app.0.378734a"));
                box.Click();
                Thread.Sleep(1000);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "{TAB}");
                Thread.Sleep(1000);
                AutoItX.Send(port);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "!{c}");



            }
            if (t24c4.Checked == true)
            {
                sim4 = "T24C4 Checked ";
                log.Text = sim1+ sim2 + sim3+sim4;
                String hp = "select COMMS_PORT from TBLNETWORK where NETNAME like 'T24C4'";
                OracleCommand cmd1 = new OracleCommand(hp, conn);
                OracleDataReader rd1 = cmd1.ExecuteReader();
                rd1.Read();
                string port = rd1.GetString(0);

                options.ApplicationPath = exePath;
                WiniumDriver driver = new WiniumDriver(@"D:\Simulatron\Driver\Winium.Desktop.Driver", options);

                Thread.Sleep(3000);

                AutoItX.WinActivate("Log-In");
                driver.FindElement(By.Name("Admin 1 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn1").Click();
                driver.FindElement(By.Name("Admin 2 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn2").Click();
                driver.FindElementById("Close").Click();
                AutoItX.WinActivate("Simulatrix -- HOST PHX8583 [HBL]");
                Thread.Sleep(2000);
                IWebElement wind = driver.FindElementByName("Simulatrix -- HOST PHX8583 [HBL]");
                IWebElement toolbr = wind.FindElement(By.Id("MainToolStrip"));
                // toolbr.Click();
                IWebElement box = toolbr.FindElement(By.ClassName("WindowsForms10.EDIT.app.0.378734a"));
                box.Click();
                Thread.Sleep(1000);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "{TAB}");
                Thread.Sleep(1000);
                AutoItX.Send(port);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "!{c}");


            }
            if (t24c3.Checked == true)
            {
                sim5 = "BB Host Checked ";
                log.Text = sim1+ sim2 + sim3 + sim4+sim5;
                String hp = "select COMMS_PORT from TBLNETWORK where NETNAME like 'T24C3'";
                OracleCommand cmd1 = new OracleCommand(hp, conn);
                OracleDataReader rd1 = cmd1.ExecuteReader();
                rd1.Read();
                string port = rd1.GetString(0);

                options.ApplicationPath = exePath;
                WiniumDriver driver = new WiniumDriver(@"D:\Simulatron\Driver\Winium.Desktop.Driver", options);

                Thread.Sleep(3000);

                AutoItX.WinActivate("Log-In");
                driver.FindElement(By.Name("Admin 1 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn1").Click();
                driver.FindElement(By.Name("Admin 2 Password")).SendKeys("tpstps123123");
                driver.FindElementById("LogIn2").Click();
                driver.FindElementById("Close").Click();
                AutoItX.WinActivate("Simulatrix -- HOST PHX8583 [HBL]");
                Thread.Sleep(2000);
                IWebElement wind = driver.FindElementByName("Simulatrix -- HOST PHX8583 [HBL]");
                IWebElement toolbr = wind.FindElement(By.Id("MainToolStrip"));
                // toolbr.Click();
                IWebElement box = toolbr.FindElement(By.ClassName("WindowsForms10.EDIT.app.0.378734a"));
                box.Click();
                Thread.Sleep(1000);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "{TAB}");
                Thread.Sleep(1000);
                AutoItX.Send(port);
                AutoItX.ControlSend("Simulatrix -- HOST PHX8583 [HBL]", "", "", "!{c}");


            }
            if (ubpssim.Checked == true)
            {
                sim6 = "UBPS Checked ";
                log.Text = sim1+sim2+sim3+sim4+sim5+sim6;
                String hp = "select COMMS_PORT from TBLNETWORK where NETNAME like 'UBPS-7777'";
                OracleCommand cmd1 = new OracleCommand(hp, conn);
                OracleDataReader rd1 = cmd1.ExecuteReader();
                rd1.Read();
                string port = rd1.GetString(0);

                options.ApplicationPath = ubp;

                WiniumDriver driver = new WiniumDriver(@"D:\Simulatron\Driver\Winium.Desktop.Driver", options);

                Thread.Sleep(1000);
                IWebElement sts = driver.FindElementByName("Bill Status");
                sts.FindElement(By.Name("UnPaid Bill")).Click();

                var grpCs=driver.FindElementByName("Connection Settings");
                grpCs.FindElement(By.Id("textBoxLP")).SendKeys(port);

                grpCs.FindElement(By.Name("Start")).Click();


            }
            conn.Close();
            
        }

        private void t24c2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void t24c3_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void t24c4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void bbhost_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void log_Click(object sender, EventArgs e)
        {

        }

        private void ipadd_Click(object sender, EventArgs e)
        {
            String ipaddr = GetLocalIPAddress();
            
        }

        private void selectall_Click(object sender, EventArgs e)
        {
            t24c1.Checked = true;
            t24c2.Checked = true;
            t24c5.Checked = true;
            t24c4.Checked = true;
            t24c3.Checked = true;
            ubpssim.Checked = true;
        }

        private void deselectall_Click(object sender, EventArgs e)
        {
            t24c1.Checked = false;
            t24c2.Checked = false;
            t24c5.Checked = false;
            t24c4.Checked = false;
            t24c3.Checked = false;
            ubpssim.Checked = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

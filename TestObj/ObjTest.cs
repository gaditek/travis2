using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTest
{
    [TestFixture]
    public class ObjTest
    {
        private AndroidDriver<AppiumWebElement> driver;

        [SetUp]
        protected void SetUp()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();

            capabilities.SetCapability("deviceName", "Nexus 5");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("app", @"C:\Users\Administrator\AppData\Roaming\Skype\My Skype Received Files\purevpn-release.apk");
            capabilities.SetCapability("platformVersion", "4.4");
            capabilities.SetCapability("appPackage", "com.gaditek.purevpnics");
            // capabilities.SetCapability("appPackage", "com.gaditek.purevpnics.main.SplashActivity");
            // capabilities.SetCapability("appActivity", "com.gaditek.purevpnics.main.MainActivity");
            capabilities.SetCapability("appActivity", "com.gaditek.purevpnics.main.AuthActivity");
            //   WebDriverWait wait = new WebDriverWait(driver, 10);


            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:8082/wd/hub"), capabilities);
        }

        [TearDown]
        public void AfterAll()
        {
            driver.Quit();
        }

        [Test]
        public void login()
        {
            int subTestNo = 1;
            StringBuilder output = new StringBuilder();
            ////     WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("signIn")).Click();
            driver.FindElement(By.Id("checkbox_show_password")).Click();
            output.AppendLine("Subtest: " + subTestNo++ + " Login button clicked. Status: Passed");
            Console.WriteLine("Subtest: " + subTestNo++ + " Login button clicked. Status: Passed");
            AppiumWebElement userNameInput = driver.FindElement(By.Id("txt_vpn_id"));
            output.AppendLine("Subtest: " + subTestNo++ + " Navigate to login page and clear SignIn field. Status: Passed");
            Console.WriteLine("Subtest: " + subTestNo++ + " Navigate to login page and clear SignIn field. Status: Passed");
            userNameInput.Clear();
            userNameInput.SendKeys("purevpn0m973650");
            output.AppendLine("Subtest: " + subTestNo++ + " Entered user id 'purevpn0m973650' Status: Passed");
            Console.WriteLine("Subtest: " + subTestNo++ + " Entered user id 'purevpn0m973650' Status: Passed ");
            AppiumWebElement Pwd = driver.FindElement(By.Id("txt_vpn_password"));

            Pwd.Clear(); Pwd.SendKeys("o5jtueb0");
            output.AppendLine("Subtest: " + subTestNo++ + " Entered password 'bfenys31' Status: Passed");
            Console.WriteLine("Subtest: " + subTestNo++ + " Entered password  bfenys31 Status: Passed");
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 100));
            //AppiumWebElement alert = driver.FindElement(By.Id("alertTitle"));
            driver.HideKeyboard();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn_login")));
            driver.FindElement(By.Id("btn_login")).Click();
            output.AppendLine("Subtest: " + subTestNo++ + " Click on Login button. Status: Passed ");
            Console.WriteLine("Subtest: " + subTestNo++ + " Click on Login button. Status: Passed ");

            //   driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementExists(By.Id("image_view")));
            output.AppendLine("Subtest: " + subTestNo++ + " Successfully Signed In. Status: Passed ");
            Console.WriteLine("Subtest: " + subTestNo++ + " Successfully Signed In. Status: Passed");
            driver.FindElement(By.Id("image_view")).Click();
            driver.FindElement(By.Id("image_view")).Click();
            driver.FindElement(By.Id("image_view")).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("action_share")));

            driver.FindElement(By.Id("action_share")).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("txt_current_location")));
            driver.FindElement(By.Id("actionBtn")).Click();
            driver.FindElement(By.Id("btn_uk")).Click();
            //  driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //  WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("txt_current_location")));
            output.AppendLine("Subtest: " + subTestNo++ + " Netherland connected Successfully. Status: Passed  ");
            Console.WriteLine("Subtest: " + subTestNo++ + " Netherland connected Successfully. Status: Passed ");
            driver.FindElement(By.Id("actionBtn")).Click();
            driver.FindElement(By.Id("btn_vpn_action")).Click();
            //   wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("txt_ip_address")));
           // Utils.writeToFile(output.ToString());

        }
    }
}

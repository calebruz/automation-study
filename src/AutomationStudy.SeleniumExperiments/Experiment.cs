using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace AutomationStudy.SeleniumExperiments
{
    public class Experiment
    {
        [Fact]
        public void blah()
        {
            //using will close the driver - using says "whatever is in the parens will be disposed of at the end of the block"
            using (var webDriver = new ChromeDriver())
            {
                webDriver.Navigate().GoToUrl("http://dev.uship.com/signin.aspx");
                var userNameField = webDriver.FindElement(LoginPage.UserNameField);
                userNameField.SendKeys("teambnbshipper@gmail.com");
                var passwordField = webDriver.FindElement(LoginPage.PasswordField);
                passwordField.SendKeys("password");
                var loginButton = webDriver.FindElement(LoginPage.LoginButton);
                loginButton.Click();
            }

        }

    }
}

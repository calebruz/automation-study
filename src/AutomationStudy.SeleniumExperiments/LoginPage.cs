using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationStudy.SeleniumExperiments
{
    public static class LoginPage
    {
        //By.CssSelector("[data-selenium=txtExistingUserName]"))
        public static By UserNameField { get; } = By.CssSelector("[data-selenium=txtExistingUserName]");
        public static By PasswordField { get; } = By.CssSelector("[data-selenium=txtExistingPassword]");
        public static By LoginButton { get; } = By.CssSelector("[data-selenium=btnLogin]");
    }
}

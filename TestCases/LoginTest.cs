using NUnit.Framework;
using SeleniumNunitExtentReport.Config;
using SeleniumNunitExtentReport.PageMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitExtentReport.TestCases
{
    [TestFixture]
    public class LoginTest : ReportGenerationClass
    {
        LoginPage loginPage;
        [Test]
        [Category("Login")]
        public void test_validLogin()
        {
            loginPage = new LoginPage(GetDriver());
            loginPage.goToPage();
            loginPage.goToToggleMenu();
            loginPage.goToLoginMenu();
            loginPage.enterUserName("John Doe");
            loginPage.enterPassword("ThisIsNotAPassword");
            loginPage.clickLoginBtn();
            Assert.IsTrue(loginPage.verifyDashboard());
            loginPage.closeBrowser();
        }

        [Test]
        [Category("Login")]
        public void test_invalidLogin()
        {
            loginPage = new LoginPage(GetDriver());
            loginPage.goToPage();
            loginPage.goToToggleMenu();
            loginPage.goToLoginMenu();
            loginPage.enterUserName("John Doe");
            loginPage.enterPassword("ThisIsNotA");
            loginPage.clickLoginBtn();
            Assert.IsTrue(loginPage.verifyDashboard());
            loginPage.closeBrowser();
        }
    }
}

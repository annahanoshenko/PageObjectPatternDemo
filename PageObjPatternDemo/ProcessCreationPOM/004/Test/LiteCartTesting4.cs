using PageObjPatternDemo.ProcessCreationPOM._004.Base;
using PageObjPatternDemo.ProcessCreationPOM._004.Pages;

namespace PageObjPatternDemo.ProcessCreationPOM._004.Test
{
    [TestFixture]
    internal class LiteCartTesting4 : TestBase
    {

        [Test]
        public void WhenLoginWithValidNameAndPassword_SuccessMessageShouldAppear()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.LoginWithNameAndPassword("user@email.com", "demo");
            mainPage.CheckThatAlertMessageContainsText("logged in as John Doe.");
        }
    }
}

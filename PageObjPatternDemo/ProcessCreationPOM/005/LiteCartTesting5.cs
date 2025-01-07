using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjPatternDemo.ProcessCreationPOM._005
{
    [TestFixture]
    internal class LiteCartTesting5 : TestBase
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

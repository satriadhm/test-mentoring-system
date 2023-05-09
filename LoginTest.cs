
using mentoring_system;
using mentoring_system.view;

namespace unit_test_mentor
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void isAdminTrue()
        {
            LoginMentee login = new LoginMentee();
            bool admin = login.isAdmin("admin", "admin");
            Assert.IsTrue(admin);
        }
        [TestMethod]
        public void isAdminFalse()
        {
            LoginMentee login = new LoginMentee();
            bool admin = login.isAdmin("user", "password");
            Assert.IsFalse(admin);
        }

        [TestMethod]
        public void IsUsernameValid_With_Uppercase_Letter()
        {

            ProfilePageMentee user = new ProfilePageMentee();

            bool result = user.IsUsernameValid("UserName");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUsernameValid_With_No_Uppercase_Letter()
        {
            ProfilePageMentee user = new ProfilePageMentee();

            bool result = user.IsUsernameValid("username");

            Assert.IsFalse(result);
        }

    }
}
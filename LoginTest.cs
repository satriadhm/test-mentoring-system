
using mentoring_system;
namespace unit_test_mentor
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void isAdminTrue()
        {
            LoginMentee login = new LoginMentee();
            bool admin = login.isAdmin("admin" , "admin");
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
        public void isPaaswordLengthSufficient()
        {
            LoginMentee login = new LoginMentee();
            bool admin = login.isPasswordEightCharacter("strongpassword");
            Assert.IsFalse(admin);
        }
    }
}
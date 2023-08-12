using RegexProblems;
using RegexProblems.UserRegistrationProblem;

namespace UserRegistrationTest
{
    public class Tests
    {


       [Test]
        public void TestFirstName()
        {
            UserValidation userReg = new UserValidation();
            bool valid = userReg.UC1_FirstName("Name");
            Assert.IsTrue(valid);
            bool invalid = userReg.UC1_FirstName("shrey878");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestLastName()
        {
            UserValidation userReg = new UserValidation();
            bool valid = userReg.UC2_LastName("Name");
            Assert.IsTrue(valid);
            bool invalid = userReg.UC2_LastName("shrey878");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestMobile()
        {
            UserValidation userReg = new UserValidation();
            bool valid = userReg.UC4_Mobile("91 8789653465");
            Assert.IsTrue(valid);
            bool invalid = userReg.UC4_Mobile("121h334");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestEmail()
        {
            UserValidation userReg = new UserValidation();
            bool valid = userReg.UC6_Email("abc.uh@huasd.com.in");
            Assert.IsTrue(valid);
            bool invalid = userReg.UC6_Email("abc@.uyagd.col");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestPassword()
        {
            UserValidation userReg = new UserValidation();
            bool valid = userReg.UC5_Password("vvdcA876@fsd");
            Assert.IsTrue(valid);
            bool invalid = userReg.UC5_Password("vuvcuy0SDc");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void MultipleEmail()
        {
            Tester tester = new Tester();
            string[] email = {"abc@gmail.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                              "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com"};
            foreach (var data in email)
            {
                string test = tester.EmailVerify(data);
                Assert.AreEqual("Correct", test);
            }
        }
    }
}
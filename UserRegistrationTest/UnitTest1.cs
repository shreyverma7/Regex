using RegexProblems;
using RegexProblems.UserRegistrationProblem;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationTest
{
    public class Tests
    {


       [Test]
        public void TestFirstName()
        {
            
            string input = "Shrey";
            UserValidation firstName = new UserValidation();
            bool result = firstName.UC1_FirstName(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestLastName()
        {
            string input = "Verma";
            UserValidation firstName = new UserValidation();
            bool result = firstName.UC2_LastName(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestMobile()
        {
            string input = "91 8754123412";
            UserValidation firstName = new UserValidation();
            bool result = firstName.UC4_Mobile(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestEmail()
        {
            string input = "shrey007verma@gmail.com";
            UserValidation firstName = new UserValidation();
            bool result = firstName.UC6_Email(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestPassword()
        {
            string input = "Shrey123@4";
            UserValidation firstName = new UserValidation();
            bool result = firstName.UC5_Password(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestAllTrueEmails()
        {
            string[] input = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com",
                "abc-100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            UserValidation trueEmails = new UserValidation();
            foreach (var item in input)
            {
                bool result = trueEmails.UC6_Email(item);
                Assert.IsTrue(result);
            }
        }


    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;

namespace UserRegistration_Test
{
    [TestClass]
    public class UserRegexTest
    {
        #region Making Object of Regex Class, to be used in all Test Cases.
        //Arrange
        User_Registration_Regex user_Registration_Regex = new User_Registration_Regex();
        #endregion

        #region Unit Test for First Name
        [TestMethod]
        [DataRow("Prem", "PREM IS VALID")]
        [DataRow("Gaurav", "GAURAV IS VALID")]
        [DataRow("Hemlata", "HEMLATA IS VALID")]
        [DataRow("", "The first name value could not be empty")]
        [DataRow(null, "The first name value could not be null")]
        [DataRow("prem", "PREM IS INVALID")]
        [DataRow("gaurav", "GAURAV IS INVALID")]
        [DataRow("He", "HE IS INVALID")]
        public void FirstNameTestMethod_ReturnExpectedValue(string checkingName, string expected)
        {
            //Add
            string result = user_Registration_Regex.ValidatefirstName(checkingName);
            //Assert
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Unit Test for Last Name
        [TestMethod]
        [DataRow("Khaneja", "KHANEJA IS VALID")]
        [DataRow("Pandey", "PANDEY IS VALID")]
        [DataRow("Sharma", "SHARMA IS VALID")]
        [DataRow(null, "The last name value could not be null")]
        [DataRow("", "The last name value could not be empty")]
        [DataRow("khaneja", "KHANEJA IS INVALID")]
        [DataRow("pandey", "PANDEY IS INVALID")]
        [DataRow("ar", "AR IS INVALID")]
        public void LastNameTestMethod_ReturnExpectedValue(string checkingLastName, string expected)
        {
            string result = user_Registration_Regex.ValidatelastName(checkingLastName);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Unit Test for Emails
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com is valid")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com is valid")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com is valid")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com is valid")]
        [DataRow("abc111@abc.com", "abc111@abc.com is valid")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au is valid")]
        [DataRow("abc@1.com", "abc@1.com is valid")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com is valid")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com is valid")]
        [DataRow(null, "The email value could not be null")]
        [DataRow("", "The email value could not be empty")]
        [DataRow("abc", "abc is invalid")]
        [DataRow("abc@.com.my", "abc@.com.my is invalid")]
        [DataRow("abc123@.com", "abc123@.com is invalid")]
        [DataRow("abc123@.com.com", "abc123@.com.com is invalid")]
        [DataRow("abc()*@gmail.com", "abc()*@gmail.com is invalid")]
        [DataRow(".abc@abc.com", ".abc@abc.com is invalid")]
        [DataRow("abc@%*.com", "abc@%*.com is invalid")]
        [DataRow("abc..2002@gmail.com", "abc..2002@gmail.com is invalid")]
        [DataRow("abc.@gmail.com", "abc.@gmail.com is invalid")]
        [DataRow("abc@abc@gmail.com", "abc@abc@gmail.com is invalid")]
        [DataRow("abc@gmail.com.1a", "abc@gmail.com.1a is invalid")]
        [DataRow("abc@gmail.com.aa.au", "abc@gmail.com.aa.au is invalid")]
        public void EmailTestMethod_ReturnExpectedValue(string checkingEmail, string expected)
        {
            string result = user_Registration_Regex.ValidateEmail(checkingEmail);
            Assert.AreEqual(expected.ToUpper(), result.ToUpper());
        }
        #endregion

        #region Unit Test for Passwords
        [TestMethod]
        [DataRow("7062662Aa@Vi", "7062662Aa@Vi is valid")]
        [DataRow("hjchjcV55@bk", "hjchjcV55@bk is valid")]
        [DataRow(null, "The passwords value could not be null")]
        [DataRow("", "The password value could not be empty")]
        [DataRow("7062662a@vi", "7062662a@vi is invalid")]
        [DataRow("hjchjc@bk", "hjchjc@bk is invalid")]
        public void PasswordTestMethod_ReturnExpectedValue(string checkingPassword, string expected)
        {
            string result = user_Registration_Regex.ValidatePassword(checkingPassword);
            Assert.AreEqual(expected.ToUpper(), result.ToUpper());
        }
        #endregion

        #region Unit Test for Phone Number
        [TestMethod]
        [DataRow("91 7206594149", "91 7206594149 is valid")]
        [DataRow("91 7015906297", "91 7015906297 is valid")]
        [DataRow(null, "The phone number value could not be null")]
        [DataRow("", "The phone number value could not be empty")]
        [DataRow("917206594149", "917206594149 is invalid")]
        [DataRow("91 7015907", "91 7015907 is invalid")]
        public void MobileNumberTestMethod_ReturnExpectedValue(string checkingMobileNumber, string expected)
        {
            string result = user_Registration_Regex.ValidateMobileNo(checkingMobileNumber);
            Assert.AreEqual(expected.ToUpper(), result.ToUpper());
        }
        #endregion

        #region Unit Test of Func for First Name
        [TestMethod]
        [DataRow("Prem", "PREM IS VALID")]
        [DataRow("Gaurav", "GAURAV IS VALID")]
        [DataRow("Hemlata", "HEMLATA IS VALID")]
        [DataRow("", "The first name value could not be empty")]
        [DataRow(null, "The first name value could not be null")]
        [DataRow("prem", "PREM IS INVALID")]
        [DataRow("gaurav", "GAURAV IS INVALID")]
        [DataRow("He", "HE IS INVALID")]
        public void FirstNameTestMethod_UsingFunc_ReturnExpectedValue(string checkingName, string expected)
        {
            //Add
            string result = user_Registration_Regex.ValidatingFirstNameFunc(checkingName);
            //Assert
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Unit Test of Func for Last Name
        [TestMethod]
        [DataRow("Khaneja", "KHANEJA IS VALID")]
        [DataRow("Pandey", "PANDEY IS VALID")]
        [DataRow("Sharma", "SHARMA IS VALID")]
        [DataRow(null, "The last name value could not be null")]
        [DataRow("", "The last name value could not be empty")]
        [DataRow("khaneja", "KHANEJA IS INVALID")]
        [DataRow("pandey", "PANDEY IS INVALID")]
        [DataRow("ar", "AR IS INVALID")]
        public void LastNameTestMethod_UsingFunc_ReturnExpectedValue(string checkingLastName, string expected)
        {
            string result = user_Registration_Regex.ValidatingLastNameFunc(checkingLastName);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Unit Test of Func for Emails
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com is valid")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com is valid")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com is valid")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com is valid")]
        [DataRow("abc111@abc.com", "abc111@abc.com is valid")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au is valid")]
        [DataRow("abc@1.com", "abc@1.com is valid")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com is valid")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com is valid")]
        [DataRow(null, "The email value could not be null")]
        [DataRow("", "The email value could not be empty")]
        [DataRow("abc", "abc is invalid")]
        [DataRow("abc@.com.my", "abc@.com.my is invalid")]
        [DataRow("abc123@.com", "abc123@.com is invalid")]
        [DataRow("abc123@.com.com", "abc123@.com.com is invalid")]
        [DataRow("abc()*@gmail.com", "abc()*@gmail.com is invalid")]
        [DataRow(".abc@abc.com", ".abc@abc.com is invalid")]
        [DataRow("abc@%*.com", "abc@%*.com is invalid")]
        [DataRow("abc..2002@gmail.com", "abc..2002@gmail.com is invalid")]
        [DataRow("abc.@gmail.com", "abc.@gmail.com is invalid")]
        [DataRow("abc@abc@gmail.com", "abc@abc@gmail.com is invalid")]
        [DataRow("abc@gmail.com.1a", "abc@gmail.com.1a is invalid")]
        [DataRow("abc@gmail.com.aa.au", "abc@gmail.com.aa.au is invalid")]
        public void EmailTestMethod_UsingFunc_ReturnExpectedValue(string checkingEmail, string expected)
        {
            string result = user_Registration_Regex.ValidatingEmailFunc(checkingEmail);
            Assert.AreEqual(expected.ToUpper(), result.ToUpper());
        }
        #endregion

        #region Unit Test of Func for Passwords
        [TestMethod]
        [DataRow("7062662Aa@Vi", "7062662Aa@Vi is valid")]
        [DataRow("hjchjcV55@bk", "hjchjcV55@bk is valid")]
        [DataRow(null, "The passwords value could not be null")]
        [DataRow("", "The password value could not be empty")]
        [DataRow("7062662a@vi", "7062662a@vi is invalid")]
        [DataRow("hjchjc@bk", "hjchjc@bk is invalid")]
        public void PasswordTestMethod_UsingFunc_ReturnExpectedValue(string checkingPassword, string expected)
        {
            string result = user_Registration_Regex.ValidatingPasswordFunc(checkingPassword);
            Assert.AreEqual(expected.ToUpper(), result.ToUpper());
        }
        #endregion

        #region Unit Test of Func for Phone Number
        [TestMethod]
        [DataRow("91 7206594149", "91 7206594149 is valid")]
        [DataRow("91 7015906297", "91 7015906297 is valid")]
        [DataRow(null, "The phone number value could not be null")]
        [DataRow("", "The phone number value could not be empty")]
        [DataRow("917206594149", "917206594149 is invalid")]
        [DataRow("91 7015907", "91 7015907 is invalid")]
        public void MobileNumberTestMethod_UsingFuc_ReturnExpectedValue(string checkingMobileNumber, string expected)
        {
            string result = user_Registration_Regex.ValidatingMobileNumberFunc(checkingMobileNumber);
            Assert.AreEqual(expected.ToUpper(), result.ToUpper());
        }
        #endregion
    }
}
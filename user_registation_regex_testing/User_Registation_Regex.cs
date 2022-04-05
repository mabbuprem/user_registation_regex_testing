using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class User_Registration_Regex
    {
        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string eMailRegex = @"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$";
        public static string mobileNoFormat = @"^91[ ][5-9]{1}[0-9]{9}$";
        public static string passwordFormat = "^(?=.*[!@#$%^&*])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z1-9]{1}[a-zA-Z0-9]{7,}";
        public string ValidatePassword(string password)
        {
            string result = Regex.IsMatch(password, passwordFormat) ? $"{password} is valid".ToUpper() : $"{password} is Invalid".ToUpper();
            return result;
        }
        public string ValidateMobileNo(string phoneNo)
        {
            string result = Regex.IsMatch(phoneNo, mobileNoFormat) ? $"{phoneNo} is valid".ToUpper() : $"{phoneNo} is Invalid".ToUpper();
            return result;
        }
        public string ValidateEmail(string email)
        {
            string result = Regex.IsMatch(email, eMailRegex) ? $"{email} is valid".ToUpper() : $"{email} is Invalid".ToUpper();
            return result;
        }
        public string ValidatelastName(string lN)
        {
            string result = Regex.IsMatch(lN, lastName) ? $"{lN} is valid".ToUpper() : $"{lN} is Invalid".ToUpper();
            return result;
        }
        public string ValidatefirstName(string fN)
        {
            string result = Regex.IsMatch(fN, firstName) ? $"{fN} is valid".ToUpper() : $"{fN} is Invalid".ToUpper();
            return result;
        }
    }
}

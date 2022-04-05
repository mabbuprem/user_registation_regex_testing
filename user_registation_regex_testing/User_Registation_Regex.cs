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
        #region Regex Patterns of All required Fields
        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string eMailRegex = @"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$";
        public static string mobileNoFormat = @"^91[ ][5-9]{1}[0-9]{9}$";
        public static string passwordFormat = "^(?=.*[!@#$%^&*])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z1-9]{1}[a-zA-Z0-9]{7,}";
        #endregion

        #region Passwords Validation & Exception Handling as well.
        public string ValidatePassword(string password)
        {
            try
            {
                if (password == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The passwords value could not be null");
                }
                bool result = Regex.IsMatch(password, passwordFormat);
                if (password == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The password value could not be empty");
                }
                if (result)
                {
                    return $"{password} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{password} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region Mobile Number Validation & Exception Handling as well.
        public string ValidateMobileNo(string phoneNo)
        {
            try
            {
                if (phoneNo == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The phone number value could not be null");
                }
                bool result = Regex.IsMatch(phoneNo, mobileNoFormat);
                if (phoneNo == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The phone number value could not be empty");
                }
                if (result)
                {
                    return $"{phoneNo} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{phoneNo} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region Email Validation & Exception Handling as well.
        public string ValidateEmail(string email)
        {
            try
            {
                if (email == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The email value could not be null");
                }
                bool result = Regex.IsMatch(email, eMailRegex);
                if (email == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The email value could not be empty");
                }
                if (result)
                {
                    return $"{email} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{email} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region Last Name Validation & Exception Handling as well.
        public string ValidatelastName(string lN)
        {
            try
            {
                if (lN == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The last name value could not be null");
                }
                bool result = Regex.IsMatch(lN, lastName);
                if (lN == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The last name value could not be empty");
                }
                if (result)
                {
                    return $"{lN} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{lN} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region First Name Validation & Exception Handling as well.
        public string ValidatefirstName(string fN)
        {
            try
            {
                if (fN == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The first name value could not be null");
                }
                bool result = Regex.IsMatch(fN, firstName);
                if (fN == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The first name value could not be empty");
                }
                if (result)
                {
                    return $"{fN} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{fN} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region Using Func function, Password Validation

        public Func<string, string> ValidatingPasswordFunc = password =>
        {
            try
            {
                if (password == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The passwords value could not be null");
                }
                bool result = Regex.IsMatch(password, passwordFormat);
                if (password == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The password value could not be empty");
                }
                if (result)
                {
                    return $"{password} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{password} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };
        #endregion

        #region Using Func function, Mobile Number Validation

        public Func<string, string> ValidatingMobileNumberFunc = phoneNo =>
        {
            try
            {
                if (phoneNo == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The phone number value could not be null");
                }
                bool result = Regex.IsMatch(phoneNo, mobileNoFormat);
                if (phoneNo == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The phone number value could not be empty");
                }
                if (result)
                {
                    return $"{phoneNo} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{phoneNo} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };
        #endregion

        #region Using Func function, Email Validation

        public Func<string, string> ValidatingEmailFunc = email =>
        {
            try
            {
                if (email == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The email value could not be null");
                }
                bool result = Regex.IsMatch(email, eMailRegex);
                if (email == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The email value could not be empty");
                }
                if (result)
                {
                    return $"{email} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{email} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };
        #endregion

        #region Using Func function, Last Name Validation

        public Func<string, string> ValidatingLastNameFunc = lN =>
        {
            try
            {
                if (lN == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The last name value could not be null");
                }
                bool result = Regex.IsMatch(lN, lastName);
                if (lN == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The last name value could not be empty");
                }
                if (result)
                {
                    return $"{lN} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{lN} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };
        #endregion

        #region Using Func Function, First Name Valiidation
        public Func<string, string> ValidatingFirstNameFunc = fN =>
        {
            try
            {
                if (fN == null)
                {
                    throw new CustomUserRegistrationException(ExceptionType.NULL_DATA, "The first name value could not be null");
                }
                bool result = Regex.IsMatch(fN, firstName);
                if (fN == string.Empty)
                {
                    throw new CustomUserRegistrationException(ExceptionType.EMPTY_DATA, "The first name value could not be empty");
                }
                if (result)
                {
                    return $"{fN} is valid".ToUpper();
                }
                else
                {
                    throw new CustomUserRegistrationException(ExceptionType.INVALID_DATA, $"{fN} is invalid".ToUpper());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };
        #endregion
    }
}
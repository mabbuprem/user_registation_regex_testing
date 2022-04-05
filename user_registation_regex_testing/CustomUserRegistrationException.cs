using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    #region Enums For Exception
    public enum ExceptionType
    {
        NULL_DATA, EMPTY_DATA, INVALID_DATA
    }
    #endregion

    public class CustomUserRegistrationException : Exception
    {
        #region Field of Enum Type
        public ExceptionType Type;
        #endregion

        #region Constructor of CustomUserRegistrationException Class
        public CustomUserRegistrationException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
        #endregion
    }
}

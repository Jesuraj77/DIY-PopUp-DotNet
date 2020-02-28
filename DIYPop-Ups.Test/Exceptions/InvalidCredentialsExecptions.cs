using System;
using System.Collections.Generic;
using System.Text;

namespace DIYPop_Ups.Test.Exceptions
{
    public class InvalidCredentialsExecptions : Exception
    {


        public string Messages = "Please enter valid username & password";

        public InvalidCredentialsExecptions(string message)
        {
            Messages = message;
        }

    }

}

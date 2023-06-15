using System;

namespace SavingApiMenager.Exeptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base (message)
        {
        }
    }
}

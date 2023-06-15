using System;

namespace SavingFileApi.Exeptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base (message)
        {
        }
    }
}

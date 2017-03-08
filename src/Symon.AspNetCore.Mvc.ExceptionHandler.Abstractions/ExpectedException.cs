namespace Symon.AspNetCore.Mvc.ExceptionHandler.Abstractions
{
    public class ExpectedException : System.Exception
    {
        public ExpectedException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        public ExpectedException(int errorCode, string message, System.Exception innerException) : base(message, innerException)
        {
            ErrorCode = errorCode;
        }

        public int ErrorCode { get; set; }
    }
}

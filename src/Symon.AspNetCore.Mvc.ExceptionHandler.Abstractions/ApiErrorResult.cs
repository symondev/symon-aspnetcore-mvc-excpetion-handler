namespace Symon.AspNetCore.Mvc.ExceptionHandler.Abstractions
{
    public class ApiErrorResult
    {
        public ApiErrorResult()
        {
        }

        public ApiErrorResult(ErrorType type, int errorCode, string errorMessage)
        {
            Type = type;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public ErrorType Type { get; set; }

        public int ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}

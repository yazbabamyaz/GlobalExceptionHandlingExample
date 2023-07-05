namespace GlobalExceptinHandlingApp2.Models
{
    public class ErrorResponse
    {
        public bool Success { get; set; }
        public string Message { get; internal set; }
    }
}
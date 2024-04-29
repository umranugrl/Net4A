namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class ValidationProblemDetails : ProblemDetails
    {
        public List<string> Errors { get; set; }
        public ValidationProblemDetails(List<string> errors)
        {
            Errors = errors;
            Title = "Validation Rule Violation";
            Detail = "Validation Exception";
            Type = "ValidationException";
        }
    }
}
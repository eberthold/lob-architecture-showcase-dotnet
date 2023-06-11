namespace BusinessLogic.Results;

public class Result<T>
{
    private Result()
    {
    }

    public bool Success { get; private init; }

    public T? Content { get; private init; }
    
    public string Message { get; private init; } = string.Empty;

    public static Result<T> FromSuccess(T content)
    {
        return new Result<T>
        {
            Content = content,
            Success = true
        };
    }

    public static Result<T> FromError(string message)
    {
        return new Result<T>
        {
            Message = message,
            Success = false,
        };
    }
}
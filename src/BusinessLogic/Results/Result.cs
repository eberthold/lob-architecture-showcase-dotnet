namespace BusinessLogic.Results;

public class Result
{
    private Result()
    {
    }

    public bool Success { get; private init; }

    public string Message { get; private init; } = string.Empty;

    public static Result FromSuccess()
    {
        return new Result
        {
            Success = true
        };
    }

    public static Result<T> FromSuccess<T>(T content)
    {
        return Result<T>.FromSuccess(content);
    }

    public static Result FromError(string message)
    {
        return new Result
        {
            Message = message,
            Success = false,
        };
    }
}
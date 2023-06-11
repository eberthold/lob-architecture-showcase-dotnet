using BusinessLogic.Results;

namespace BusinessLogic.Authentication;

public interface IAuthenticationService
{
	Task<Result> HasPermission(Permission permission);
}
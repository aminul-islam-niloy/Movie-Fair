using Movie_Fair.Models.DTO;

namespace Movie_Fair.Repositories.Abstruct
{
    public interface IUserAuthenticationService
    {

        Task<Status> LoginAsync(Login model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(Registration model);
        
    }
}

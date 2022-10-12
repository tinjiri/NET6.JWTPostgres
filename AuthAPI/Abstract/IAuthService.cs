using AuthAPI.DTOs;

namespace AuthAPI.Abstract
{
    public interface IAuthService
    {
        Task<string> Register(UserDto request);
        Task<string> Login(UserDto request);
    }
}

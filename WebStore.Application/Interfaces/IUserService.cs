using WebStore.Application.DTOs.Users;

namespace WebStore.Application.Interfaces;

public interface IUserService
{
    Task<UserDto?> GetByIdAsync(int id);

    Task<int> RegisterAsync(CreateUserDto dto);

    Task<UserDto?> LoginAsync(LoginUserDto dto);

    Task UpdateAsync(int id, UpdateUserDto dto);
}
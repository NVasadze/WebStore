using WebStore.Application.DTOs.Users;
using WebStore.Application.Interfaces;

namespace WebStore.Application.Services;

public class UserService : IUserService
{
    public Task<UserDto?> GetByIdAsync(int id) => throw new NotImplementedException();
    public Task<int> RegisterAsync(CreateUserDto dto) => throw new NotImplementedException();
    public Task<UserDto?> LoginAsync(LoginUserDto dto) => throw new NotImplementedException();
    public Task UpdateAsync(int id, UpdateUserDto dto) => throw new NotImplementedException();
}
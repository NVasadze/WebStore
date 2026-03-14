using WebStore.Application.DTOs.Cart;
using WebStore.Application.Interfaces;

namespace WebStore.Application.Services;

public class CartService : ICartService
{
    public Task<CartDto?> GetCartAsync(int userId) => throw new NotImplementedException();
    public Task AddItemAsync(int userId, AddCartItemDto dto) => throw new NotImplementedException();
    public Task UpdateItemAsync(int userId, int cartItemId, UpdateCartItemDto dto) => throw new NotImplementedException();
    public Task RemoveItemAsync(int userId, int cartItemId) => throw new NotImplementedException();
    public Task ClearCartAsync(int userId) => throw new NotImplementedException();
}
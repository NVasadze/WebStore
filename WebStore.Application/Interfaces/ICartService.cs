using WebStore.Application.DTOs.Cart;

namespace WebStore.Application.Interfaces;

public interface ICartService
{
    Task<CartDto?> GetCartAsync(int userId);

    Task AddItemAsync(int userId, AddCartItemDto dto);

    Task UpdateItemAsync(int userId, int cartItemId, UpdateCartItemDto dto);

    Task RemoveItemAsync(int userId, int cartItemId);

    Task ClearCartAsync(int userId);
}
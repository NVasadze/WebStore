using WebStore.Application.DTOs.Orders;

namespace WebStore.Application.Interfaces;

public interface IOrderService
{
    Task<int> CreateOrderAsync(CreateOrderDto dto);

    Task<OrderDto?> GetByIdAsync(int id);

    Task<IEnumerable<OrderHistoryDto>> GetUserOrdersAsync(int userId);
}
using WebStore.Application.DTOs.Orders;
using WebStore.Application.Interfaces;

namespace WebStore.Application.Services;

public class OrderService : IOrderService
{
    public Task<int> CreateOrderAsync(CreateOrderDto dto) => throw new NotImplementedException();
    public Task<OrderDto?> GetByIdAsync(int id) => throw new NotImplementedException();
    public Task<IEnumerable<OrderHistoryDto>> GetUserOrdersAsync(int userId) => throw new NotImplementedException();
}
namespace WebStore.Application.DTOs.Orders;

public class OrderDto
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime OrderDate { get; set; }

    public List<OrderItemDto> Items { get; set; } = new();

    public decimal TotalPrice => Items.Sum(i => i.TotalPrice);
}
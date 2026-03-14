namespace WebStore.Application.DTOs.Orders;

public class OrderHistoryDto
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal TotalPrice { get; set; }
}
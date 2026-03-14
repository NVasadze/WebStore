namespace WebStore.Domain.Entities;

public class Order
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public User User { get; set; } = null!;

    public decimal TotalPrice { get; set; }

    public DateTime OrderDate { get; set; }

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}
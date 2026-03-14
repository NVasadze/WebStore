namespace WebStore.Application.DTOs.Cart;

public class CartDto
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public List<CartItemDto> Items { get; set; } = new();

    public decimal TotalPrice => Items.Sum(i => i.TotalPrice);
}
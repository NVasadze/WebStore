using WebStore.Application.Interfaces;
using WebStore.Application.Interfaces.Repositories;
using WebStore.Infrastructure.Data;

namespace WebStore.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly StoreDbContext _context;

    public ICategoryRepository Categories { get; }
    public IProductRepository Products { get; }
    public IUserRepository Users { get; }
    public ICartRepository Carts { get; }
    public IOrderRepository Orders { get; }

    public UnitOfWork(
        StoreDbContext context,
        ICategoryRepository categoryRepository,
        IProductRepository productRepository,
        IUserRepository userRepository,
        ICartRepository cartRepository,
        IOrderRepository orderRepository)
    {
        _context = context;
        Categories = categoryRepository;
        Products = productRepository;
        Users = userRepository;
        Carts = cartRepository;
        Orders = orderRepository;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
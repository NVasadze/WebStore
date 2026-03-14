using WebStore.Application.Interfaces.Repositories;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Data;

namespace WebStore.Infrastructure.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(StoreDbContext context) : base(context)
    {
    }
}
using WebStore.Application.DTOs.Products;
using WebStore.Application.Interfaces;

namespace WebStore.Application.Services;

public class ProductService : IProductService
{
    public Task<IEnumerable<ProductDto>> GetAllAsync() => throw new NotImplementedException();
    public Task<ProductDto?> GetByIdAsync(int id) => throw new NotImplementedException();
    public Task<int> CreateAsync(CreateProductDto dto) => throw new NotImplementedException();
    public Task UpdateAsync(int id, UpdateProductDto dto) => throw new NotImplementedException();
    public Task DeleteAsync(int id) => throw new NotImplementedException();
}
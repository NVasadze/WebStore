using WebStore.Application.DTOs.Categories;

namespace WebStore.Application.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDto>> GetAllAsync();

    Task<CategoryDto?> GetByIdAsync(int id);

    Task<int> CreateAsync(CreateCategoryDto dto);

    Task UpdateAsync(int id, UpdateCategoryDto dto);

    Task DeleteAsync(int id);
}
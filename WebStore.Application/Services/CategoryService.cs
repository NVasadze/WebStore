using AutoMapper;
using WebStore.Application.DTOs.Categories;
using WebStore.Application.Interfaces;
using WebStore.Domain.Entities;

namespace WebStore.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryDto>> GetAllAsync()
    {
        var categories = await _unitOfWork.Categories.GetAllAsync();
        return _mapper.Map<IEnumerable<CategoryDto>>(categories);
    }

    public async Task<CategoryDto?> GetByIdAsync(int id)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(id);

        if (category is null)
            return null;

        return _mapper.Map<CategoryDto>(category);
    }

    public async Task<int> CreateAsync(CreateCategoryDto dto)
    {
        var category = _mapper.Map<Category>(dto);

        await _unitOfWork.Categories.AddAsync(category);
        await _unitOfWork.SaveChangesAsync();

        return category.Id;
    }

    public async Task UpdateAsync(int id, UpdateCategoryDto dto)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(id);

        if (category is null)
            throw new KeyNotFoundException($"Category with id {id} was not found.");

        _mapper.Map(dto, category);
        _unitOfWork.Categories.Update(category);

        await _unitOfWork.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(id);

        if (category is null)
            throw new KeyNotFoundException($"Category with id {id} was not found.");

        _unitOfWork.Categories.Delete(category);

        await _unitOfWork.SaveChangesAsync();
    }
}
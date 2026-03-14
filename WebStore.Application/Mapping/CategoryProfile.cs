using AutoMapper;
using WebStore.Application.DTOs.Categories;
using WebStore.Domain.Entities;

namespace WebStore.Application.Mapping;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryDto>();
        CreateMap<CreateCategoryDto, Category>();
        CreateMap<UpdateCategoryDto, Category>();
    }
}
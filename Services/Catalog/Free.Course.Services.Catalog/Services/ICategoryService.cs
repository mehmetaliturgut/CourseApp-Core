﻿using Free.Course.Services.Catalog.Dtos;
using Free.Course.Services.Catalog.Models;
using FreeCourse.Shared.Dtos;

namespace Free.Course.Services.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(CategoryDto category);

        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}

using Dapper_Proj5.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Proj5.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task CreateCategory(CreateCategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> GetByIdCategoryDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(UpdateCategoryDto dto)
        {
            throw new NotImplementedException();
        }
    }
}

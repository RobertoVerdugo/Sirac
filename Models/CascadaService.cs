using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Pages
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<SubCategory> GetSubCategories(int categoryId);
    }
    public class CascadaService : ICategoryService
    {
        public IEnumerable<Category> GetCategories()
        {
            return new List<Category>
        {
            new Category { CategoryId = 1, CategoryName="Perro" },
            new Category { CategoryId = 2, CategoryName="Gato" },
        };
        }
        public IEnumerable<SubCategory> GetSubCategories(int categoryId)
        {
            var subCategories = new List<SubCategory> {
            new SubCategory { SubCategoryId = 1, CategoryId = 1, SubCategoryName="Dalmata" },
            new SubCategory { SubCategoryId = 2, CategoryId = 1, SubCategoryName="Poodle" },
            new SubCategory { SubCategoryId = 3, CategoryId = 2, SubCategoryName="Persa" },
            new SubCategory { SubCategoryId = 4, CategoryId = 2, SubCategoryName="Siames" },
        };
            return subCategories.Where(s => s.CategoryId == categoryId);
        }
    }
}
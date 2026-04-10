using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {
        
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {

            _categoryDal.insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.delete(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.update(category);

        }

        public List<Category> GetList()
        {
            return _categoryDal.list();
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x=>x.CategoryID == id);
        }
    }
}

using CrudOperation.Business.Abstract;
using CrudOperation.DataAccess.Abstracts;
using CrudOperation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryService;

    public CategoryManager(ICategoryDal categoryService)
    {
        _categoryService = categoryService;
    }

    public void Add(Category category)
    {
        _categoryService.Add(category);
    }

    public void Delete(Category category)
    {
        _categoryService.Delete(category);
    }

    public List<Category> GetAll()
    {
        return _categoryService.GetAll();
    }

    public void Update(Category category)
    {
        throw new NotImplementedException();
    }
}

using CrudOperation.DataAccess.Abstracts;
using CrudOperation.Entities;

namespace CrudOperation.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        Category category = new Category();
        category.ID = 1;
        category.Name = "Yazilim";
        category.Description = "Yazılım Dilleri";
        category.categoryType = "Yazılım";

        Category category2 = new Category();
        category2.ID = 2;
        category2.Name = "Siber Güvenlik";
        category2.Description = "Siber Güvenlik alanı";
        category2.categoryType = "Bilişim";

        _categories = new List<Category> { category,category2};
            
    }
    public void Add(Category item)
    {
        _categories.Add(item);
    }

    public void Delete(Category item)
    {
        _categories.Remove(item);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category item)
    {
        throw new NotImplementedException();
    }
}

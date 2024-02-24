using CrudOperation.Business.Abstract;
using CrudOperation.DataAccess.Abstracts;
using CrudOperation.Entities;

namespace CrudOperation.Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course category)
    {
        _courseDal.Add(category);
    }

    public void Delete(Course category)
    {
        _courseDal.Delete(category);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Course category)
    {
        throw new NotImplementedException();
    }
}

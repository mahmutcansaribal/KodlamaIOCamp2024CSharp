using CrudOperation.Entities;

namespace CrudOperation.Business.Abstract;

public interface ICourseService
{
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
    List<Course> GetAll();
}

using CrudOperation.Entities;

namespace CrudOperation.Business.Abstract;

public interface IinstructorService
{
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(Instructor instructor);
    List<Instructor> GetAll();
}

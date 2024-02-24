using CrudOperation.Business.Abstract;
using CrudOperation.DataAccess.Abstracts;
using CrudOperation.Entities;

namespace CrudOperation.Business.Concrete;

public class InstructorManager : IinstructorService
{
    private readonly IinstructorDal _instructor;

    public InstructorManager(IinstructorDal instructor)
    {
        _instructor = instructor;
    }

    public void Add(Instructor category)
    {
        _instructor.Add(category);
    }

    public void Delete(Instructor category)
    {
        _instructor.Delete(category);
    }

    public List<Instructor> GetAll()
    {
        return _instructor.GetAll();
    }

    public void Update(Instructor category)
    {
        throw new NotImplementedException();
    }
}

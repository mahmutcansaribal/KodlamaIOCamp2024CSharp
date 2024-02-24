using CrudOperation.DataAccess.Abstracts;
using CrudOperation.Entities;

namespace CrudOperation.DataAccess.Concretes;

public class InstructorDal : IinstructorDal
{
    List<Instructor> _instructors;

    public InstructorDal()
    {

        Instructor instructor = new Instructor();
        instructor.ID = 1;
        instructor.Name = "Engin Demirog";
        instructor.Description = "Kodlama IO Bünyesi Baş Eğitici";

        Instructor instructor2 = new Instructor();
        instructor2.ID = 2;
        instructor2.Name = "Hali Kalaycı";
        instructor2.Description = "Kodlama IO Bünyesi Yardımcı Egitmen";

       _instructors = new List<Instructor> { instructor,instructor2 };

    }
    public void Add(Instructor item)
    {
        _instructors.Add(item);
    }

    public void Delete(Instructor item)
    {
        _instructors.Remove(item);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor item)
    {
        throw new NotImplementedException();
    }
}

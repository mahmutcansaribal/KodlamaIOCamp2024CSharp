using CrudOperation.Business.Concrete;
using CrudOperation.DataAccess.Concretes;
using CrudOperation.Entities;



CourseManager courseManager = new CourseManager(new CourseDal());

List<Course> courses = courseManager.GetAll(); 

foreach(var item in courses)
{
    Console.WriteLine(item.Name);
}


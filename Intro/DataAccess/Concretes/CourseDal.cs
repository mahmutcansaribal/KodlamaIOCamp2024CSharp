using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "Java";
        course1.Description = ".NET Java 17 vs ...";
        course1.price = 0;

        Course course2 = new Course();
        course2.Id = 1;
        course2.Name = "Python";
        course2.Description = ".Python 3.12 vs ...";
        course2.price = 20;

        Course course3 = new Course();
        course3.Id = 1;
        course3.Name = "C#";
        course3.Description = ".NET 8 vs ...";
        course3.price = 0;

        courses = new List<Course> { course1, course2,course3 };
    }
    public List<Course> GetAll() 
    {
        //Burada DB işlemleri yapılır.
        return courses;
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }
}

public class EfCourseDal : ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = ".NET Java 17 vs ...";
        course1.price = 0;

        Course course2 = new Course();
        course2.Id = 1;
        course2.Name = "JAVA";
        course2.Description = ".Python 3.12 vs ...";
        course2.price = 20;

        Course course3 = new Course();
        course3.Id = 1;
        course3.Name = "C++";
        course3.Description = ".NET 8 vs ...";
        course3.price = 0;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //Burada DB işlemleri yapılır.
        return courses;
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }
}
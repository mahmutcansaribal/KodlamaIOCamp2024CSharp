using CrudOperation.DataAccess.Abstracts;
using CrudOperation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;

    public CourseDal()
    {
        Course course = new Course();
        course.ID = 1;
        course.Name = "C# 2024 YAZILIM GELİŞTİRME KURSU";
        course.Description = "2024 C# Kursu";
        //Kendine Ait
        course.Price = 0;
        course.InstructorID = 1;
        course.CategoryID = 1;

        Course course2 = new Course();
        course2.ID = 2;
        course2.Name = "JAVA 2024 YAZILIM GELİŞTİRME KURSU";
        course2.Description = "2024 JAVA Kursu";
        //Kendine Ait
        course2.Price = 0;
        course2.InstructorID = 2;
        course2.CategoryID = 2;

        _courses = new List<Course> { course, course2 }; 

    }
    public void Add(Course item)
    {
        _courses.Add(item);
    }

    public void Delete(Course item)
    {
        _courses.Remove(item);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public void Update(Course item)
    {
        throw new NotImplementedException();
    }
}

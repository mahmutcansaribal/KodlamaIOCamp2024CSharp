// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

//Primative Type
string message1 = "Krediler";
int term = 12;
double amount = 100000;

bool isAuthenticated = true;
Console.WriteLine(message1);


if (isAuthenticated)
{
    Console.WriteLine("Giriş Başarılı!");
}
else
{
    Console.WriteLine("Giriş Başarısız!");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6" };

for(int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

//Class Yapısı


//Course[] courses = { course1, course2, course3 };

//for(int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].price);
//}

CourseManager courseManager = new CourseManager(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].price);
}

Console.WriteLine("Kod Bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Can";
customer1.LastName = "Sarıbal";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "1234561234";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "1234567";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "KodlamaIO";
customer3.CustomerNumber = "64542";
customer3.TaxNumber = "1234567890";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 3;
customer4.Name = "KodlamaIO";
customer4.CustomerNumber = "64542";
customer4.TaxNumber = "1234567890";

//valu types --> int,bool,double...
//reference types --> array,class,interface...

BaseCustomer[] customers = {customer1,customer2, customer3, customer4};

//Polymorphism
foreach(BaseCustomer customer in customers)
{
    //if(customer is IndividualCustomer)
    //{
        
    //}
    Console.WriteLine(customer.CustomerNumber);
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.Entities;

public class Course : BaseKodlamaIO
{
    
    public int CategoryID { get; set; }
    public int InstructorID { get; set; }
    public double Price { get; set; }   

}

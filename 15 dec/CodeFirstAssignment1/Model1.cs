using System;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstAssignment1
{
    public class Model1 : DbContext
    {
        
        public Model1()
            : base("name=Model1")
        {
        }

       
        public virtual DbSet<Employeeclass> emps { get; set; }
    }

    
}
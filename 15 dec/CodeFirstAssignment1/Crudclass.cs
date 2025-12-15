using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment1
{
    internal class Crudclass
    {
        Model1 dc = new Model1();
        

        //1. Perform CRUD operations using Lambda expressions 

       
        public void insertnewEmployee()
        {
            Console.WriteLine("enter employee Id");
            string Id=Console.ReadLine();
            Console.WriteLine("Enter Employee Name");
            string Ename=Console.ReadLine();
            Console.WriteLine("Enter Employee DeptName");
            string Dname = Console.ReadLine();
            Console.WriteLine("Enter Employee salary");
            int sal=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee joining year");
            int Jyear=int.Parse(Console.ReadLine());
           

            try
            {
                Employeeclass empclas = new Employeeclass()
                {
                    id = Id,
                    Name = Ename,
                    DeptName = Dname,
                    Salary=sal,
                    Year_Of_Join=Jyear,
                };
                dc.emps.Add(empclas);
                int res = dc.SaveChanges();
                Console.WriteLine($"Inserted rows {res}");

            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();

                foreach (var item in res)
                {
                    if (item.ValidationErrors.Count > 0)
                    {
                        foreach (var err in item.ValidationErrors)
                        {
                            Console.WriteLine(err.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void showemployee()
        {
            var res = dc.emps.ToList(); //using lmbda
            foreach (var item in res)
            {
                Console.WriteLine($"{item.id},{item.Name},{item.DeptName},{item.Salary},{item.Year_Of_Join}");
            }
        }
        public void updaterecord() //update salary by empid
        {
            Console.WriteLine("Enter employeeid");
            string Id=Console.ReadLine();
            Console.WriteLine("Enter new salary");
            int sal = int.Parse(Console.ReadLine());

            var res=dc.emps.FirstOrDefault(e=>e.id==Id);
            res.Salary = sal;
            int i = dc.SaveChanges();
            Console.WriteLine($"updated rows : {i}");

        }
        public void removerecord()
        {
            Console.WriteLine("Enter Employee id for removing record");
            string Id = Console.ReadLine();

            var res=dc.emps.Where(e=>e.id==Id).First();

            dc.emps.Remove(res);

            int row = dc.SaveChanges();
            Console.WriteLine($"Deleted rows {row}");

        }
        //2. Create procedure which accepts department Name as a parameter and 
        //display all employee of that department
        public void Question2()
        {

        }
        static void Main(string[] args)
        {
            Crudclass dc = new Crudclass();

            //Console.WriteLine("\nAdd employee :\n");
            //dc.insertnewEmployee();

            //Console.WriteLine("Showing all employee");
            //dc.showemployee();

            //Console.WriteLine("updated record");
            //dc.updaterecord();

            Console.WriteLine("Delted record");
            dc.removerecord();

            Console.ReadLine();
        }
    }
}

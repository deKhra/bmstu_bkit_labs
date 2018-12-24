using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Employer
    {
        public int ID;
        public string Surname;
        public int DepartmentID;

        public Employer() { }
        public Employer(int id, string surn, int depid)
        {
            ID = id;
            Surname = surn;
            DepartmentID = depid;


        }
    }
    public class Department
    {
        public int DepartmentID;
        public string Name;

        public Department() { }
        public Department(int depid, string nam)
        {
            DepartmentID = depid;
            Name = nam;
        }

    }
    public class Relation
    {
        public int ID;
        public int DepartmentID;
        public Relation(int i1, int i2) { ID = i1; DepartmentID = i2; }
    }





    class Program
    {
        static void Main(string[] args)
        {
            List<Employer> employers = new List<Employer>()
            {
                new Employer(1,"Petrov",1),
                new Employer(5,"Ivanov",2),
                new Employer(7,"Andreev",3),
                new Employer(4,"Letov",2),
                new Employer(2,"Vetrov",1),
                new Employer(9,"Bokov",3),
                new Employer(3,"Amitov",1),
                new Employer(8,"Aleshin",3),
                new Employer(6,"Sidorov",2)
            
            };
            List<Department> departments = new List<Department>()
            {
                new Department(1,"IT"),
                new Department(2,"Financial"),
                new Department(3,"Human Resource")
            };
            List<Relation> relations = new List<Relation>()
            {
                new Relation(1,1),
                new Relation(2,1),
                new Relation(3,1),
                new Relation(4,2),
                new Relation(5,2),
                new Relation(6,2),
                new Relation(7,3),
                new Relation(8,3),
                new Relation(9,3),

            };

            {
                Console.WriteLine("\nList of departments");
                var dep = from x in departments
                          orderby x.DepartmentID
                          select x.Name;
                foreach (var x in dep) { Console.WriteLine(x); }
            }
            {
                Console.WriteLine("\nList of employers");
                var emp = from x in employers
                          orderby x.DepartmentID
                          select x.Surname;
                foreach (var x in emp) { Console.WriteLine(x); }
            }
            Console.WriteLine("\nEmployers with A");
            var letterA = from x in employers
                          where x.Surname[0] == 'A'
                          select x.Surname;
            foreach (var x in letterA) { Console.WriteLine(x); }
            {
                Console.WriteLine("\nEmployers in departments");
                var task4 = from dep in departments
                            join emp in employers on dep.DepartmentID equals emp.DepartmentID into temp
                            select new { Name = dep.Name, Cnt = temp.Count() };
                foreach (var dep in task4)
                {
                    Console.WriteLine("{0}: {1} employers", dep.Name, dep.Cnt);
                }
                Console.WriteLine();
            }
            {
                Console.WriteLine("\nDepartments with all employers having first A");
                var task5 = from dep in departments
                            join emp in employers on dep.DepartmentID equals emp.DepartmentID into temp
                            where temp.All(x => x.Surname[0] == 'A')
                            select dep.Name;
                foreach (var dep in task5)
                {
                    Console.WriteLine(dep);
                }
                Console.WriteLine();
            }
            {
                Console.WriteLine("\nDepartments with some employers having first A");
                var task6 = from dep in departments
                            join emp in employers on dep.DepartmentID equals emp.DepartmentID into temp
                            where temp.Any(x => x.Surname[0] == 'A')
                            select dep.Name;
                foreach (var dep in task6)
                {
                    Console.WriteLine(dep);
                }
            }
            Console.WriteLine();

            {
                Console.WriteLine("Employers of department");
                var t7 = from dep in departments
                         join rel in relations on dep.DepartmentID equals rel.DepartmentID into matchingRels

                         from rel in matchingRels
                         join emp in employers on rel.ID equals emp.ID into matchingEmps
                         from link in matchingEmps
                         select new { Dep = dep.Name, Emps = link.Surname };
                var t8 = from line in t7
                         group line by line.Dep into depEmps
                         select new { Dep = depEmps.Key, Emps = depEmps };

                foreach (var dep in t8)
                {
                    Console.WriteLine("\n" + dep.Dep);
                    foreach (var emp in dep.Emps)
                    {
                        Console.WriteLine("*" + emp.Emps);
                    }
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Number of employers");
                var t9 = from dep in departments
                         join rel in relations on dep.DepartmentID equals rel.DepartmentID into matchingRels
                         from rel in matchingRels
                         join emp in employers on rel.ID equals emp.ID into matchingEmps
                         from link in matchingEmps
                         select new { Dep = dep.Name, Emps = link.Surname };
                var t10 = from line in t9
                          group line by line.Dep into depEmps
                          select new { Dep = depEmps.Key, Emps = depEmps.Count() };

                foreach (var dep in t10)
                {
                    Console.WriteLine(dep.Dep);
                    Console.WriteLine("Employee count: "+dep.Emps);
                }
                Console.WriteLine();
            }

            Console.Read();
        }

    }
}

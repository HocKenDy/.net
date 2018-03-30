using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaoHiem09
{
    class Company
    {
        public List<Employee> DSEmployee;
        

        //constructer
        public Company()
        {
            DSEmployee = new List<Employee>();
        }
        
        public void InitEmploy()
        {
            Employee employee = new Employee();
            employee.Init();
            DSEmployee.Add(employee);
        }

        public void Display()
        {
            foreach(Employee em in DSEmployee)
            {
                em.Display();
                Console.WriteLine("---------------------------------");
            }
        }


        public void AddInCo()
        {
            Console.Write("Id Employee: ");
            int id = Convert.ToInt32(Console.ReadLine()); 

            foreach(Employee em in DSEmployee)
            {
                if( id == em.IdEmployee)
                {
                    em.SaleInCo();
                    break;
                }
            }
        }
        public void AddInCo(int idEmployee, int idInCo, string nameOwer, int durationInCo, double aOM)
        {

            foreach (Employee em in DSEmployee)
            {
                if (idEmployee == em.IdEmployee)
                {
                    em.SaleInCo(idInCo, nameOwer,durationInCo,aOM);
                    break;
                }
            }
        }

        public void DisplayEmployeeCommissionOver(int value)
        {
            Console.Write("Nhan vien co Commission > {0}", value);
            var goodEm = from x in DSEmployee
                         where (x.Commission > value)
                         select x;
            if (goodEm.Count() > 0)
            {
                Console.WriteLine();
                foreach (Employee em in goodEm)
                {
                    Console.WriteLine(em.NameEmployee);
                }
            }
            else
            {
                Console.WriteLine("Don't have anyone with Commission > {0} USD", value);
            }
        }

        public void DisplayEmployeeIsPunish()
        {
            Console.Write("Nhan vien bi Bunish");
            var badEm = from x in DSEmployee
                         where (x.IsBonus() == -1)
                         select x;
            if (badEm.Count() > 0)
            {
                Console.WriteLine();
                foreach (Employee em in badEm)
                {
                    Console.WriteLine(em.NameEmployee);
                }
            }
            else
            {
                Console.WriteLine("Don't have anyone bunished");
            }
        }

        internal void DisplayEmployeeIsBonus()
        {
            Console.Write("Nhan vien  Bonus: ");
            var badEm = from x in DSEmployee
                        where (x.IsBonus() == 1)
                        select x;
            if (badEm.Count() > 0)
            {
                Console.WriteLine();
                foreach (Employee em in badEm)
                {
                    Console.WriteLine(em.NameEmployee);
                }
            }
            else
            {
                Console.WriteLine("Don't have anyone bonus!");
            }
        }
    }
}

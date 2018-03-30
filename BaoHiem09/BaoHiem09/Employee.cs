using System;
using System.Collections.Generic;
using System.Text;

namespace BaoHiem09
{
    class Employee
    {
        public int IdEmployee { get; set; }
        public string NameEmployee { get; set; }
        public double SalaryRatio { get; set; }  // Bậc lương
        public double Commission { get; set; } = 0;    //Tiền hoa hồng 
        public List<InsuranceContract> InCoIsSaled { get; set; }   

        //Constructer
        public Employee() {
            InCoIsSaled = new List<InsuranceContract>();
        }

        public Employee(int idEmployee, string nameEmployee,double salaryRatio)
        {
            IdEmployee = idEmployee;
            NameEmployee = nameEmployee;
            SalaryRatio = salaryRatio;

            InCoIsSaled = new List<InsuranceContract>();


        }

        public void Init()
        {
            Console.Write("Id Employee: ");
            IdEmployee = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name Employee: ");
            NameEmployee = Console.ReadLine().Trim();
                
            Console.Write("Salary Ratio: ");
            SalaryRatio = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {

            Console.WriteLine("Id Employee: "+ IdEmployee);

            Console.WriteLine("Name Employee:"+ NameEmployee);

            Console.WriteLine("Salary " + CalSalary());

            Console.Write("InCo is saled: ");
            if (InCoIsSaled.Count > 0)
            {
                Console.WriteLine();
                foreach (InsuranceContract inCo in InCoIsSaled)
                {
                    Console.WriteLine("{0} -- {1} -- {2}", inCo.IdInCo, inCo.NameOwner, inCo.AmountOfMoney);
                }
            }
            else
            {
                Console.WriteLine("Not Contract is Saled !");
            }
            

        }

        internal void SaleInCo(int idInCo, string nameOwer, int durationInCo, double aOM)
        {
            InsuranceContract inCo = new InsuranceContract(idInCo, nameOwer, durationInCo, aOM);
            InCoIsSaled.Add(inCo );
            CalCommission(inCo);
        }

        public void SaleInCo()
        {
            InsuranceContract inCo= new InsuranceContract();
            inCo.Init();
            InCoIsSaled.Add(inCo);
            CalCommission(inCo);
        }

        private double CalSalary()
        {
            double result =0 ;


            result = 40 * SalaryRatio + 0.01 * (InCoRevenue(IdEmployee) - Commission);

            return result;
        }

        private double InCoRevenue(int idEmployee) // tổng số tiền đã bán hợp đồng
        {
            double result = 0;
            if (!(InCoIsSaled is null)) {
                foreach (InsuranceContract inCo in InCoIsSaled)
                {
                    result += inCo.AmountOfMoney;

                }
            }
            
            return result;
        }

        public int IsBonus()  // return 0 : k bị phạt, k được thưởng. return 1 : thưởng; return -1: bị phạt
        {
            double sum = 0;
            foreach (InsuranceContract inCo in InCoIsSaled)
            {
                if (inCo.AmountOfMoney >= 10000) return 1;
                sum += inCo.AmountOfMoney;
            }
            if (sum < 10000)
            {
                return -1;
            }
            return 0;

        }

        public 

         void CalCommission(InsuranceContract InCo) // Tính hoa hồng cho mỗi hợp đồng bán hàng
        {
            if (InCo.IsLongTimeInCo)
            {
                Commission += InCo.MonthlyPayment * 0.5;
            }else
            {
                Commission += InCo.AmountOfMoney * 0.05;
            }
        } 
    }
}

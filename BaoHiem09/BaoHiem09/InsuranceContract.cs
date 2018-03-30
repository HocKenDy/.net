using System;
using System.Collections.Generic;
using System.Text;

namespace BaoHiem09
{
    class InsuranceContract
    {
        public int IdInCo { get; set; }
        public bool IsLongTimeInCo { get; set; }
        public string NameOwner { get; set; }
        public int DurationInCo { get; set; } = 0; //thời hạn
        public double AmountOfMoney { get; set; } = 0;
        public double MonthlyPayment { get; set; } = 0;
        

        // Constructer
        public InsuranceContract() { }
        
        public InsuranceContract(int idInCO,string ownerInCo, int durationInCo, double aOM)
        {
            IdInCo = idInCO;
            NameOwner = ownerInCo;
            DurationInCo = durationInCo;
            AmountOfMoney = aOM;
            
            if (DurationInCo > 12)
            {
                IsLongTimeInCo = true;
                MonthlyPayment = AmountOfMoney / DurationInCo;
            }else IsLongTimeInCo = false;
        }

        public void Init()
        {
            Console.Write("Id Contract");
            IdInCo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Owner Insurance Contract:");
            NameOwner = Console.ReadLine().Trim();

            Console.Write("Duration Insurance Contract:");
            DurationInCo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Amount of money for Insurance Contract:");
            AmountOfMoney = Convert.ToDouble(Console.ReadLine());

            IsLongTimeInCo = (DurationInCo > 12);

            if (IsLongTimeInCo)
            {
                MonthlyPayment = AmountOfMoney / DurationInCo;
            }
        }

        public void Display()
        {
            Console.Write("Owner Insurance Contract:" + NameOwner);
            NameOwner = Console.ReadLine().Trim();

            Console.Write("Duration Insurance Contract:" + DurationInCo);
           
            Console.Write("Amount of money for Insurance Contract:"+ AmountOfMoney);

            
            if (IsLongTimeInCo)
            {
                Console.Write("Monthly payment for Insurance Contract:" + MonthlyPayment);
            }
            
        }




    }
}

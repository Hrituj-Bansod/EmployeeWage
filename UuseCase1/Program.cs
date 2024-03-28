using System;
using System.Diagnostics;

namespace UuseCase1
{
    internal class UC1
    {
        public void EmpPresentOrAbsent() 
        {
            Random random = new Random();
            int result = random.Next(2);

            if (result == 0)
            {
                Console.WriteLine("Employee is ABSENT");
            }
            else 
            {
                Console.WriteLine("Employee is PRESENT");
            }
        }

        public void CalculateEmpWage()
        {
            int EmpHrs = 0;
            int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int result = random.Next(2);
            if (result == 0)
            {
                EmpHrs = 0;
            }
            else
            {
                EmpHrs = 8;
            }

            int EmpWage = EmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(EmpWage);
        }

        static void Main(string[] args)
        {
            UC1 uc1 = new UC1();
            uc1.EmpPresentOrAbsent();
            
        }
    }
}

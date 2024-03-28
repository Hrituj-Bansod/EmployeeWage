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
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            int empWage = 0;
            Random random = new Random();
            int result = random.Next(2);
            if (result == 0)
            {
                empHrs = 0;
            }
            else
            {
                empHrs = 8;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(empWage);
        }

        public static void EmpPartOrFull()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int result = random.Next(3);
            if (result == FULL_TIME)
            {
                empHrs = 8;
            }
            else if (result == PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(empWage);
        }

        public static void uSingSwitchCase()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int check = random.Next(3);

            switch (check)
            {
                case FULL_TIME:
                    empHrs = 8;
                    break;

                case PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(empWage);
        }




        static void Main(string[] args)
        {
            UC1 uc1 = new UC1();
            //uc1.EmpPresentOrAbsent();
            UC1.EmpPartOrFull();
        }
    }
}

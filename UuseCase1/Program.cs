using System;

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

        static void Main(string[] args)
        {
            UC1 uc1 = new UC1();
            uc1.EmpPresentOrAbsent();
            
        }
    }
}

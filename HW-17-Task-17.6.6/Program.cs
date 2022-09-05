using System;
using HW_17_Task_17._6._6.Profiles;

namespace HW_17_Task_17._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();

            // для примера, чтобы проверить результаты
            account.Balance = 3000;
            
            account.Calculate(new CalculateNormal());
            Console.WriteLine();
            account.Calculate(new CalculateSalary());
            Console.WriteLine();
            account.Calculate(new CalculateCredit());
            Console.WriteLine();
        }
    }
}

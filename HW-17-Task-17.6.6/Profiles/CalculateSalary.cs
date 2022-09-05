using System;
using System.Collections.Generic;
using System.Text;

namespace HW_17_Task_17._6._6.Profiles
{
    public class CalculateSalary : ICalculateInterest
    {
        /// <summary>
        /// расчет процентной ставк зарплатного аккаунта по правилам банка
        /// </summary>
        /// <param name="account"></param>
        public void Execute(double balance, double interest)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Console.WriteLine("расчет процентной ставк зарплатного аккаунта по правилам банка");
            interest = balance * 0.5;
            Console.WriteLine(interest);
        }
    }
}

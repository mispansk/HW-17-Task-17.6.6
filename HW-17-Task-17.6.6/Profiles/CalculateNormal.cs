using System;
using System.Collections.Generic;
using System.Text;

namespace HW_17_Task_17._6._6.Profiles
{
    public class CalculateNormal : ICalculateInterest
    {
        /// <summary>
        /// расчет процентной ставки обычного аккаунта по правилам банка
        /// </summary>
        /// <param name="account"></param>
        public void Execute(double balance, double interest)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Console.WriteLine("расчет процентной ставки обычного аккаунта по правилам банка:");
            interest = balance * 0.4;

            if (balance < 1000)
                interest -= balance * 0.2;

            // далее в задании идет 
            //if (balance < 50000)
            //    interest -= balance * 0.4;
            //    но тогда результат будет отрицательный иногда, т.к. выполняется и предыдущее условие, поэтому
            //    я немного исправила диапазон баланса

            if (balance < 50000 & balance >= 1000)
                // если делать так , как ниже, то всегда результат будет 0, поэтому я поменяла на 0.3
                // interest -= balance * 0.4;  
                interest -= balance * 0.3;
            Console.WriteLine(interest);
        }
    }
}

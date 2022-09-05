using System;
using System.Collections.Generic;
using System.Text;

namespace HW_17_Task_17._6._6.Profiles
{
    public class CalculateCredit : ICalculateInterest
    {
        /// <summary>
        /// создали новый класс, кредитный аккаунт
        /// </summary>
        /// <param name="account"></param>
        public void Execute(double balance, double interest)
        {
            // расчет процентной ставк кредитного аккаунта по правилам банка
            Console.WriteLine("расчет процентной ставк кредитного аккаунта по правилам банка");
            interest = balance * 0.9;
            Console.WriteLine(interest);
        }
    }
}

using HW_17_Task_17._6._6.Profiles;
using System;
using System.Collections.Generic;
using System.Text;


namespace HW_17_Task_17._6._6
{
    /// <summary>
    /// класс учетной записи
    /// </summary>
    public class Account
    {
        // тип учетной записи, убираем, теперь он нам не нужен (реализован в соответствующих классах)
        //public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
        public void Calculate(ICalculateInterest calculateInterest)
        {
            calculateInterest.Execute( Balance, Interest);
        }
    }
}

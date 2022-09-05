using System;
using System.Collections.Generic;
using System.Text;

namespace HW_17_Task_17._6._6.Profiles
{
    /// <summary>
    /// Общий интерфейс для профилей учетной записи
    /// </summary>
    public interface ICalculateInterest
    {
        void Execute(double balance, double interest);
    }
}

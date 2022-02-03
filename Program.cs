using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratoryWork
{
    public delegate double MoneyConvertDelegate(double value);
    class Program
    {
        //public delegate double MoneyConvertDelegate(double value);
        static void Main(string[] args)
        {
            Money money=new Money("dollar",200);
            MoneyConvertDelegate convert = null;
            convert += delegate (double amount)
             {
                 Console.WriteLine($"{ amount}$ = { amount * 75} Rub");
                 return amount;
             };
            convert += delegate (double amount)
            {
                Console.WriteLine($"{ amount}$ = { amount / 1.13} Euro");
                return amount;
            };
            convert += delegate (double amount)
            {
                Console.WriteLine($"{ amount}$ = { amount * 0.0087} Yen");
                return amount;
            };
            convert += (double amount) =>
              {
                  Console.WriteLine($"{ amount}$ = { amount / 1809.34} Oz Gold");
                  return amount;
              };
            money.convertMoney(convert);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratoryWork
{
    class Money
    {
        private string currencyCode;
        public double amount;

        public Money()
        {
            currencyCode = null;
            amount = 0;
        }

        public Money(string currencyCode,double amount)
        {
            this.currencyCode = currencyCode;
            this.amount = amount;
        }
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { this.currencyCode = currencyCode; }
        }
        public double Amount
        {
            get { return amount; }
            set { this.amount = amount; }
        }
        public override string ToString()
        {
            return $"\tYour balance = {amount} {currencyCode}\n";
        }
        //public  delegate double MoneyConvertDelegate(double value);

        public void convertMoney(MoneyConvertDelegate all_convert)
        {
            //Console.WriteLine("please enter amount");
            //double a = Convert.ToDouble(Console.ReadLine());
            foreach(MoneyConvertDelegate operation in all_convert.GetInvocationList())
            {
                Console.WriteLine($"result convert {operation(amount)}");
            }
        }
    }
}

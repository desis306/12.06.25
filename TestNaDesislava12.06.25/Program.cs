using System.Transactions;

namespace TestNaDesislava12._06._25
{
    internal class Program
    {
        public class BankAccount
        {
            private int id;
            private double balance;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public double Balance
            {
                get { return balance; }
            }
            public void Deposit(double amount)
            {
                balance += amount;
            }
            public void Withdraw(double amount)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine($"Недостатъчна наличност.");
                }
            }
            public override string ToString()
            {
                return $"ID: {id}, Balance {balance:F2}";
            }
        }
        static void Main(string[] args)
        {
           BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Deposit(15);
            acc.Withdraw(5);

            Console.WriteLine(acc.ToString());
        }
    }
}

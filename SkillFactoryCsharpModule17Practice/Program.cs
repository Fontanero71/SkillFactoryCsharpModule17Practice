using System;

namespace SkillFactoryCsharpModule17Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usualAcc = new Account() { Type = "Обычный", Balance = 500, Interest = 0 };
            ICalculator usualcalc = new UsualCalculator();
            usualcalc.CalculateInterest(usualAcc);
            Console.WriteLine($"{usualAcc.Interest}");

            var salaryAcc = new Account() { Type = "Зарплатный", Balance = 500, Interest = 0 };
            ICalculator salarycalc = new SalaryCalculator();
            salarycalc.CalculateInterest(salaryAcc);
            Console.WriteLine($"{salaryAcc.Interest}");
        }
    }
    
    public interface ICalculator
    {
        void CalculateInterest(Account account);
    }

    public class Account
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
    }
    public class UsualCalculator: ICalculator
    {
        // Метод для расчета процентной ставки
        public void CalculateInterest(Account account)
        {
            
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance < 50000)
                    account.Interest -= account.Balance * 0.4;
            
        }
    }
    public class SalaryCalculator : ICalculator
    {
        // Метод для расчета процентной ставки
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}

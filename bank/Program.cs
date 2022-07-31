using System;
using Practice.Models;

// Есть базовый абстрактный клас банк,у него есть свойства название, 
// процент кредита, общая сумма которая есть в банку и есть метод, 
// который считает максимальное количество людей, которому может выдать кредит. 
// кредит дают только 100.000 на год). Метод который выводит название, процент банка. 
// И есть метод абстрактный CalculateProfit,который считает прибыль банка через год. 
// Создать два класса Приват Банк в этом классе метод CalculateProfit до суммы приболи добавляет 30000, 
// процент кредита 10 процентов, ОщадБанк 9 процентов в этом классе в методе CalculateProfit отнимает от общей суммы 10000

namespace Practice
{

    public static class Program
    {
        public static void Main(string[] args)
        {
            Bank[] banks = new Bank[2] { new PrivatBank(500000), new OshchadBank(1000000) };

            foreach (var bank in banks)
            {
                bank.ShowNameAndProcent();
                bank.AddCredit();
                Console.WriteLine(bank.CalculateProfit());
                Console.WriteLine();
            }

        }
    }
}

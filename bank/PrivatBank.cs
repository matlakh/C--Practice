using System;

namespace Practice.Models
{
    public class PrivatBank : Bank
    {
        public PrivatBank(double capital)
        : base("PrivateBank", 10, capital)
        {

        }

        public override double CalculateProfit()
        => (_capital + _activeCountOfPeople * _maxSumOnYear + _activeCountOfPeople * (_maxSumOnYear * _procent / 100)) + 30000;
    }
}
using System;

namespace Practice.Models
{
    public class OshchadBank : Bank
    {
        public OshchadBank(double capital)
        : base("OshchadBank", 9, capital)
        {

        }

        public override double CalculateProfit()
        => (_capital + _activeCountOfPeople * _maxSumOnYear + _activeCountOfPeople * (_maxSumOnYear * _procent / 100)) - 10000;
    }
}
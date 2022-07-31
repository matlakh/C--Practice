using System;
namespace Practice.Models
{
    public abstract class Bank
    {
        protected const int _maxSumOnYear = 100000;
        protected int _activeCountOfPeople;
        private string _name;
        protected double _procent;
        protected double _capital;

        public Bank(string name, double procent, double capital)
        {
            _name = name;
            _procent = procent;
            _capital = capital;
        }

        public void ShowNameAndProcent()
        {
            Console.WriteLine(this._name + " has a " + this._procent + " procent");
        }
        public double GetMaxCountOfPeople()
        => _capital / _maxSumOnYear;

        public abstract double CalculateProfit();

        public void AddCredit()
        {
            if (_capital >= _maxSumOnYear)
            {
                _activeCountOfPeople++;
                _capital -= _maxSumOnYear;
                return;
            }

            Console.WriteLine("No Money!");
        }
    }
}
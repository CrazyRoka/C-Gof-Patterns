using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Company : ICompany
    {
        private List<IInvestor> _investors = new List<IInvestor>();
        private double _cash = 0;
        public string Name { get; private set; }
        public double Cash
        {
            get => _cash;
            set
            {
                if (_cash != value)
                {
                    _cash = value;
                    Notify();
                }
            }
        }
        public Company(string name) => Name = name;

        public void Attach(IInvestor investor) => _investors.Add(investor);

        public void Detach(IInvestor investor) => _investors.Remove(investor);

        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ICompany
    {
        string Name { get; }
        double Cash { get; }
        void Attach(IInvestor investor);
        void Detach(IInvestor investor);
        void Notify();
    }
}

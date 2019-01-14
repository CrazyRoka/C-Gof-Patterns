using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    interface Handler
    {
        Handler SetSuccessor(Handler handler);
        void Handle(object request);
    }
}

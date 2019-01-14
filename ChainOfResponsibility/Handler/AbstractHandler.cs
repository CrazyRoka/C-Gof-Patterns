using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    abstract class AbstractHandler : Handler
    {
        protected Handler _successor;

        public virtual void Handle(object request)
        {
            if (_successor != null)
            {
                _successor.Handle(request);
            }
            else
            {
                Console.WriteLine("Request was unhandled");
            }

        }

        public Handler SetSuccessor(Handler successor) => _successor = successor;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_23
{
    public interface ISubject
    {
        void Attach(ISubscriber observer);

        void Detach(ISubscriber observer);

        void Notify();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_23
{
    public interface ISubscriber
    {
        void Update(ISubject subject);
    }
}

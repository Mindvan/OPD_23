using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_23
{
    // Обеспечьте возможность подписки на событие в нескольких классах
    public class SubscriberC : ISubscriber
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Подписчик #3, разумеется, получил следующее сообщение: {0}", (subject as Countdown).message);
        }
    }
}

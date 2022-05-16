using System;
using System.Collections.Generic;
using System.Threading;

namespace OPD_23
{
    /* Разработайте класс Countdown, реализующий возможность передачи сообщения любому подписчику, 
     * подписавшемуся на событие, после назначенного времени */

    public class Countdown:ISubject 
    {
        public string message { get; private set; } = "";

        private List<ISubscriber> _observers = new List<ISubscriber>();

        public void Attach(ISubscriber observer)
        {
            _observers.Add(observer); 
        }
        public void Detach(ISubscriber observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Вы можете использовать метод Thread.Sleep() для создания эффекта ожидания.

        public void SendMessages(string message, int time)
        {
            this.message = message;
            Thread.Sleep(time);
            Notify();
        }
    }
}

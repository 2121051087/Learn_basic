using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.Event
{
    public class Publisher
    {
        public delegate void NotifyNews(object data);
        public event NotifyNews event_new;
        public void Send()
        {
            event_new?.Invoke("co tin moi");
        }
    }
    public class DelegateEvent
    {
        public void Sub (Publisher p)
        {
            p.event_new += ReceiverFromPublisher;

        }
        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("- TestEvent : " + data.ToString());
        }
    }
    public class SubscriberA
    {
        public void Sub(Publisher p)
        {
            
            p.event_new += ReceiverFromPublisher;

        }
        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("- SubcriberA : " + data.ToString());
        }

    }
    public class SubscriberB
    {
        public void Sub(Publisher p)
        {
            
            p.event_new += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("- SubscriberB : " + data.ToString());
        }
    }
}

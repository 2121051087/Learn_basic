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
        public NotifyNews event_new;
        public void Send()
        {
            event_new?.Invoke("co tin moi");
        }
    }
    public class TestEvent
    {
        public void Sub (Publisher p)
        {
            p.event_new += ReceiverFromPublisher;

        }
        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("Subscriber :" + data.ToString());
        }
    }
    public class SubscriberA
    {
        public void Sub(Publisher p)
        {
            p.event_new = null;
            p.event_new += ReceiverFromPublisher;

        }
        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("Subcriber :" + data.ToString());
        }

    }
    public class SubscriberB
    {
        public void Sub(Publisher p)
        {
            p.event_new = null;
            p.event_new += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("- SubscriberB :" + data.ToString());
        }
    }
}

using System;
using System.Collections;

namespace EventsPage
{
    internal class Event
    {
        string name;
        string time;
        public Event(object e)
        {string temp = (string)e;
            name = temp;
            int i = temp.IndexOf(",");
            time = temp.Substring(i);
            name = temp.Substring(0,i);
        }
        public string getName()
        {
            return name;
        }
        public string returnTime()
        { return time; }
    }
}
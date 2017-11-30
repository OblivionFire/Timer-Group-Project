using System;
using System.Collections;
using System.Windows.Forms;

namespace EventsPage
{
    internal class Event
    {
        string name;
        string endTime;
        string startTime;
        public Event(object e)
        {
            string temp = (string)e;
            int i = temp.IndexOf(',');
           //firgure out format for times
            name = temp.Substring(0,i);
            string timers = temp.Substring(i+1);
            i = timers.IndexOf(",");
            startTime = timers.Substring(0,i);
            endTime = timers.Substring(i+1);
            return;
        }
        public string getName()
        {
            return name;
        }
        public string getStartTime()

        { return startTime; }

        public string getEndTime()
        {
            return endTime;
        }
    }
}
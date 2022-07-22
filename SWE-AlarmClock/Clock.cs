using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_AlarmClock
{
    class Clock
    {
        // 'delegate' is a data type for an 'event'
        public delegate void TimeUpdatedHandler(DateTime _time);
        public event TimeUpdatedHandler TimeUpdated;

        private DateTime time; // DateTime is a C# data type

        public Clock()
        {
            Start();
        }

        public void Start()
        {
            Task.Run(() => { // Causes the task to run in the background
                // this prevents the following loop from blocking execution
                // of other code in the application.

                int lastSeconds = time.Second;
                while (true)
                {
                    time = DateTime.Now; // for as long as program is running, time is set to current time (now)
                    if(time.Second != lastSeconds)
                    {
                        if (TimeUpdated != null)
                        {
                            // event fires every time the second changes
                            TimeUpdated(time);
                            lastSeconds = time.Second;
                        }
                    }
                }
            });
        }
    }
}

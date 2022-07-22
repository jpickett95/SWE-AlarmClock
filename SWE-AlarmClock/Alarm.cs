using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_AlarmClock
{
    class Alarm
    {
        private DateTime alarmTime;
        private bool isOn = true;
        public Alarm(DateTime _time)
        {
            alarmTime = _time;
        }

        public void UpdatedTime(DateTime _time)
        {
            if (!isOn) { return; }
            if(_time >= alarmTime)
            {
                for(int i = 0; i < 5; ++i)
                {
                    Console.Beep();
                }
                isOn = false;
            }
        }
    }
}

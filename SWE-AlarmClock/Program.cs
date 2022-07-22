using System;

namespace SWE_AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.TimeUpdated += UpdatedTime; // used '+=' because you can listen to multiple things

            Alarm alarm1 = new Alarm(DateTime.Now.AddSeconds(30));
            clock.TimeUpdated += alarm1.UpdatedTime;

            Alarm alarm2 = new Alarm(DateTime.Now.AddSeconds(5));
            clock.TimeUpdated += alarm2.UpdatedTime;

            while (true)
            {
                
            }
        }

        static void UpdatedTime(DateTime _time)
        {
            Console.Clear();
            Console.WriteLine(_time.ToLongTimeString());
        }
    }
}

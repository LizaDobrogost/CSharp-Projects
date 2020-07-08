using System.Threading;
using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Stopwatch();
            TimeSpan duration;
            DateTime start = default, stop = default;
            bool menu = true;
            var key = 0;
            while (menu)
            {
                Console.WriteLine("1-Start timer 2-Stop timer 3-Duration 4-Exit");
                key = Int32.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        if (!time.Active)
                        {
                            start = time.Start();
                            Console.WriteLine("Time:" + start.Hour + ":" + start.Minute + ":" + start.Second);
                        }
                        else
                        {
                            throw new InvalidOperationException("Timer is already running!");
                        }
                        break;
                    case 2:
                        if (time.Active)
                        {
                            stop = time.Stop();
                            Console.WriteLine("Time:" + stop.Hour + ":" + stop.Minute + ":" + stop.Second);
                        }
                        else
                        {
                            throw new InvalidOperationException("Timer is already stopped!");
                        }

                        break;
                    case 3:
                        duration = stop - start;
                        Console.WriteLine("Duration is:" + duration.Hours + ":" + duration.Minutes + ":" + duration.Seconds);
                        break;
                    case 4:
                        menu = false;
                        break;

                }

            }

        }


    }
}
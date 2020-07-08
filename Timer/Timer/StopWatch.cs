using System;

namespace Ex2
{
    class Stopwatch
    {
        private DateTime start;
        private DateTime stop { get; set; }
        private bool isActive;

        public DateTime str
        {
            get => start;
            set
            {
                start = value;
            }
        }

        public bool Active
        {
            get => isActive;
            set
            {
                isActive = value;
            }
        }
        public DateTime Start()
        {
            start = new DateTime();
            start = DateTime.Now;
            isActive = true;
            return start;
        }
        public DateTime Stop()
        {
            stop = new DateTime();
            stop = DateTime.Now;
            isActive = false;
            return stop;
        }

    }
}
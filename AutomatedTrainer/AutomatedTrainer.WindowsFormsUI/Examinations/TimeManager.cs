using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedTrainer.WindowsFormsUI.Examinations
{
    class TimeManager
    {
        public const int TICK_INTERVAL = 1000;

        private int TicksElapsed { get; set; }

        private Timer Timer { get; set; }

        public TimeManager(Timer timer)
        {
            TicksElapsed = 0;
            Timer = timer;
            timer.Interval = TICK_INTERVAL;
        }

        public int Step()
        {
            TicksElapsed++;

            return TicksElapsed;
        }

        public void Start()
        {
            Timer.Start();
        }

        public void Stop()
        {
            Timer.Stop();
        }

        public bool IsRun()
        {
            return Timer.Enabled;
        }
    }

}

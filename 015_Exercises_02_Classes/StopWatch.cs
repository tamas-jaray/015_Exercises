using System;

namespace _015_Exercises_02_Classes
{
    public class StopWatch
    {
        private DateTime _timeOfStart;
        private DateTime _timeOfStop;
        private TimeSpan _duration;
        private Boolean IsRunning = false;

        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Cannot start again, the stopwatch is already running!");

            }
            else
            {
                _timeOfStart = DateTime.Now;
                IsRunning = true;
            }
        }

        public void Stop()
        {
            if (IsRunning)
            {
                _timeOfStop = DateTime.Now;
                IsRunning = false;
            }
            else
            {
                throw new InvalidOperationException("Cannot stop, because the stopwatch is not running!");
            }
        }
        public TimeSpan Duration()
        {
            _duration = _timeOfStop - _timeOfStart;
            return _duration;
        }

    }
}

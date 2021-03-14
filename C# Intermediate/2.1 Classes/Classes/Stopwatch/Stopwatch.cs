using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private bool _isRunning = false;
        private DateTime _startTime;
        private TimeSpan _duration;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch may not be started twice");
            _isRunning = true;

            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if(!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running");

            _duration = DateTime.Now - _startTime;
        }

        public TimeSpan GetDuration()
        {
            _isRunning = false;
            return _duration;
        }
    }
}

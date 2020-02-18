using System;

namespace exerciseClass
{
    public class Stopwatch
    {
        private DateTime _begin;
        private DateTime _end;
        public TimeSpan Duration { get; private set; }

        public Stopwatch()
        {
            Duration = TimeSpan.Zero;
        }

        public void Start()
        {
            if (_begin != _end)
                throw new InvalidOperationException();
            else 
                _begin = DateTime.Now;
        }

        public void Stop()
        {
            _end = DateTime.Now;
            Duration += _end - _begin;
            _begin = _end;
        }
    }
}
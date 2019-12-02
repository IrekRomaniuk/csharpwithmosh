using System;
namespace Stopwatch
{
    public class Stopwatch1
    {
        private DateTime _start;
        private DateTime _stop;
        /*public Stopwatch1()
        {
            this._time = DateTime.Now;
        }*/
        public void Start()
        {
            
            if (_start < _stop)
            {
                throw new InvalidOperationException("Invalid...");
            }
            _start = DateTime.Now;

        }
        public void Stop()
        {
            
            if (_start < _stop)
            {
                throw new InvalidOperationException("Invalid...");
            }
            _stop = DateTime.Now;
        }
        public TimeSpan Duration()
        {
            return _stop - _start;
        }
    }
}
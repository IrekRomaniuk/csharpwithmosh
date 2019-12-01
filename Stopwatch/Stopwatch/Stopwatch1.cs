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
            
            if (this._start < this._stop)
            {
                throw new InvalidOperationException("Invalid...");
            }
            this._start = DateTime.Now;

        }
        public void Stop()
        {
            
            if (this._start < this._stop)
            {
                throw new InvalidOperationException("Invalid...");
            }
            this._stop = DateTime.Now;
        }
        public TimeSpan Duration()
        {
            return _stop - this._start;
        }
    }
}
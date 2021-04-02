using System.Diagnostics;

namespace CSharpJs.Util
{
    public class TimeCheckExcute
    {
        private Stopwatch sw = new Stopwatch();
        private long milliseconds;

        public long Milliseconds { get => milliseconds; set => milliseconds = value; }

        public TimeCheckExcute(long milliseconds)
        {
            Milliseconds = milliseconds;
            sw.Start();
        }

        public void Reset()
        {
            sw.Restart();
        }

        public bool IsNext()
        {
            if (sw.ElapsedMilliseconds > Milliseconds)
            {
                sw.Restart();
                return true;
            }

            return false;
        }

        public long GetElapsedMilliseconds()
        {
            return sw.ElapsedMilliseconds;
        }
    }
}

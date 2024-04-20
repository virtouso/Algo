namespace Algorithms.Problems
{
    public class CoutTimeIntervalsInPeriod
    {
        public int CountIntervals(string start, string end)
        {
            var sn = start.Split(':');
            var en = end.Split(':');
            var sh = start[0];
            var sm = start[1];
            var eh = end[0];
            var em = end[1];

            var s = sh * 60 + sm;
            var e = eh * 60 + em;

            if (e < s)
                e = (12 * 60) - s + e;

            int counter = 0;
            int state = s;
            while (state<e)
            {
                if (state + 15 < e) counter++;
                state += 15;
            }

            return counter;
        }


        public void Run()
        {
            
        }
    }
}
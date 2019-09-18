using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMemoryLeakSample
{
    public class Counter
    {
        public static Counter Default { get; } = new Counter();

        int count = 0;
        public int Count { get => count; }

        private Counter()
        {
        }

        public void CountUp() => count++;
    }
}

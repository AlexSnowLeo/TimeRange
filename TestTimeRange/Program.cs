using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTimeRange
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeRange test = new TimeRange();

            test.Update(TimeSpan.FromSeconds(10));
            test.Update(TimeSpan.FromSeconds(6));
            test.Update(TimeSpan.FromSeconds(3));
            test.Update(TimeSpan.FromSeconds(12));
            test.Update(TimeSpan.FromSeconds(4));
            test.Update(TimeSpan.FromSeconds(3));
            test.Update(TimeSpan.FromSeconds(8));
        }
    }
}

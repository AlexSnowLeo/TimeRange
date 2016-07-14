using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTimeRange
{
    public class TimeRange
    {
        public TimeSpan Min { get; protected set; }

        public TimeSpan Max { get; protected set; }

        public void Update(TimeSpan source)
        {
            if (Min == TimeSpan.Zero || (Min > source && source < Max))
            {
                Min = source;
            }
            if (Max == TimeSpan.Zero || (Max < source && source > Min))
            {
                Max = source;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Min, Max);
        }
    }
}

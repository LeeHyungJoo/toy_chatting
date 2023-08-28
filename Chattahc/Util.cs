using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattahc
{
    public static class Util
    {
        public static long GetTimeStampMS() =>  System.DateTime.UtcNow.Ticks;
    }
}

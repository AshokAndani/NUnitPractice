using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
      public class Math
    {
        public long Add(int x, int y)
        {
            long s = x;
            long result = s + y;
            return result;
        }
        public int divide(int x, int y)
        {
            if(y== 0)
            {
                return 0;
            }
            return x / y;
        }
    }
}

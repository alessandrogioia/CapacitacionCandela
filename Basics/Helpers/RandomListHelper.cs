using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Helpers
{
    public static class RandomListHelper
    {

        public static List<int> Generate(int length, int min = 0, int max = 10000)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
                list.Add(rnd.Next(min, max));

            return list;
        }

    }
}

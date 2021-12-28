using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Helpers
{
    public static class MaxMinIntegerHelper
    {

        public static int Maxvalue (List<int> list)
        {
            int value = list[0];
            for (int i = 1; i < list.Count(); i++)
            {
                if (value < list[i])
                {
                    value = list[i];
                }
            }
            
            return value;
        }
        public static int Minvalue(List<int> list)
        {
            int value = list[0];
            for (int i = 1; i < list.Count(); i++)
            {
                if (value > list[i])
                {
                    value = list[i];
                }
            }

            return value;
        }


    }
}

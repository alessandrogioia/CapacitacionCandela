using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Helpers
{
    public static class FirstRepeatedHelper
    {

        public static int? PrimerRepetido(List<int> list)
        {
            var start = DateTime.Now;

            int? value = null;

            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = i + 1; j < list.Count(); j++)
                {
                    if (list[i] == list[j])
                    {
                        value = list[i];
                        break;
                    }
                }

                if (value.HasValue)
                    break;

            }

            var time = (DateTime.Now - start).TotalMilliseconds;

            return value;
        }


        public static int? PrimerRepetidoTempEspacial(List<int> list)
        {
            int? result = null;
            int max_value = MaxMinIntegerHelper.Maxvalue(list);

            int?[] array = new int?[max_value + 1];

            foreach (var item in list)
            {
                if (array[item] != null)
                {
                    result = item;
                    break;
                }
                array[item] = item;
            }



            return result;
        }

     
    }
}

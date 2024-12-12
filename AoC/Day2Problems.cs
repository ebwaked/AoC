using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC
{
    class Day2Problems
    {

        public int Day2(List<List<string>> data)
        {
            AoCFunctions aoc = new AoCFunctions();
            int res = 0;

            var convertedData = aoc.convertStringToIntList(data);

            foreach (var item in convertedData)
            {
                if ((aoc.IsAscending(item) || aoc.IsDescending(item)) && aoc.IsDistinct(item))
                {
                    res++;
                }

            }

            Console.Write(res);
            return res;
        }

        public int Day2Part2(List<List<string>> data)
        {
            AoCFunctions aoc = new AoCFunctions();
            int res = 0;

            var convertedData = aoc.convertStringToIntList(data);

            foreach (var item in convertedData)
            {
                if ((aoc.IsAscending(item) || aoc.IsDescending(item)) && aoc.IsDistinct(item))
                {
                    res++;
                }
                else
                {
                    var baseItem = item.AsReadOnly();
                    for (int i = 0; i < item.Count; i++)
                    {
                        var newBase = baseItem.ToArray().ToList();
                        newBase.RemoveAt(i);
                        if ((aoc.IsAscending(newBase) || aoc.IsDescending(newBase)) && aoc.IsDistinct(newBase))
                        {
                            res++;
                            i = item.Count;
                            continue;
                        }
                    }
                }


            }
            
            Console.Write(res);
            return res;
        }

    }
}

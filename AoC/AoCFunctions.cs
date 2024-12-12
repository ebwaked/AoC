using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AoC
{
    public class AoCFunctions
    {
        public List<List<int>> convertStringToIntList(List<List<string>> stringList)
        {
            List<List<int>> ints = new List<List<int>>();

            foreach (var item in stringList)
            {
                ints.Add(item.Select(int.Parse).ToList());
            }

            return ints;
        }

        public bool IsAscending(List<int> ints)
        {
            var asc = ints.OrderBy(d => d);
            if (ints.SequenceEqual(asc))
            {
                if (IsWithinRange(ints, "asc"))
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
        }

        public bool IsDescending(List<int> ints)
        {
            var desc = ints.OrderByDescending(d => d);
            if (ints.SequenceEqual(desc))
            {
                if (IsWithinRange(ints, "desc"))
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
        }

        public bool IsWithinRange(List<int> ints, string order)
        {
            bool res = false;

            for (var lvl = 0; lvl < ints.Count - 1; lvl++)
            {
                if (order == "asc")
                {
                    if (((ints[lvl] - ints[lvl + 1]) < 0) && ((ints[lvl] - ints[lvl + 1]) >= -3))
                    {
                        res = true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (((ints[lvl] - ints[lvl + 1]) > 0) && (ints[lvl] - ints[lvl + 1]) <= 3)
                    {
                        res = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return res;
        }

        public bool IsDistinct(List<int> ints)
        {
            return ints.Count == ints.Distinct().Count();
        }

        
    }
}

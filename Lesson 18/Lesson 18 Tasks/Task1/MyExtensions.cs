using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MyExtensions
    {
        public static bool WhereMy(this List<string> list, string text)
        {
            if (list.Contains(text))
            {
                return true;
            }

            return false;
        }

        public static string FirstOrDefaultMy(this List<string> list)
        {
            if (list is null)
                return null;

            return list.First().ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.CodeKata
{
    class Hasher<T>
    {
        public static int NumberOfHashFunction { get; set; }
        

        public static IEnumerable<int> GetHash(T element)
        {
            for (int i = 0; i < NumberOfHashFunction; i++)
            {
               yield return (element.GetHashCode() & i) << 16;
            }
        }


    }
}

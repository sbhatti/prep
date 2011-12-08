using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.CodeKata
{
    class Hasher<T>
    {
        static int NumberOfHashFunction { get; set; }
        
        //public  static int GetHash(T element)
        //{
        //    return element.GetHashCode();
        //}

        public static IEnumerable<int> GetHash(T element)
        {
            for (int i = 0; i < NumberOfHashFunction; i++)
            {
               yield return (element.GetHashCode() & i) << 16;
            }
        }


    }
}

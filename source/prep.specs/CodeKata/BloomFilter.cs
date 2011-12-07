using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.specs.CodeKata
{
    class BloomFilter
    {
        const int filterSize = 10;
        
        BitArray filter = new BitArray(filterSize);

        public void AddElement(string element)
        {
            int hashCode = element.GetHashCode();

            int index = hashCode%filterSize;

            filter[index] = true;
        }


        public bool Contains(string element)
        {
            int hashCode = element.GetHashCode();

            int index = hashCode % filterSize;

            return filter[index];

        }



    }
}

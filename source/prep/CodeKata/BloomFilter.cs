using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.CodeKata
{
    class BloomFilter
    {
        private const int filterSize = 10; 
        BitArray filter = new BitArray(filterSize);

        public void AddElement(string element)
        {
            foreach (int hash in Hasher<string>.GetHash(element))
                filter[hash%filterSize] = true;
        }

        public bool Contains(string element)
        {
            
            foreach (int hash in Hasher<string>.GetHash(element))
            {
                if (!filter[hash % filterSize]) return false;
            }
            return true;
        }

    }
}

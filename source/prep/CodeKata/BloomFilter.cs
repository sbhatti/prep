using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.CodeKata
{
    class BloomFilter<ElementType>
    {
        private int filterSize; 
        BitArray filter;
        private int HashSize { get; set; }

        public BloomFilter(int filterSize, int hashSize)
        {
            this.filterSize = filterSize;
            HashSize = hashSize;
            filter = new BitArray(filterSize);
            
        }

        public void AddElement(ElementType element)
        {
            foreach (int hash in Hasher<ElementType>.GetHash(element))
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

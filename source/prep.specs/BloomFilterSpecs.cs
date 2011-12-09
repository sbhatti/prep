
using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;

namespace prep.specs
{
    class BloomFilterSpecs
    {
        public abstract class bloomFilter_concern : Observes
        {
           
        };

        public class when_counting_the_number_of_movies : bloomFilter_concern
        {
            static int number_of_filters;

        }
    }
}

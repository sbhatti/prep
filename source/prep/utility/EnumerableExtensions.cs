using System;
using System.Collections.Generic;
using prep.collections;
using prep.utility.filtering;
using prep.utility.sorting;

namespace prep.utility
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
    {
      return new LazyEnumerable<T>(items);
    }

    public static IEnumerable<ItemToMatch> all_items_matching<ItemToMatch>(this IEnumerable<ItemToMatch> items,IMatchAn<ItemToMatch> specification)
    {
      return items.all_items_matching(specification.matches);
    }
    static IEnumerable<ItemToMatch> all_items_matching<ItemToMatch>(this IEnumerable<ItemToMatch> items,Condition<ItemToMatch> condition)
    {
      return new FilteringEnumerable<ItemToMatch>(items, condition);
    }

    public static IEnumerable<T> sort_using<T>(this IEnumerable<T> items, IComparer<T> comparer)
    {
      var sorted = new List<T>(items);
      sorted.Sort(comparer);
      return sorted;
    }

    public static IEnumerable<ItemType> sort_by_descending<ItemType, PropertyType>(this IEnumerable<ItemType> items, Func<ItemType, PropertyType> accessor) where PropertyType : IComparable, IComparable<PropertyType>
    {
        //List<ItemType> obj = new List<ItemType>();
        //obj.AddRange(items);
        //return obj.Sort(); 


        var comparer = Order<ItemType>.by_descending(accessor);

        return items.sort_using(comparer);
    }

    public static IEnumerable<ItemType> sort_by<ItemType, PropertyType>(this IEnumerable<ItemType> items, Func<ItemType, PropertyType> accessor) where PropertyType : IComparable, IComparable<PropertyType>
    {
        //List<ItemType> obj = new List<ItemType>();
        //obj.AddRange(items);
        //return obj.Sort(); 


        var comparer = Order<ItemType>.by(accessor);

        return items.sort_using(comparer);
    }


  }
}
using System;
using System.Collections.Generic;
using System.Linq;


public static class Extention
{
    public static IEnumerable<int> Test(this IEnumerable<int> source,int dummy)
    {
        foreach (var item in source)
        {
            if (item > dummy)
                yield return item;
        }
    }

    public static IEnumerable<int> Add(this IEnumerable<int> soure)
    {
        foreach (var item in soure)
        {
            yield return item + 5;
        }
    }
    public static IEnumerable<int> Add1(this IEnumerable<int> soure)
    {
        List<int> lll = new List<int>();
        foreach (var item in soure)
        {
            lll.Add(item + 5);
        }
        return lll;
    }
    public static IEnumerable<int> Test1(this IEnumerable<int> source, int dummy)
    {
        List<int> l = new List<int>();
        foreach (var item in source)
        {
            if (item > dummy)
                l.Add(item);
        }
        return l;
    }
    public static IEnumerable<int> Multiple(this IEnumerable<int>source,int dummy)
    {
        List<int>list=new List<int>();
        foreach (var item in source)
        {
            yield return item * dummy;
        }
    }
    public static IEnumerable<int> Multiple1(this IEnumerable<int> source, int dummy)
    {
        List<int>list1=new List<int>();
        foreach(var item in source)
        {
            list1.Add(item*dummy);
        }
        return list1;
    }
    public static IEnumerable<int> Div(this IEnumerable<int> source, int dummy)
    {
        List<int> list = new List<int>();
        foreach (var item in source)
        {
            yield return item /dummy;
        }
    }

    public static IEnumerable<int> Div1(this IEnumerable<int> source, int dummy)
    {
        List<int> list1 = new List<int>();
        foreach (var item in source)
        {
            list1.Add(item / dummy);
        }
        return list1;
    }


    //TO DO
    //public static IEnumerable<int> _Select(this IEnumerable<int> source, Func<int, int> selector)
    //{
    //    if (source == null) throw new ArgumentExeptionNull("source");
    //    if (selector == null) throw new ArgumentExeptionNull("selector");

    //    return new WhereSelectEnumerableIterator<TSource, TResult>(source, null, selector);
    //}
}


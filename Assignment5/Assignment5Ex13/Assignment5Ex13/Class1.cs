using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5Ex13
{
    public static class EnumerableExtension
    {
        public static bool CustomAll<T>(this IEnumerable<T> source, Func<T, bool> function)
        {
            if (source == null)
            {
                throw new NullReferenceException();
            }
            foreach (var item in source)
            {
                if (!function(item)) return false;
            }
            return true;
        }
        public static bool CustomAny<T>(this IEnumerable<T> source, Func<T, bool> function)
        {
            if (source == null)
            {
                throw new NullReferenceException();
            }
            foreach (var item in source)
            {
                if (function(item)) return true;
            }
            return false;
        }
        public static T CustomMax<T>(this IEnumerable<T> source, Func<T, T, T> function)
        {
            if (source == null)
            {
                throw new NullReferenceException();
            }
            var max = source.First();
            foreach (var item in source)
            {
                max = function(item, max);
            }
            return max;
        }
        public static T CustomMin<T>(this IEnumerable<T> source, Func<T, T, T> function)
        {
            if (source == null)
            {
                throw new NullReferenceException();
            }
            var min = source.First();
            foreach (var item in source)
            {
                min = function(item, min);
            }
            return min;
        }
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> function)
        {
            if (source == null)
            {
                throw new NullReferenceException();
            }
            foreach (var item in source)
            {
                if (function(item)) yield return item;
            }
        }
        public static IEnumerable<T> CustomSelect<T>(this IEnumerable<T> source, Func<T, T> function)
        {
            if (source == null)
            {
                throw new NullReferenceException();
            }
            foreach (var item in source)
            {
                yield return function(item);
            }
        }
    }
}

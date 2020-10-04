using System;
using System.Collections.Generic;

namespace SelfishCoder.BaseProject.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Calls the given action for each item in the collection.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static void Call<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (T item in collection)
            {
                action(item);
            }
        }
    }
}
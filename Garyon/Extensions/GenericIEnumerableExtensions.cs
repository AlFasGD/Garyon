﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Garyon.Extensions
{
    /// <summary>Contains extension functions for the <seealso cref="IEnumerable{T}"/> interface.</summary>
    public static class GenericIEnumerableExtensions
    {
        /// <summary>Concatenates multiple <seealso cref="IEnumerable{T}"/>s and returns the concatenated result.</summary>
        /// <typeparam name="T">The type of the elements the <seealso cref="IEnumerable{T}"/>s hold.</typeparam>
        /// <param name="e">The base <seealso cref="IEnumerable{T}"/> to concatenate with the others.</param>
        /// <param name="others">The other <seealso cref="IEnumerable{T}"/>s to concatenate.</param>
        public static IEnumerable<T> ConcatMultiple<T>(this IEnumerable<T> e, params IEnumerable<T>[] others)
        {
            var concated = e;
            for (int i = 0; i < others.Length; i++)
                concated = concated.Concat(others[i]);
            return concated;
        }
        /// <summary>Gets the count of elements that satisfy a condition.</summary>
        /// <typeparam name="T">The type of the elements stored in the <seealso cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="enumerable">The <seealso cref="IEnumerable{T}"/> whose elements to iterate.</param>
        /// <param name="predicate">The condition that the elements must meet.</param>
        /// <returns>The total number of elements that satisfy the provided condition.</returns>
        public static int WhereCount<T>(this IEnumerable<T> enumerable, Predicate<T> predicate)
        {
            int count = 0;
            foreach (var e in enumerable)
                if (predicate(e))
                    count++;
            return count;
        }
        /// <summary>Gets the count of elements that are not <see langword="null"/>.</summary>
        /// <typeparam name="T">The type of the elements stored in the <seealso cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="enumerable">The <seealso cref="IEnumerable{T}"/> whose elements to iterate.</param>
        /// <returns>The total number of elements that are not <see langword="null"/>.</returns>
        public static int NotNullCount<T>(this IEnumerable<T> enumerable)
        {
            return WhereCount(enumerable, NotNullPredicate);

            static bool NotNullPredicate(T element) => element != null;
        }
    }
}
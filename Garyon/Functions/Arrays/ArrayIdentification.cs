﻿using Garyon.Attributes;
using System.Runtime.CompilerServices;

namespace Garyon.Functions.Arrays
{
    /// <summary>Provides functions useful for array identification, specifically regarding the element type.</summary>
    public static class ArrayIdentification
    {
        public static bool IsArrayOfByte<TArray>() => IsArrayOfType<TArray, byte>();
        public static bool IsArrayOfInt16<TArray>() => IsArrayOfType<TArray, short>();
        public static bool IsArrayOfInt32<TArray>() => IsArrayOfType<TArray, int>();
        public static bool IsArrayOfInt64<TArray>() => IsArrayOfType<TArray, long>();
        public static bool IsArrayOfSByte<TArray>() => IsArrayOfType<TArray, sbyte>();
        public static bool IsArrayOfUInt16<TArray>() => IsArrayOfType<TArray, ushort>();
        public static bool IsArrayOfUInt32<TArray>() => IsArrayOfType<TArray, uint>();
        public static bool IsArrayOfUInt64<TArray>() => IsArrayOfType<TArray, ulong>();
        public static bool IsArrayOfSingle<TArray>() => IsArrayOfType<TArray, float>();
        public static bool IsArrayOfDouble<TArray>() => IsArrayOfType<TArray, double>();
        public static bool IsArrayOfDecimal<TArray>() => IsArrayOfType<TArray, decimal>();
        public static bool IsArrayOfChar<TArray>() => IsArrayOfType<TArray, char>();
        public static bool IsArrayOfBoolean<TArray>() => IsArrayOfType<TArray, bool>();
        public static bool IsArrayOfString<TArray>() => IsArrayOfType<TArray, string>();

        #region Awful Autogenerated Code
        // .NET only supports arrays of up to 32 dimensions, otherwise System.__Canon__ will die
        /// <summary>Awfully written function that determines whether an array type contains elements of the provided type. It only checks for multidimensional arrays (of the form [(,)*]). Jagged arrays are not taken into consideration in this implementation.</summary>
        /// <typeparam name="TArray">The type of the array.</typeparam>
        /// <typeparam name="TElement">The type of the element the array stores.</typeparam>
        /// <returns>Whether the given array type stores elements of the <typeparamref name="TElement"/> type.</returns>
        [Autogenerated]
        public static bool IsArrayOfType<TArray, TElement>()
        {
            if (typeof(TArray) == typeof(TElement[]))
                return true;
            if (typeof(TArray) == typeof(TElement[,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            if (typeof(TArray) == typeof(TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                return true;
            return false;
        }
        /// <summary>Awfully written function that determines whether an array type contains elements of the provided type. It also checks for jagged arrays up to a maximum jagging level.</summary>
        /// <typeparam name="TArray">The type of the array.</typeparam>
        /// <typeparam name="TElement">The type of the element the array stores.</typeparam>
        /// <param name="maxJaggingLevel">The maximum jagging level of the array (1 means up to [], 2 means up to [][], etc.).</param>
        /// <returns>Whether the given array type stores elements of the <typeparamref name="TElement"/> type.</returns>
        public static bool IsArrayOfType<TArray, TElement>(int maxJaggingLevel) => IsArrayOfType<TArray, TElement>(maxJaggingLevel, 1);

        [Autogenerated]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsArrayOfType<TArray, TElement>(int maxJaggingLevel, int jaggingLevel = 1)
        {
            if (jaggingLevel > maxJaggingLevel)
                return false;

            if (TestTargetArrayType<TArray, TElement[]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            if (TestTargetArrayType<TArray, TElement[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]>(maxJaggingLevel, jaggingLevel))
                return true;
            return false;
        }

        private static bool TestTargetArrayType<TArray, TTargetArray>(int maxJaggingLevel, int jaggingLevel = 1)
        {
            if (typeof(TArray) == typeof(TTargetArray))
                return true;
            if (IsArrayOfType<TArray, TTargetArray>(maxJaggingLevel, jaggingLevel + 1))
                return true;

            return false;
        }
        #endregion
    }
}

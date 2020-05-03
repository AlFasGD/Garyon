using Garyon.Attributes;
using System.Runtime.InteropServices;

namespace Garyon.Tests.Resources.SizedStructs
{
    /// <summary>A struct with a size of 3 bytes.</summary>
    [StructLayout(LayoutKind.Sequential, Size = elementCount)]
    [Autogenerated]
    public unsafe struct Struct3 : ISizedStruct<Struct3>
    {
        private const int elementCount = 3;

        private fixed byte elements[elementCount];

        public static bool operator ==(Struct3 left, Struct3 right) => left.Equals(right);
        public static bool operator !=(Struct3 left, Struct3 right) => !(left == right);
        public static Struct3 operator ~(Struct3 s)
        {
            var result = new Struct3();
            for (int i = 0; i < elementCount; i++)
                result.elements[i] = (byte)~s.elements[i];
            return result;
        }

        public bool Equals(Struct3 other)
        {
            for (int i = 0; i < elementCount; i++)
                if (elements[i] != other.elements[i])
                    return false;
            return true;
        }
        public override bool Equals(object obj)
        {
            return Equals((Struct3)obj);
        }
    }
}
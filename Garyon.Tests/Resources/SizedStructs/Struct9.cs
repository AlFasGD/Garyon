using Garyon.Attributes;
using System.Runtime.InteropServices;

namespace Garyon.Tests.Resources.SizedStructs
{
    /// <summary>A struct with a size of 9 bytes.</summary>
    [StructLayout(LayoutKind.Sequential, Size = elementCount)]
    [Autogenerated]
    public unsafe struct Struct9 : ISizedStruct<Struct9>
    {
        private const int elementCount = 9;

        private fixed byte elements[elementCount];

        public static bool operator ==(Struct9 left, Struct9 right) => left.Equals(right);
        public static bool operator !=(Struct9 left, Struct9 right) => !(left == right);
        public static Struct9 operator ~(Struct9 s)
        {
            var result = new Struct9();
            for (int i = 0; i < elementCount; i++)
                result.elements[i] = (byte)~s.elements[i];
            return result;
        }

        public bool Equals(Struct9 other)
        {
            for (int i = 0; i < elementCount; i++)
                if (elements[i] != other.elements[i])
                    return false;
            return true;
        }
        public override bool Equals(object obj)
        {
            return Equals((Struct9)obj);
        }
    }
}

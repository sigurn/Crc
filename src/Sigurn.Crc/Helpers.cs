using System.Numerics;
using System.Runtime.CompilerServices;

namespace Sigurn.Crc;

static class Helpers
{
    public static T Reverse<T>(T b) where T : struct, INumber<T>, IBitwiseOperators<T, T, T>, IShiftOperators<T, int, T>
    {
        T result = default;
        int bits = Unsafe.SizeOf<T>() * 8;
        for (int i = 0; i < bits; i++)
        {
            result <<= 1;
            result |= b & T.One;
            b >>= 1;
        }
        return result;
    }
}
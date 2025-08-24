using System.Numerics;
using System.Runtime.CompilerServices;

namespace Sigurn.Crc;

sealed class CrcComputer<T> : ICrcComputer<T> where T : struct, INumber<T>, IBitwiseOperators<T, T, T>, IShiftOperators<T, int, T>
{
    private static readonly int _bits = Unsafe.SizeOf<T>() * 8;

    private readonly T[] _table;
    private readonly Params<T> _params;

    public CrcComputer(Params<T> algorithm)
    {
        _params = algorithm;
        _table = GetTable(_params.Poly);
    }

    public string Name => _params.Name;

    public void Append(ref T crc, byte value)
    {
        if (_params.RefIn)
            value = Helpers.Reverse(value);

        if (_bits == 8)
        {
            int idx = int.CreateChecked((crc ^ T.CreateChecked(value)) & T.CreateChecked(0xFF));
            crc = _table[idx];
        }
        else
        {
            int idx = int.CreateChecked(((crc >> (_bits - 8)) ^ T.CreateChecked(value)) & T.CreateChecked(0xFF));
            crc = (crc << 8) ^ _table[idx];
        }
    }

    public T Complete(ref T crc)
    {
        if (_params.RefOut)
            crc = Helpers.Reverse(crc);

        crc = (T)(crc ^ _params.XorOut);

        return crc;
    }

    public void Init(out T crc)
    {
        crc = _params.Init;
    }

    private static readonly Dictionary<T, T[]> _tables = new();
    
    private static T[] GetTable(T poly)
    {
        lock (_tables)
        {
            if (!_tables.TryGetValue(poly, out var table))
            {
                table = CreateTable(poly);
                _tables[poly] = table;
            }

            return table;
        }
    }

    private static T[] CreateTable(T poly)
    {
        T[] table = new T[256];
        T mask = T.One << (_bits - 1);

        for (int n = 0; n < 256; n++)
        {
            T crc = _bits == 8
                ? T.CreateChecked(n)
                : T.CreateChecked(n) << (_bits - 8);

            for (int i = 0; i < 8; i++)
            {
                var bit = (crc & mask) != T.Zero;
                crc <<= 1;
                if (bit) crc ^= poly;
            }

            table[n] = crc;
        }

        return table;
    }
}

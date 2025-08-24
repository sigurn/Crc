using System.Numerics;

namespace Sigurn.Crc;

/// <summary>
/// This record describes parameters of CRC algorithm.
/// </summary>
/// <typeparam name="T">Type of CRC value.</typeparam>
/// <param name="Name">Name of the CRC algorithm.</param>
/// <param name="Poly">Polinomial used for CRC calculation.</param>
/// <param name="Init">Initial CRC value used for CRC calculation.</param>
/// <param name="RefIn">Flag describes if bits should be reversed for incoming bytes</param>
/// <param name="RefOut">Flag describes if bits should be reversed for outgoing CRC.</param>
/// <param name="XorOut">Mask which is applied to final CRC value.</param>
/// <param name="Check">Value to check the algorithm. The CRC which is calculated for ASCII bytes of the string "123456789"</param>
public record struct Params<T>(string Name, T Poly, T Init, bool RefIn, bool RefOut, T XorOut, T Check) where T : struct, INumber<T>, IBitwiseOperators<T, T, T>, IShiftOperators<T, int, T>
{
    /// <summary>
    /// Creates a CRC computer with the current algorithm parameters.
    /// </summary>
    /// <returns></returns>
    public ICrcComputer<T> CreateComputer()
    {
        return new CrcComputer<T>(this);
    }
}

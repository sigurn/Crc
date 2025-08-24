using System.Numerics;

namespace Sigurn.Crc;

/// <summary>
/// Th einterface describes functionality of CRC computer.
/// </summary>
/// <typeparam name="T">Type of CRC value</typeparam>
public interface ICrcComputer<T> where T : struct, INumber<T>, IBitwiseOperators<T, T, T>, IShiftOperators<T, int, T>
{
    /// <summary>
    /// Name of CRC algorithm
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Initializes CRC value with initial value for the CRC algorithm.
    /// </summary>
    /// <param name="crc"></param>
    void Init(out T crc);

    /// <summary>
    /// Appends next byte to CRC value.
    /// </summary>
    /// <param name="crc">CRC value where CRC is accumulated.</param>
    /// <param name="value">Byte to be appended to the CRC</param>
    void Append(ref T crc, byte value);

    /// <summary>
    /// Completes CRC calculation and returns result CRC.
    /// </summary>
    /// <param name="crc">CRC value accumulated durin CRC calculation.</param>
    /// <returns>Result CRC value</returns>
    /// <remarks>After calling this method CRC value passed via <paramref name="crc"/> will be updated to the final CRC value as well.
    T Complete(ref T crc);
}
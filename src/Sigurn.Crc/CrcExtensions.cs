using System.Numerics;

namespace Sigurn.Crc;

/// <summary>
/// This class provides useful CRC extensions.
/// </summary>
public static class CrcExtensions
{
    /// <summary>
    /// Calculates CRC of array with provided CRC computer.
    /// </summary>
    /// <typeparam name="T">Type of CRC value</typeparam>
    /// <param name="data">Array to calculate CRC of</param>
    /// <param name="computer">CRC computer to calculate CRC with.</param>
    /// <returns>Calculated CRC</returns>
    public static T ComputeCrc<T>(this IEnumerable<byte> data, ICrcComputer<T> computer) where T : struct, INumber<T>, IBitwiseOperators<T, T, T>, IShiftOperators<T, int, T>
    {
        computer.Init(out T crc);
        foreach (byte b in data)
            computer.Append(ref crc, b);
        return computer.Complete(ref crc);
    }

    /// <summary>
    /// Calculates CRC of provided array using CRC computer.
    /// </summary>
    /// <typeparam name="T">Type of CRC value</typeparam>
    /// <param name="computer">CRC computer to calculate CRC with</param>
    /// <param name="data">Array to calculate CRC of</param>
    /// <returns>Calculated CRC</returns>
    public static T ComputeCrc<T>(this ICrcComputer<T> computer, IEnumerable<byte> data) where T : struct, INumber<T>, IBitwiseOperators<T, T, T>, IShiftOperators<T, int, T>
    {
        computer.Init(out T crc);
        foreach (byte b in data)
            computer.Append(ref crc, b);
        return computer.Complete(ref crc);
    }
}
using System.Text;

namespace Sigurn.Crc.Tests;

public class CrcTests
{
    public static IEnumerable<object[]> Crc8Algorithms =>
        new List<object[]>
        {
            new object[] { Algorithm.Crc8 },
            new object[] { Algorithm.Crc8Aes },
            new object[] { Algorithm.Crc8Autosar },
            new object[] { Algorithm.Crc8Bluetooth },
            new object[] { Algorithm.Crc8Cdma2000 },
            new object[] { Algorithm.Crc8Darc },
            new object[] { Algorithm.Crc8DvbS2 },
            new object[] { Algorithm.Crc8Ebu },
            new object[] { Algorithm.Crc8GsmA },
            new object[] { Algorithm.Crc8GsmB },
            new object[] { Algorithm.Crc8Hitag },
            new object[] { Algorithm.Crc8I4321 },
            new object[] { Algorithm.Crc8ICode },
            new object[] { Algorithm.Crc8Itu },
            new object[] { Algorithm.Crc8Lte },
            new object[] { Algorithm.Crc8Maxim },
            new object[] { Algorithm.Crc8MaximDow },
            new object[] { Algorithm.Crc8MifareMad },
            new object[] { Algorithm.Crc8Nrsc5 },
            new object[] { Algorithm.Crc8Opensafety },
            new object[] { Algorithm.Crc8R0hc },
            new object[] { Algorithm.Crc8SaeJ1850 },
            new object[] { Algorithm.Crc8Smbus },
            new object[] { Algorithm.Crc8Tech3250 },
            new object[] { Algorithm.Crc8Wcdma },
            new object[] { Algorithm.DowCrc },
        };

    public static IEnumerable<object[]> Crc16Algorithms =>
        new List<object[]>
        {
            new object[] { Algorithm.Crc16 },
            new object[] { Algorithm.Crc16Acorn },
            new object[] { Algorithm.Crc16Arc},
            new object[] { Algorithm.Crc16AugCcitt },
            new object[] { Algorithm.Crc16Autosar },
            new object[] { Algorithm.Crc16Bluetooth },
            new object[] { Algorithm.Crc16Buypass },
            new object[] { Algorithm.Crc16Ccitt },
            new object[] { Algorithm.Crc16CcittFalse },
            new object[] { Algorithm.Crc16CcittTrue },
            new object[] { Algorithm.Crc16Cdma2000 },
            new object[] { Algorithm.Crc16Cms },
            new object[] { Algorithm.Crc16Darc },
            new object[] { Algorithm.Crc16Dds110 },
            new object[] { Algorithm.Crc16DectR },
            new object[] { Algorithm.Crc16DectX },
            new object[] { Algorithm.Crc16Dnp },
            new object[] { Algorithm.Crc16En13757 },
            new object[] { Algorithm.Crc16Epc },
            new object[] { Algorithm.Crc16EpcC1G2 },
            new object[] { Algorithm.Crc16Genibus },
            new object[] { Algorithm.Crc16Gsm },
            new object[] { Algorithm.Crc16Ibm3740 },
            new object[] { Algorithm.Crc16IbmSdlc },
            new object[] { Algorithm.Crc16ICode },
            new object[] { Algorithm.Crc16IsoHdlc },
            new object[] { Algorithm.Crc16IsoIec144433A },
            new object[] { Algorithm.Crc16IsoIec144433B },
            new object[] { Algorithm.Crc16Kermit },
            new object[] { Algorithm.Crc16Lha },
            new object[] { Algorithm.Crc16Lj1200 },
            new object[] { Algorithm.Crc16Lte },
            new object[] { Algorithm.Crc16M17 },
            new object[] { Algorithm.Crc16Maxim },
            new object[] { Algorithm.Crc16MaximDow },
            new object[] { Algorithm.Crc16Mcrf4xx },
            new object[] { Algorithm.Crc16Modbus },
            new object[] { Algorithm.Crc16Nrsc5 },
            new object[] { Algorithm.Crc16OpensafetyA },
            new object[] { Algorithm.Crc16OpensafetyB },
            new object[] { Algorithm.Crc16Profibus },
            new object[] { Algorithm.Crc16Riello },
            new object[] { Algorithm.Crc16SpiFujitsu },
            new object[] { Algorithm.Crc16T10Dif },
            new object[] { Algorithm.Crc16TeleDisk },
            new object[] { Algorithm.Crc16Tms37157 },
            new object[] { Algorithm.Crc16Umts },
            new object[] { Algorithm.Crc16Usb },
            new object[] { Algorithm.Crc16V41Lsb },
            new object[] { Algorithm.Crc16V41Msb },
            new object[] { Algorithm.Crc16Verifone },
            new object[] { Algorithm.Crc16X25 },
            new object[] { Algorithm.Crc16XModem },
            new object[] { Algorithm.Xmodem },
            new object[] { Algorithm.Zmodem },
            new object[] { Algorithm.RCrc16 },
            new object[] { Algorithm.XCrc16 },
            new object[] { Algorithm.CrcB },
            new object[] { Algorithm.X25 },
            new object[] { Algorithm.CrcA },
            new object[] { Algorithm.CrcCcitt },
            new object[] { Algorithm.Kermit },
        };

    public static IEnumerable<object[]> Crc32Algorithms =>
        new List<object[]>
        {
            new object[] { Algorithm.Chksum },
            new object[] { Algorithm.Crc32 },
            new object[] { Algorithm.Crc32Aal5 },
            new object[] { Algorithm.Crc32Adccp },
            new object[] { Algorithm.Crc32Aixm },
            new object[] { Algorithm.Crc32Autosar },
            new object[] { Algorithm.Crc32Base91C },
            new object[] { Algorithm.Crc32Base91D },
            new object[] { Algorithm.Crc32Bzip2 },
            new object[] { Algorithm.Crc32C },
            new object[] { Algorithm.Crc32Castagnoli },
            new object[] { Algorithm.Crc32CdromEdc },
            new object[] { Algorithm.Crc32Chksum },
            new object[] { Algorithm.Crc32D },
            new object[] { Algorithm.Crc32DectB },
            new object[] { Algorithm.Crc32Interlaken },
            new object[] { Algorithm.Crc32Iscsi },
            new object[] { Algorithm.Crc32IsoHdlc },
            new object[] { Algorithm.Crc32Jamcrc },
            new object[] { Algorithm.Crc32Mef },
            new object[] { Algorithm.Crc32Mpeg2 },
            new object[] { Algorithm.Crc32Nvme },
            new object[] { Algorithm.Crc32Posix },
            new object[] { Algorithm.Crc32Q },
            new object[] { Algorithm.Crc32V42 },
            new object[] { Algorithm.Crc32Xfer },
            new object[] { Algorithm.Pkzip },
        };

    public static IEnumerable<object[]> Crc64Algorithms =>
        new List<object[]>
        {
            new object[] { Algorithm.Crc64 },
            new object[] { Algorithm.Crc64Ecma182 },
            new object[] { Algorithm.Crc64GoEcma },
            new object[] { Algorithm.Crc64GoIso },
            new object[] { Algorithm.Crc64Ms },
            new object[] { Algorithm.Crc64Nvme },
            new object[] { Algorithm.Crc64Redis },
            new object[] { Algorithm.Crc64We },
            new object[] { Algorithm.Crc64Xz },
        };

    [Theory, MemberData(nameof(Crc8Algorithms))]
    public void ComputeCrc8Test(Params<byte> crcParams)
    {
        var testData = Encoding.ASCII.GetBytes("123456789");
        var computer = Algorithm.CreateComputer(crcParams);
        Assert.True(crcParams.Check == testData.ComputeCrc(computer), $"Invalid CRC for {computer.Name}");
    }

    [Theory, MemberData(nameof(Crc16Algorithms))]
    public void ComputeCrc16Test(Params<ushort> crcParams)
    {
        var testData = Encoding.ASCII.GetBytes("123456789");
        var computer = Algorithm.CreateComputer(crcParams);
        Assert.True(crcParams.Check == testData.ComputeCrc(computer), $"Invalid CRC for {computer.Name}");
    }

    [Theory, MemberData(nameof(Crc32Algorithms))]
    public void ComputeCrc32Test(Params<uint> crcParams)
    {
        var testData = Encoding.ASCII.GetBytes("123456789");
        var computer = Algorithm.CreateComputer(crcParams);
        Assert.True(crcParams.Check == testData.ComputeCrc(computer), $"Invalid CRC for {computer.Name}");
    }

    [Theory, MemberData(nameof(Crc64Algorithms))]
    public void ComputeCrc64Test(Params<ulong> crcParams)
    {
        var testData = Encoding.ASCII.GetBytes("123456789");
        var computer = Algorithm.CreateComputer(crcParams);
        Assert.True(crcParams.Check == testData.ComputeCrc(computer), $"Invalid CRC for {computer.Name}");
    }
}
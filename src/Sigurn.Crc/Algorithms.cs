using System.Numerics;

namespace Sigurn.Crc;

/// <summary>
/// This class contains list of predefined standard CRC-8, CRC-16, CRC-32 and CRC-64 algorithms. 
/// </summary>
public static class Algorithm
{
    /// <summary>
    /// CRC-8/AUTOSAR
    /// </summary>
    public static readonly Params<byte> Crc8Autosar = new("CRC-8/AUTOSAR", 0x2F, 0xFF, false, false, 0xFF, 0xDF);
    
    /// <summary>
    /// CRC-8/BLUETOOTH
    /// </summary>
    public static readonly Params<byte> Crc8Bluetooth = new("CRC-8/BLUETOOTH", 0xA7, 0x00, true, true, 0x00, 0x26);
    
    /// <summary>
    /// CRC-8/CDMA2000
    /// </summary>
    public static readonly Params<byte> Crc8Cdma2000 = new("CRC-8/CDMA2000", 0x9B, 0xFF, false, false, 0x00, 0xDA);
    
    /// <summary>
    /// CRC-8/DARC
    /// </summary>
    public static readonly Params<byte> Crc8Darc = new("CRC-8/DARC", 0x39, 0x00, true, true, 0x00, 0x15);
    
    /// <summary>
    /// CRC-8/DVB-S2
    /// </summary>
    public static readonly Params<byte> Crc8DvbS2 = new("CRC-8/DVB-S2", 0xD5, 0x00, false, false, 0x00, 0xBC);
    
    /// <summary>
    /// CRC-8/GSM-A
    /// </summary>
    public static readonly Params<byte> Crc8GsmA = new("CRC-8/GSM-A", 0x1D, 0x00, false, false, 0x00, 0x37);
    
    /// <summary>
    /// CRC-8/GSM-B
    /// </summary>
    public static readonly Params<byte> Crc8GsmB = new("CRC-8/GSM-B", 0x49, 0x00, false, false, 0xFF, 0x94);
    
    /// <summary>
    /// CRC-8/HITAG
    /// </summary>
    public static readonly Params<byte> Crc8Hitag = new("CRC-8/HITAG", 0x1D, 0xFF, false, false, 0x00, 0xB4);
    
    /// <summary>
    /// CRC-8/I-432-1
    /// </summary>
    public static readonly Params<byte> Crc8I4321 = new("CRC-8/I-432-1", 0x07, 0x00, false, false, 0x55, 0xA1);

    /// <summary>
    /// CRC-8/ITU
    /// </summary>
    public static readonly Params<byte> Crc8Itu = Crc8I4321 with { Name = "CRC-8/ITU" };
    
    /// <summary>
    /// CRC-8/I-CODE
    /// </summary>
    public static readonly Params<byte> Crc8ICode = new("CRC-8/I-CODE", 0x1D, 0xFD, false, false, 0x00, 0x7E);
    
    /// <summary>
    /// CRC-8/LTE
    /// </summary>
    public static readonly Params<byte> Crc8Lte = new("CRC-8/LTE", 0x9B, 0x00, false, false, 0x00, 0xEA);
    
    /// <summary>
    /// CRC-8/MAXIM
    /// </summary>
    public static readonly Params<byte> Crc8Maxim = new("CRC-8/MAXIM", 0x31, 0x00, true, true, 0x00, 0xA1);

    /// <summary>
    /// CRC-8/MAXIM-DOW
    /// </summary>
    public static readonly Params<byte> Crc8MaximDow = Crc8Maxim with { Name = "CRC-8/MAXIM-DOW" };

    /// <summary>
    /// DOW-CRC
    /// </summary>
    public static readonly Params<byte> DowCrc = Crc8Maxim with { Name = "DOW-CRC" };
    
    /// <summary>
    /// CRC-8/MIFARE-MAD
    /// </summary>
    public static readonly Params<byte> Crc8MifareMad = new("CRC-8/MIFARE-MAD", 0x1D, 0xC7, false, false, 0x00, 0x99);
    
    /// <summary>
    /// CRC-8/NRSC-5
    /// </summary>
    public static readonly Params<byte> Crc8Nrsc5 = new("CRC-8/NRSC-5", 0x31, 0xFF, false, false, 0x00, 0xF7);
    
    /// <summary>
    /// CRC-8/OPENSAFETY
    /// </summary>
    public static readonly Params<byte> Crc8Opensafety = new("CRC-8/OPENSAFETY", 0x2F, 0x00, false, false, 0x00, 0x3E);
    
    /// <summary>
    /// CRC-8/ROHC
    /// </summary>
    public static readonly Params<byte> Crc8R0hc = new("CRC-8/ROHC", 0x07, 0xFF, true, true, 0x00, 0xD0);
    
    /// <summary>
    /// CRC-8/SAE-J1850
    /// </summary>
    public static readonly Params<byte> Crc8SaeJ1850 = new("CRC-8/SAE-J1850", 0x1D, 0xFF, false, false, 0xFF, 0x4B);
    
    /// <summary>
    /// CRC-8/SMBUS
    /// </summary>
    public static readonly Params<byte> Crc8Smbus = new("CRC-8/SMBUS", 0x07, 0x00, false, false, 0x00, 0xF4);

    /// <summary>
    /// CRC-8
    /// </summary>
    public static readonly Params<byte> Crc8 = Crc8Smbus with { Name = "CRC-8" };
    
    /// <summary>
    /// CRC-8/TECH-3250
    /// </summary>
    public static readonly Params<byte> Crc8Tech3250 = new("CRC-8/TECH-3250", 0x1D, 0xFF, true, true, 0x00, 0x97);

    /// <summary>
    /// CRC-8/AES
    /// </summary>
    public static readonly Params<byte> Crc8Aes = Crc8Tech3250 with { Name = "CRC-8/AES" };

    /// <summary>
    /// CRC-8/EBU
    /// </summary>
    public static readonly Params<byte> Crc8Ebu = Crc8Tech3250 with { Name = "CRC-8/EBU" };
    
    /// <summary>
    /// CRC-8/WCDMA
    /// </summary>
    public static readonly Params<byte> Crc8Wcdma = new("CRC-8/WCDMA", 0x9B, 0x00, true, true, 0x00, 0x25);


    /// <summary>
    /// CRC-16/ARC
    /// </summary>
    public static readonly Params<ushort> Crc16Arc = new("CRC-16/ARC", 0x8005, 0x0000, true, true, 0x0000, 0xBB3D);

    /// <summary>
    /// ARC
    /// </summary>
    public static readonly Params<ushort> Arc = Crc16Arc with { Name = "ARC" };

    /// <summary>
    /// CRC-16
    /// </summary>
    public static readonly Params<ushort> Crc16 = Crc16Arc with { Name = "CRC-16" };

    /// <summary>
    /// CRC-16/LHA
    /// </summary>
    public static readonly Params<ushort> Crc16Lha = Crc16Arc with { Name = "CRC-16/LHA" };

    /// <summary>
    /// CRC-IBM
    /// </summary>
    public static readonly Params<ushort> CrcIbm = Crc16Arc with { Name = "CRC-IBM" };
    
    /// <summary>
    /// CRC-16/CDMA2000
    /// </summary>
    public static readonly Params<ushort> Crc16Cdma2000 = new("CRC-16/CDMA2000", 0xC867, 0xFFFF, false, false, 0x0000, 0x4C06);
    
    /// <summary>
    /// CRC-16/CMS
    /// </summary>
    public static readonly Params<ushort> Crc16Cms = new("CRC-16/CMS", 0x8005, 0xFFFF, false, false, 0x0000, 0xAEE7);
    
    /// <summary>
    /// CRC-16/DDS-110
    /// </summary>
    public static readonly Params<ushort> Crc16Dds110 = new("CRC-16/DDS-110", 0x8005, 0x800D, false, false, 0x0000, 0x9ECF);
    
    /// <summary>
    /// CRC-16/DECT-R
    /// </summary>
    public static readonly Params<ushort> Crc16DectR = new("CRC-16/DECT-R", 0x0589, 0x0000, false, false, 0x0001, 0x007E);

    /// <summary>
    /// R-CRC-16
    /// </summary>
    public static readonly Params<ushort> RCrc16 = Crc16DectR with { Name = "R-CRC-16" };
    
    /// <summary>
    /// CRC-16/DECT-X
    /// </summary>
    public static readonly Params<ushort> Crc16DectX = new("CRC-16/DECT-X", 0x0589, 0x0000, false, false, 0x0000, 0x007F);

    /// <summary>
    /// X-CRC-16
    /// </summary>
    public static readonly Params<ushort> XCrc16 = Crc16DectX with { Name = "X-CRC-16" };
    
    /// <summary>
    /// CRC-16/DNP
    /// </summary>
    public static readonly Params<ushort> Crc16Dnp = new("CRC-16/DNP", 0x3D65, 0x0000, true, true, 0xFFFF, 0xEA82);
    
    /// <summary>
    /// CRC-16/EN-13757
    /// </summary>
    public static readonly Params<ushort> Crc16En13757 = new("CRC-16/EN-13757", 0x3D65, 0x0000, false, false, 0xFFFF, 0xC2B7);
    
    /// <summary>
    /// CRC-16/GENIBUS
    /// </summary>
    public static readonly Params<ushort> Crc16Genibus = new("CRC-16/GENIBUS", 0x1021, 0xFFFF, false, false, 0xFFFF, 0xD64E);

    /// <summary>
    /// CRC-16/DARC
    /// </summary>
    public static readonly Params<ushort> Crc16Darc = Crc16Genibus with { Name = "CRC-16/DARC" };

    /// <summary>
    /// CRC-16/EPC
    /// </summary>
    public static readonly Params<ushort> Crc16Epc = Crc16Genibus with { Name = "CRC-16/EPC" };

    /// <summary>
    /// CRC-16/EPC-C1G2
    /// </summary>
    public static readonly Params<ushort> Crc16EpcC1G2 = Crc16Genibus with { Name = "CRC-16/EPC-C1G2" };

    /// <summary>
    /// CRC-16/I-CODE
    /// </summary>
    public static readonly Params<ushort> Crc16ICode = Crc16Genibus with { Name = "CRC-16/I-CODE" };
    
    /// <summary>
    /// CRC-16/GSM
    /// </summary>
    public static readonly Params<ushort> Crc16Gsm = new("CRC-16/GSM", 0x1021, 0x0000, false, false, 0xFFFF, 0xCE3C);
    
    /// <summary>
    /// CRC-16/IBM-3740
    /// </summary>
    public static readonly Params<ushort> Crc16Ibm3740 = new("CRC-16/IBM-3740", 0x1021, 0xFFFF, false, false, 0x0000, 0x29B1);

    /// <summary>
    /// CRC-16/AUTOSAR
    /// </summary>
    public static readonly Params<ushort> Crc16Autosar = Crc16Ibm3740 with { Name = "CRC-16/AUTOSAR" };
    
    /// <summary>
    /// CRC-16/CCITT-FALSE
    /// </summary>
    public static readonly Params<ushort> Crc16CcittFalse = new("CRC-16/CCITT-FALSE", 0x1021, 0xFFFF, false, false, 0x0000, 0x29B1);
    
    /// <summary>
    /// CRC-16/IBM-SDLC
    /// </summary>
    public static readonly Params<ushort> Crc16IbmSdlc = new("CRC-16/IBM-SDLC", 0x1021, 0xFFFF, true, true, 0xFFFF, 0x906E);

    /// <summary>
    /// CRC-16/ISO-HDLC
    /// </summary>
    public static readonly Params<ushort> Crc16IsoHdlc = Crc16IbmSdlc with { Name = "CRC-16/ISO-HDLC" };

    /// <summary>
    /// CRC-16/ISO-IEC-14443-3-B
    /// </summary>
    public static readonly Params<ushort> Crc16IsoIec144433B = Crc16IbmSdlc with { Name = "CRC-16/ISO-IEC-14443-3-B" };

    /// <summary>
    /// CRC-16/X-25
    /// </summary>
    public static readonly Params<ushort> Crc16X25 = Crc16IbmSdlc with { Name = "CRC-16/X-25" };

    /// <summary>
    /// CRC-B
    /// </summary>
    public static readonly Params<ushort> CrcB = Crc16IbmSdlc with { Name = "CRC-B" };

    /// <summary>
    /// X-25
    /// </summary>
    public static readonly Params<ushort> X25 = Crc16IbmSdlc with { Name = "X-25" };
    
    /// <summary>
    /// CRC-16/ISO-IEC-14443-3-A
    /// </summary>
    public static readonly Params<ushort> Crc16IsoIec144433A = new("CRC-16/ISO-IEC-14443-3-A", 0x1021, 0xC6C6, true, true, 0x0000, 0xBF05);

    /// <summary>
    /// CRC-A
    /// </summary>
    public static readonly Params<ushort> CrcA = Crc16IsoIec144433A with { Name = "CRC-A" };
    
    /// <summary>
    /// CRC-16/KERMIT
    /// </summary>
    public static readonly Params<ushort> Crc16Kermit = new("CRC-16/KERMIT", 0x1021, 0x0000, true, true, 0x0000, 0x2189);

    /// <summary>
    /// CRC-16/BLUETOOTH
    /// </summary>
    public static readonly Params<ushort> Crc16Bluetooth = Crc16Kermit with { Name = "CRC-16/BLUETOOTH" };

    /// <summary>
    /// CRC-16/CCITT
    /// </summary>
    public static readonly Params<ushort> Crc16Ccitt = Crc16Kermit with { Name = "CRC-16/CCITT" };

    /// <summary>
    /// CRC-16/CCITT-TRUE
    /// </summary>
    public static readonly Params<ushort> Crc16CcittTrue = Crc16Kermit with { Name = "CRC-16/CCITT-TRUE" };

    /// <summary>
    /// CRC-16/V-41-LSB
    /// </summary>
    public static readonly Params<ushort> Crc16V41Lsb = Crc16Kermit with { Name = "CRC-16/V-41-LSB" };

    /// <summary>
    /// CRC-CCITT
    /// </summary>
    public static readonly Params<ushort> CrcCcitt = Crc16Kermit with { Name = "CRC-CCITT" };

    /// <summary>
    /// KERMIT
    /// </summary>
    public static readonly Params<ushort> Kermit = Crc16Kermit with { Name = "KERMIT" };
    
    /// <summary>
    /// CRC-16/LJ1200
    /// </summary>
    public static readonly Params<ushort> Crc16Lj1200 = new("CRC-16/LJ1200", 0x6F63, 0x0000, false, false, 0x0000, 0xBDF4);
    
    /// <summary>
    /// CRC-16/M17
    /// </summary>
    public static readonly Params<ushort> Crc16M17 = new("CRC-16/M17", 0x5935, 0xFFFF, false, false, 0x0000, 0x772B);
    
    /// <summary>
    /// CRC-16/MAXIM
    /// </summary>
    public static readonly Params<ushort> Crc16Maxim = new("CRC-16/MAXIM", 0x8005, 0x0000, true, true, 0xFFFF, 0x44C2);

    /// <summary>
    /// CRC-16/MAXIM-DOW
    /// </summary>
    public static readonly Params<ushort> Crc16MaximDow = Crc16Maxim with { Name = "CRC-16/MAXIM-DOW" };
    
    /// <summary>
    /// CRC-16/MCRF4XX
    /// </summary>
    public static readonly Params<ushort> Crc16Mcrf4xx = new("CRC-16/MCRF4XX", 0x1021, 0xFFFF, true, true, 0x0000, 0x6F91);
    
    /// <summary>
    /// CRC-16/MODBUS
    /// </summary>
    public static readonly Params<ushort> Crc16Modbus = new("CRC-16/MODBUS", 0x8005, 0xFFFF, true, true, 0x0000, 0x4B37);
    
    /// <summary>
    /// CRC-16/NRSC-5
    /// </summary>
    public static readonly Params<ushort> Crc16Nrsc5 = new("CRC-16/NRSC-5", 0x080B, 0xFFFF, true, true, 0x0000, 0xA066);
    
    /// <summary>
    /// CRC-16/OPENSAFETY-A
    /// </summary>
    public static readonly Params<ushort> Crc16OpensafetyA = new("CRC-16/OPENSAFETY-A", 0x5935, 0x0000, false, false, 0x0000, 0x5D38);
    
    /// <summary>
    /// CRC-16/OPENSAFETY-B
    /// </summary>
    public static readonly Params<ushort> Crc16OpensafetyB = new("CRC-16/OPENSAFETY-B", 0x755B, 0x0000, false, false, 0x0000, 0x20FE);
    
    /// <summary>
    /// CRC-16/PROFIBUS
    /// </summary>
    public static readonly Params<ushort> Crc16Profibus = new("CRC-16/PROFIBUS", 0x1DCF, 0xFFFF, false, false, 0xFFFF, 0xA819);
    
    /// <summary>
    /// CRC-16/RIELLO
    /// </summary>
    public static readonly Params<ushort> Crc16Riello = new("CRC-16/RIELLO", 0x1021, 0xB2AA, true, true, 0x0000, 0x63D0);
    
    /// <summary>
    /// CRC-16/SPI-FUJITSU
    /// </summary>
    public static readonly Params<ushort> Crc16SpiFujitsu = new("CRC-16/SPI-FUJITSU", 0x1021, 0x1D0F, false, false, 0x0000, 0xE5CC);

    /// <summary>
    /// CRC-16/AUG-CCITT
    /// </summary>
    public static readonly Params<ushort> Crc16AugCcitt = Crc16SpiFujitsu with { Name = "CRC-16/AUG-CCITT" };
    
    /// <summary>
    /// CRC-16/T10-DIF
    /// </summary>
    public static readonly Params<ushort> Crc16T10Dif = new("CRC-16/T10-DIF", 0x8BB7, 0x0000, false, false, 0x0000, 0xD0DB);
    
    /// <summary>
    /// CRC-16/TELEDISK
    /// </summary>
    public static readonly Params<ushort> Crc16TeleDisk = new("CRC-16/TELEDISK", 0xA097, 0x0000, false, false, 0x0000, 0x0FB3);
    
    /// <summary>
    /// CRC-16/TMS37157
    /// </summary>
    public static readonly Params<ushort> Crc16Tms37157 = new("CRC-16/TMS37157", 0x1021, 0x89EC, true, true, 0x0000, 0x26B1);
    
    /// <summary>
    /// CRC-16/UMTS
    /// </summary>
    public static readonly Params<ushort> Crc16Umts = new("CRC-16/UMTS", 0x8005, 0x0000, false, false, 0x0000, 0xFEE8);

    /// <summary>
    /// CRC-16/BUYPASS
    /// </summary>
    public static readonly Params<ushort> Crc16Buypass = Crc16Umts with { Name = "CRC-16/BUYPASS" };

    /// <summary>
    /// CRC-16/VERIFONE
    /// </summary>
    public static readonly Params<ushort> Crc16Verifone = Crc16Umts with { Name = "CRC-16/VERIFONE" };
    
    /// <summary>
    /// CRC-16/USB
    /// </summary>
    public static readonly Params<ushort> Crc16Usb = new("CRC-16/USB", 0x8005, 0xFFFF, true, true, 0xFFFF, 0xB4C8);
    
    /// <summary>
    /// RC-16/XMODEM
    /// </summary>
    public static readonly Params<ushort> Crc16XModem = new("CRC-16/XMODEM", 0x1021, 0x0000, false, false, 0x0000, 0x31C3);

    /// <summary>
    /// CRC-16/ACORN
    /// </summary>
    public static readonly Params<ushort> Crc16Acorn = Crc16XModem with { Name = "CRC-16/ACORN" };

    /// <summary>
    /// CRC-16/LTE
    /// </summary>
    public static readonly Params<ushort> Crc16Lte = Crc16XModem with { Name = "CRC-16/LTE" };

    /// <summary>
    /// CRC-16/V-41-MSB
    /// </summary>
    public static readonly Params<ushort> Crc16V41Msb = Crc16XModem with { Name = "CRC-16/V-41-MSB" };

    /// <summary>
    /// XMODEM
    /// </summary>
    public static readonly Params<ushort> Xmodem = Crc16XModem with { Name = "XMODEM" };

    /// <summary>
    /// ZMODEM
    /// </summary>
    public static readonly Params<ushort> Zmodem = Crc16XModem with { Name = "ZMODEM" };


    /// <summary>
    /// CRC-32/AIXM
    /// </summary>
    public static readonly Params<uint> Crc32Aixm = new("CRC-32/AIXM", 0x814141AB, 0x00000000, false, false, 0x00000000, 0x3010BF7F);

    /// <summary>
    /// CRC-32Q
    /// </summary>
    public static readonly Params<uint> Crc32Q = Crc32Aixm with { Name = "CRC-32Q" };
    
    /// <summary>
    /// CRC-32/AUTOSAR
    /// </summary>
    public static readonly Params<uint> Crc32Autosar = new("CRC-32/AUTOSAR", 0xF4ACFB13, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0x1697D06A);
    
    /// <summary>
    /// CRC-32/BASE91-D
    /// </summary>
    public static readonly Params<uint> Crc32Base91D = new("CRC-32/BASE91-D", 0xA833982B, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0x87315576);

    /// <summary>
    /// CRC-32D
    /// </summary>
    public static readonly Params<uint> Crc32D = Crc32Base91D with { Name = "CRC-32D" };
    
    /// <summary>
    /// CRC-32/BZIP2
    /// </summary>
    public static readonly Params<uint> Crc32Bzip2 = new("CRC-32/BZIP2", 0x04C11DB7, 0xFFFFFFFF, false, false, 0xFFFFFFFF, 0xFC891918);

    /// <summary>
    /// CRC-32/AAL5
    /// </summary>
    public static readonly Params<uint> Crc32Aal5 = Crc32Bzip2 with { Name = "CRC-32/AAL5" };

    /// <summary>
    /// CRC-32/DECT-B
    /// </summary>
    public static readonly Params<uint> Crc32DectB = Crc32Bzip2 with { Name = "CRC-32/DECT-B" };

    /// <summary>
    /// B-CRC-32
    /// </summary>
    public static readonly Params<uint> BCrc32 = Crc32Bzip2 with { Name = "B-CRC-32" };
    
    /// <summary>
    /// CRC-32/CD-ROM-EDC
    /// </summary>
    public static readonly Params<uint> Crc32CdromEdc = new("CRC-32/CD-ROM-EDC", 0x8001801B, 0x00000000, true, true, 0x00000000, 0x6EC2EDC4);
    
    /// <summary>
    /// CRC-32/CKSUM
    /// </summary>
    public static readonly Params<uint> Crc32Chksum = new("CRC-32/CKSUM", 0x04C11DB7, 0x00000000, false, false, 0xFFFFFFFF, 0x765E7680);

    /// <summary>
    /// CKSUM
    /// </summary>
    public static readonly Params<uint> Chksum = Crc32Chksum with { Name = "CKSUM" };

    /// <summary>
    /// CRC-32/POSIX
    /// </summary>
    public static readonly Params<uint> Crc32Posix = Crc32Chksum with { Name = "CRC-32/POSIX" };
    
    /// <summary>
    /// CRC-32/ISCSI
    /// </summary>
    public static readonly Params<uint> Crc32Iscsi = new("CRC-32/ISCSI", 0x1EDC6F41, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0xE3069283);

    /// <summary>
    /// CRC-32/BASE91-C
    /// </summary>
    public static readonly Params<uint> Crc32Base91C = Crc32Iscsi with { Name = "CRC-32/BASE91-C" };

    /// <summary>
    /// CRC-32/CASTAGNOLI
    /// </summary>
    public static readonly Params<uint> Crc32Castagnoli = Crc32Iscsi with { Name = "CRC-32/CASTAGNOLI" };

    /// <summary>
    /// CRC-32/INTERLAKEN
    /// </summary>
    public static readonly Params<uint> Crc32Interlaken = Crc32Iscsi with { Name = "CRC-32/INTERLAKEN" };

    /// <summary>
    /// CRC-32C
    /// </summary>
    public static readonly Params<uint> Crc32C = Crc32Iscsi with { Name = "CRC-32C" };

    /// <summary>
    /// CRC-32/NVME
    /// </summary>
    public static readonly Params<uint> Crc32Nvme = Crc32Iscsi with { Name = "CRC-32/NVME" };
    
    /// <summary>
    /// CRC-32/ISO-HDLC
    /// </summary>
    public static readonly Params<uint> Crc32IsoHdlc = new("CRC-32/ISO-HDLC", 0x04C11DB7, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0xCBF43926);

    /// <summary>
    /// "CRC-32
    /// </summary>
    public static readonly Params<uint> Crc32 = Crc32IsoHdlc with { Name = "CRC-32" };

    /// <summary>
    /// CRC-32/ADCCP
    /// </summary>
    public static readonly Params<uint> Crc32Adccp = Crc32IsoHdlc with { Name = "CRC-32/ADCCP" };

    /// <summary>
    /// CRC-32/V-42
    /// </summary>
    public static readonly Params<uint> Crc32V42 = Crc32IsoHdlc with { Name = "CRC-32/V-42" };

    /// <summary>
    /// CRC-32/XZ
    /// </summary>
    public static readonly Params<uint> Crc32Xz = Crc32IsoHdlc with { Name = "CRC-32/XZ" };

    /// <summary>
    /// PKZIP
    /// </summary>
    public static readonly Params<uint> Pkzip = Crc32IsoHdlc with { Name = "PKZIP" };
    
    /// <summary>
    /// CRC-32/JAMCRC
    /// </summary>
    public static readonly Params<uint> Crc32Jamcrc = new("CRC-32/JAMCRC", 0x04C11DB7, 0xFFFFFFFF, true, true, 0x00000000, 0x340BC6D9);
    
    /// <summary>
    /// CRC-32/MEF
    /// </summary>
    public static readonly Params<uint> Crc32Mef = new("CRC-32/MEF", 0x741B8CD7, 0xFFFFFFFF, true, true, 0x00000000, 0xD2C22F51);
    
    /// <summary>
    /// CRC-32/MPEG-2
    /// </summary>
    public static readonly Params<uint> Crc32Mpeg2 = new("CRC-32/MPEG-2", 0x04C11DB7, 0xFFFFFFFF, false, false, 0x00000000, 0x0376E6E7);
    
    /// <summary>
    /// CRC-32/XFER
    /// </summary>
    public static readonly Params<uint> Crc32Xfer = new("CRC-32/XFER", 0x000000af, 0x00000000, false, false, 0x00000000, 0xBD0BE338);


    /// <summary>
    /// CRC-64/ECMA-182
    /// </summary>
    public static readonly Params<ulong> Crc64Ecma182 = new("CRC-64/ECMA-182", 0x42F0E1EBA9EA3693, 0x0000000000000000, false, false, 0x0000000000000000, 0x6C40DF5F0B497347);

    /// <summary>
    /// CRC-64
    /// </summary>
    public static readonly Params<ulong> Crc64 = Crc64Ecma182 with { Name = "CRC-64" };
    
    /// <summary>
    /// CRC-64/GO-ISO
    /// </summary>
    public static readonly Params<ulong> Crc64GoIso = new("CRC-64/GO-ISO", 0x000000000000001B, 0xFFFFFFFFFFFFFFFF, true, true, 0xFFFFFFFFFFFFFFFF, 0xB90956C775A41001);
    
    /// <summary>
    /// CRC-64/MS
    /// </summary>
    public static readonly Params<ulong> Crc64Ms = new("CRC-64/MS", 0x259C84CBA6426349, 0xFFFFFFFFFFFFFFFF, true, true, 0x0000000000000000, 0x75D4B74F024ECEEA);
    
    /// <summary>
    /// CRC-64/NVME
    /// </summary>
    public static readonly Params<ulong> Crc64Nvme = new("CRC-64/NVME", 0xAD93D23594C93659, 0xFFFFFFFFFFFFFFFF, true, true, 0xFFFFFFFFFFFFFFFF, 0xAE8B14860A799888);
    
    /// <summary>
    /// CRC-64/REDIS
    /// </summary>
    public static readonly Params<ulong> Crc64Redis = new("CRC-64/REDIS", 0xAD93d23594C935A9, 0x0000000000000000, true, true, 0x0000000000000000, 0xE9C6D914C4b8d9CA);
    
    /// <summary>
    /// CRC-64/WE
    /// </summary>
    public static readonly Params<ulong> Crc64We = new("CRC-64/WE", 0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, false, false, 0xFFFFFFFFFFFFFFFF, 0x62EC59E3f1A4f00A);
    
    /// <summary>
    /// CRC-64/XZ
    /// </summary>
    public static readonly Params<ulong> Crc64Xz = new("CRC-64/XZ", 0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, true, true, 0xFFFFFFFFFFFFFFFF, 0x995DC9BBDF1939FA);

    /// <summary>
    /// CRC-64/GO-ECMA
    /// </summary>
    public static readonly Params<ulong> Crc64GoEcma = Crc64Xz with { Name = "CRC-64/GO-ECMA" };

    /// <summary>
    /// Creates an instance of CRC computer for the provided algorithm.
    /// </summary>
    /// <typeparam name="T">Type of CRC value.</typeparam>
    /// <param name="algorithm">Algorithm to use for CRC calculation.</param>
    /// <returns>Instance of CRC computer</returns>
    public static ICrcComputer<T> CreateComputer<T>(Params<T> algorithm) where T : struct, INumber<T>, IBitwiseOperators<T, T, T>, IShiftOperators<T, int, T>
    {
        return new CrcComputer<T>(algorithm);
    }
}

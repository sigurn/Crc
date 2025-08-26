# Crc

[![NuGet](https://img.shields.io/nuget/v/Sigurn.Crc)](https://www.nuget.org/packages/Sigurn.Crc)

## General information

This is a CRC calculation library. It allows to calculate CRC-8, CRC-16, CRC-32 and CRC-64 with many pre-defined algorithms.
If the library does not have your algorithm you can provide parameters of your algorithm to CRC claculator and it will be able to calculate CRC with your algorithm.

## Get started

### Add reference to NuGet package

To start using the library, add a reference to the NuGet package to your project.

```xml
<PackageReference Include="Sigurn.Crc" Version="1.0.1" />
```

### Use CRC computer
```csharp
using System.Text;
using Sigurn.Crc;

namespace CrcExample;

public static class Program
{
    public static void Main(string[] args)
    {
        var computer = Algorithm.Crc16.CreateComputer();
        var data = Encoding.ASCII.GetBytes("123456789");
        var crc = computer.ComputeCrc(data);

        Console.WriteLine($"Computed CRC: {crc}");
    }
}
```



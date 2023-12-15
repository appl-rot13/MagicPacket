[English](README.md) | [日本語](README.ja.md)

# Magic Packet (written in C#)

Sample of sending Wake-on-LAN magic packets in C#.

## Usage

Set the IP address and MAC address, build the solution with Visual Studio, and use the generated executable file.

### Setting IP Address

Set the broadcast address for the Wake-on-LAN target PC within the network.

```csharp
/// <summary>Broadcast Address</summary>
private const string IpAddress = "192.168.64.15";
```

### Setting MAC Address

Set the MAC address for the Wake-on-LAN target NIC.

```csharp
/// <summary>MAC Address</summary>
private const string MacAddress = "c8:60:00:dd:ea:b9";
```

## License

This software is licensed under the [Unlicense](LICENSE).

## See also

- [MagicPacketCPlus](../../../MagicPacketCPlus) - Sample written in C/C++
- [MagicPacketBatch](../../../MagicPacketBatch) - Sample batch file

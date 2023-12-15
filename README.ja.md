[English](README.md) | [日本語](README.ja.md)

# Magic Packet (written in C#)

Wake-on-LANのマジックパケットを送信するサンプル。

## 使い方

IPアドレスとMACアドレスを設定してVisual Studioでビルドし、出力されたexeファイルを使用します。

### IPアドレスの設定

Wake-on-LAN対象のPCが所属するネットワークのブロードキャストアドレスを指定します。

```csharp
/// <summary>Broadcast Address</summary>
private const string IpAddress = "192.168.64.15";
```

### MACアドレスの設定

Wake-on-LAN対象のNICのMACアドレスを指定します。

```csharp
/// <summary>MAC Address</summary>
private const string MacAddress = "c8:60:00:dd:ea:b9";
```

## ライセンス

このソフトウェアは[Unlicense](LICENSE)に基づいてライセンスされています。

## 関連項目

- [MagicPacketCPlus](../../../MagicPacketCPlus) - C/C++で書かれたサンプル
- [MagicPacketBatch](../../../MagicPacketBatch) - バッチファイルのサンプル

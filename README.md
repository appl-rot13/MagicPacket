MagicPacket (written in C#)
===========================
Wake-on-LANのマジックパケットを送信するサンプル。

使い方
------

IPアドレスとMACアドレスを設定してビルドし、
出力されたexeを使用するだけ。

### IPアドレスの設定 ###

Wake-on-LAN対象のPCが所属するネットワークの
ブロードキャストアドレスを指定します。

    /// <summary>Broadcast Address</summary>
    private const string IpAddress = "192.168.64.15";

### MACアドレスの設定 ###

Wake-onLAN対象のNICのMACアドレスを指定します。

    /// <summary>MAC Address</summary>
    private const string MacAddress = "c8:60:00:dd:ea:b9";

関連情報
--------
C/C++で書かれたサンプルもあります。  
これだけ短いコードでも、
C#だと如何に短く書けるか実感できますね。

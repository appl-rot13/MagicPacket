
namespace MagicPacket
{
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;

    public class MagicPacket
    {
        /// <summary>Broadcast Address</summary>
        private const string IpAddress = "192.168.64.15";

        /// <summary>MAC Address</summary>
        private const string MacAddress = "c8:60:00:dd:ea:b9";

        /// <summary>Port No.</summary>
        private const int Port = 3708;

        public static void Main(string[] args)
        {
            var endPoint = new IPEndPoint(IPAddress.Parse(IpAddress), Port);

            using (var socket = new Socket(endPoint.AddressFamily, SocketType.Dgram, ProtocolType.IP))
            {
                var addressBytes = MacAddress.Split(':').Select(hex => byte.Parse(hex, NumberStyles.HexNumber)).ToList();
                var message = Enumerable.Repeat((byte)0xFF, 6)
                                .Concat(Enumerable.Repeat(addressBytes, 16).SelectMany(bytes => bytes)).ToArray();

                socket.SendTo(message, endPoint);
            }
        }
    }
}
using OpenTTD.Networking.Abstractions.Messages;
using OpenTTD.Networking.Abstractions.Messages.Inbound;
using OpenTTD.Networking.Enums;

namespace OpenTTD.Networking.Messages.Inbound.ServerRcon;

public sealed class ServerRconTransformer : IPacketTransformer
{
    public PacketType PacketType => PacketType.ADMIN_PACKET_SERVER_RCON;

    public IMessage Transform(Packet packet)
    {
        var msg = new ServerRconMessage(packet.ReadU16(), packet.ReadString());
        return msg;
    }
}
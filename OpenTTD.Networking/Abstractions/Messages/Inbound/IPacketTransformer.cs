using System.Diagnostics.Contracts;
using OpenTTD.Networking.Enums;
using OpenTTD.Networking.Messages;

namespace OpenTTD.Networking.Abstractions.Messages.Inbound;

public interface IPacketTransformer
{
    PacketType PacketType { get; }
    
    [Pure]
    IMessage Transform(Packet packet);
}
using System.Diagnostics.Contracts;
using OpenTTD.Networking.Messages;

namespace OpenTTD.Networking.Abstractions.Messages;

public interface IPacketService
{
    [Pure]
    IMessage ReadPacket(Packet packet);
    
    [Pure]
    Packet CreatePacket(IMessage message);
}
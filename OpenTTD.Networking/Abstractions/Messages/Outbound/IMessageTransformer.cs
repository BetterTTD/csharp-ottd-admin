using System.Diagnostics.Contracts;
using OpenTTD.Networking.Enums;
using OpenTTD.Networking.Messages;

namespace OpenTTD.Networking.Abstractions.Messages.Outbound;

public interface IMessageTransformer
{
    PacketType PacketType { get; }
    
    [Pure]
    Packet Transform(IMessage msg);   
}
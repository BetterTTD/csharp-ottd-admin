using OpenTTD.Networking.Enums;

namespace OpenTTD.Networking.Abstractions.Messages;

public interface IMessage
{
    PacketType PacketType { get; }
}
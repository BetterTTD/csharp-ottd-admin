using System.Diagnostics.Contracts;
using OpenTTD.Networking.Enums;

namespace OpenTTD.Networking.Abstractions.Messages;

public interface IMessageDeserializer
{
    [Pure]
    public IMessage Deserialize(PacketType type, string json);
}
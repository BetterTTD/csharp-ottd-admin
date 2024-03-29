using System.Diagnostics.Contracts;
using Newtonsoft.Json;
using OpenTTD.Networking.Abstractions.Messages;
using OpenTTD.Networking.Enums;
using OpenTTD.Networking.Messages.Inbound.ServerChat;
using OpenTTD.Networking.Messages.Inbound.ServerClientError;
using OpenTTD.Networking.Messages.Inbound.ServerClientInfo;
using OpenTTD.Networking.Messages.Inbound.ServerClientJoin;
using OpenTTD.Networking.Messages.Inbound.ServerClientQuit;
using OpenTTD.Networking.Messages.Inbound.ServerClientUpdate;
using OpenTTD.Networking.Messages.Inbound.ServerCompanyInfo;
using OpenTTD.Networking.Messages.Inbound.ServerCompanyNew;
using OpenTTD.Networking.Messages.Inbound.ServerCompanyRemove;
using OpenTTD.Networking.Messages.Inbound.ServerCompanyUpdate;
using OpenTTD.Networking.Messages.Inbound.ServerConsole;
using OpenTTD.Networking.Messages.Inbound.ServerPong;
using OpenTTD.Networking.Messages.Inbound.ServerProtocol;
using OpenTTD.Networking.Messages.Inbound.ServerRcon;
using OpenTTD.Networking.Messages.Inbound.ServerWelcome;
using OpenTTD.Networking.Messages.Outbound.Join;
using OpenTTD.Networking.Messages.Outbound.Ping;
using OpenTTD.Networking.Messages.Outbound.Poll;
using OpenTTD.Networking.Messages.Outbound.UpdateFrequency;

namespace OpenTTD.Networking.Messages;

public sealed class MessageDeserializer : IMessageDeserializer
{
    [Pure]
    public IMessage Deserialize(PacketType type, string json) => (type switch
    {
        PacketType.ADMIN_PACKET_ADMIN_JOIN => JsonConvert.DeserializeObject<JoinMessage>(json),
        PacketType.ADMIN_PACKET_ADMIN_UPDATE_FREQUENCY => JsonConvert.DeserializeObject<UpdateFrequencyMessage>(json),
        PacketType.ADMIN_PACKET_ADMIN_POLL => JsonConvert.DeserializeObject<PollMessage>(json),
        PacketType.ADMIN_PACKET_ADMIN_RCON => JsonConvert.DeserializeObject<ServerRconMessage>(json),
        PacketType.ADMIN_PACKET_ADMIN_PING => JsonConvert.DeserializeObject<PingMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_PROTOCOL => JsonConvert.DeserializeObject<ServerProtocolMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_WELCOME => JsonConvert.DeserializeObject<ServerWelcomeMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_CLIENT_JOIN => JsonConvert.DeserializeObject<ServerClientJoinMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_CLIENT_INFO => JsonConvert.DeserializeObject<ServerClientInfoMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_CLIENT_UPDATE => JsonConvert.DeserializeObject<ServerClientUpdateMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_CLIENT_QUIT => JsonConvert.DeserializeObject<ServerClientQuitMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_CLIENT_ERROR => JsonConvert.DeserializeObject<ServerClientErrorMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_COMPANY_NEW => JsonConvert.DeserializeObject<ServerCompanyNewMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_COMPANY_INFO => JsonConvert.DeserializeObject<ServerCompanyInfoMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_COMPANY_UPDATE => JsonConvert.DeserializeObject<ServerCompanyUpdateMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_COMPANY_REMOVE => JsonConvert.DeserializeObject<ServerCompanyRemoveMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_CHAT => JsonConvert.DeserializeObject<ServerChatMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_RCON => JsonConvert.DeserializeObject<ServerRconMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_CONSOLE => JsonConvert.DeserializeObject<ServerConsoleMessage>(json),
        PacketType.ADMIN_PACKET_SERVER_PONG => JsonConvert.DeserializeObject<ServerPongMessage>(json),
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
    })!;
}
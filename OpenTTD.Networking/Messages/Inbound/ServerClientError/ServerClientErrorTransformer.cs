﻿using OpenTTD.Networking.Abstractions.Messages;
using OpenTTD.Networking.Abstractions.Messages.Inbound;
using OpenTTD.Networking.Enums;

namespace OpenTTD.Networking.Messages.Inbound.ServerClientError;

public sealed class ServerClientErrorTransformer : IPacketTransformer
{
    public PacketType PacketType => PacketType.ADMIN_PACKET_SERVER_CLIENT_ERROR;

    public IMessage Transform(Packet packet)
    {
        var msg = new ServerClientErrorMessage(packet.ReadU32(), (NetworkErrorCode) packet.ReadByte());
        return msg;
    }
}
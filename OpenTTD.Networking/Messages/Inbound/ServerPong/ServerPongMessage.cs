﻿using OpenTTD.Networking.Abstractions.Messages;
using OpenTTD.Networking.Enums;

namespace OpenTTD.Networking.Messages.Inbound.ServerPong;

public sealed record ServerPongMessage(uint Argument) : IMessage
{
    public PacketType PacketType => PacketType.ADMIN_PACKET_SERVER_PONG;
}
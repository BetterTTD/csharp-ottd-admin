﻿using OpenTTD.Networking.Abstractions.Messages;
using OpenTTD.Networking.Enums;

namespace OpenTTD.Networking.Messages.Outbound.Join;

public sealed record JoinMessage : IMessage
{
    public PacketType PacketType => PacketType.ADMIN_PACKET_ADMIN_JOIN;
        
    public string Password { get; init; }
    public string AdminName { get; init; }
    public string AdminVersion { get; init; }
}
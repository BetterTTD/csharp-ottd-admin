﻿using OpenTTD.Networking.Abstractions.Messages;
using OpenTTD.Networking.Enums;

namespace OpenTTD.Networking.Messages.Inbound.ServerProtocol;

public sealed record ServerProtocolMessage(
    byte NetworkVersion, 
    Dictionary<UpdateType, Enums.UpdateFrequency> AdminUpdateSettings) : IMessage
{
    public PacketType PacketType => PacketType.ADMIN_PACKET_SERVER_PROTOCOL;
}
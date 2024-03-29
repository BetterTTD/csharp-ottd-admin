﻿using OpenTTD.Networking.Abstractions.Messages;
using OpenTTD.Networking.Enums;

namespace OpenTTD.Networking.Messages.Inbound.ServerCompanyNew;

public class ServerCompanyNewMessage(byte companyId) : IMessage
{
    public PacketType PacketType => PacketType.ADMIN_PACKET_SERVER_COMPANY_NEW;

    public byte CompanyId { get; } = companyId;
}
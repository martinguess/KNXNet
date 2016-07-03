﻿using KNXNet.Placeholders;

namespace KNXNet.Packets
{
    public class ConnectionStateRequest
    {
        public KNXNetIPHeader Header { get; set; }
        public byte ChannelId { get; set; }
        public byte Reserved { get; set; }
        public KNXNetIPHPAI ControlEndpoint { get; set; }
    }
}
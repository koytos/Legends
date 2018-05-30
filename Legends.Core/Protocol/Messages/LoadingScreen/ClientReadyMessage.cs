﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legends.Core.IO;

namespace Legends.Core.Protocol.LoadingScreen
{
    public class ClientReadyMessage : BaseMessage
    {
        public static PacketCmd PACKET_CMD = PacketCmd.PKT_C2S_ClientReady;
        public override PacketCmd Cmd => PACKET_CMD;

        public static Channel CHANNEL = Channel.CHL_LOADING_SCREEN;
        public override Channel Channel => CHANNEL;

        public ClientReadyMessage(int netId):base(netId)
        {

        }
        public ClientReadyMessage()
        {

        }
        public override void Deserialize(LittleEndianReader reader)
        {
      
        }

        public override void Serialize(LittleEndianWriter writer)
        {
           
        }
    }
}

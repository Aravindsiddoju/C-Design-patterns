﻿using BridgePattern.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Abstarct_Class
{
    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public abstract void Send();
    }
}

using BridgePattern.Abstarct_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Abstract_Impelementor
{
    /// <summary>
    /// abstraction class implemeneter
    /// </summary>
    class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}

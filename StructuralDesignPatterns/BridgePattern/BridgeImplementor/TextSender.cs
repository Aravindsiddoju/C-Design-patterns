using BridgePattern.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.BridgeImplementor
{
    class TextSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            string messageType = "text";
            Console.WriteLine($"You have received a {messageType} message with" +
                $" \n Subject as:: {subject} " +
                $"\n with boys as:: {body}");
        }
    }
}

using BridgePattern.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.BridgeImplementor
{
    class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            string messageType = "web";
            Console.WriteLine($"You have received a {messageType} message with" +
                $" \n Subject as:: {subject} " +
                $"\n with boys as:: {body}");
        }
    }
}

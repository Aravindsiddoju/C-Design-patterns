using BridgePattern.Abstarct_Class;
using BridgePattern.Abstract_Impelementor;
using BridgePattern.Bridge;
using BridgePattern.BridgeImplementor;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //bridge implementors
            IMessageSender textSender = new TextSender();
            IMessageSender webSender = new WebServiceSender();

            //abstraction implementor
            Message systemMessage = new SystemMessage();
            systemMessage.Subject = "A message";
            systemMessage.Body = "Hello, please accept the message";

            //decoupling abstraction from implementation
            systemMessage.MessageSender = textSender;
            systemMessage.Send();

            systemMessage.MessageSender = webSender;
            systemMessage.Send();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace exams
{
    public class TextMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("TextMessageSender: Sending text message...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace exams
{
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("EmailMessageSender: Sending email message...");
        }
    }
}

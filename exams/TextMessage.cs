using System;
using System.Collections.Generic;
using System.Text;

namespace exams
{
   
    public class TextMessage : Message
    {
        public TextMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send()
        {
            messageSender.SendMessage(this);
        }
    }
}

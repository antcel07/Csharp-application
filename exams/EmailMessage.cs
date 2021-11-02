using System;
using System.Collections.Generic;
using System.Text;

namespace exams
{
    public class EmailMessage : Message
    {
        public EmailMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send()
        {
            messageSender.SendMessage(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace exams
{
    public abstract class Message
    {
        protected IMessageSender messageSender;

        public Message(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public abstract void Send();
    }
}

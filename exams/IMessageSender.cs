using System;
using System.Collections.Generic;
using System.Text;

namespace exams
{
    public interface IMessageSender
    {
        void SendMessage(Message message);
    }
}

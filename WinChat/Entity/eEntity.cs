using System;
using System.Collections.Generic;

namespace WinChat
{
    public class eMessage
    {
        public string NICKNAME { get; set; }
        public string MESSAGE { get; set; }
        public string SENDDATE { get; set; }
        public List<object> ATTACHMENTS = new List<object>();

        public eMessage(string pNickname, string pMessage, string pSendDate, params object[] pAttach)
        {
            NICKNAME = pNickname;
            MESSAGE = pMessage;
            SENDDATE = pSendDate;

            foreach (object obj in pAttach)
                ATTACHMENTS.Add(obj);
        }

        public eMessage(string pNickname, string pMessage, string pSendDate)
        {
            NICKNAME = pNickname;
            MESSAGE = pMessage;
            SENDDATE = pSendDate;
        }

        public void Clear()
        {
            NICKNAME = MESSAGE = SENDDATE = String.Empty;
            ATTACHMENTS.Clear();
        }

    }
}

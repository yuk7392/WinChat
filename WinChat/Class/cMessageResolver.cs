using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using April.Common;

namespace WinChat
{
    public class MsgResolver
    {

        public static void AppendText(TextBox pTextBox, eMessage pMessage)
        {
            try
            {
                if (pMessage.ATTACHMENTS.Count != 0)
                    return;

                pTextBox.Text += "[" + pMessage.SENDDATE + "] " + pMessage.NICKNAME + " : " + pMessage.MESSAGE;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private static void SendAttachments(eMessage pMessage)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using April.Common;

namespace WinChat
{
    public partial class frm_CM_Client : AprilFormBase
    {
        public frm_CM_Client()
        {
            InitializeComponent();
        }

        public override void Received_DTO(DTOEventArgs e)
        {
            if (e.DSTNAME.Equals("frm_CM_Client"))
            {
                switch (e.SRCNAME)
                {
                    case "mdiWinChat":

                        break;
                }
            }
        }
    }
}

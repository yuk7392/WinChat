using April.Common;
using System;
using System.Drawing;

namespace WinChat
{
    public partial class frm_CM_Server : AprilFormBase
    {

        public frm_CM_Server()
        {
            InitializeComponent();

        }

        public override void Received_DTO(DTOEventArgs e)
        {
            if (e.DSTNAME.Equals("frm_CM_Server"))
            {
                switch (e.SRCNAME)
                {
                    case "mdiWinChat":
                        string ip = e.dataObject[0] as string;
                        string port = e.dataObject[1] as string;

                        tbServerStatIp.Text = ip;
                        tbServerStatPort.Text = port;
                        break;
                }
            }
        }

        private void rdbtnServer_Start_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnServer_Start.Checked)
            {
                lblServerStat.BackColor = Color.LimeGreen;
                lblServerStat.Text = "ONLINE";
            }
            else
            {
                lblServerStat.BackColor = Color.Crimson;
                lblServerStat.Text = "OFFLINE";
            }
        }
    }
}

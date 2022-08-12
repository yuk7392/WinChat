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
    public partial class mdiWinChat : AprilFormBase
    {
        public mdiWinChat()
        {
            InitializeComponent();
        }

        private void tsBtnSetting_Click(object sender, EventArgs e)
        {
            ToggleSetting();
        }

        private void ToggleSetting()
        {
            try
            {
                gbSetting.Visible = !gbSetting.Visible;

                if (gbSetting.Visible)
                {
                    AprCommon.SetLocationToCenter(this, gbSetting);
                    tsBtnSetting.Enabled = false;
                }
                else
                {
                    tsBtnSetting.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleSetting();
        }
    }
}

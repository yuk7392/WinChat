using April.Common;
using System;
using System.Windows.Forms;

namespace WinChat
{
    public partial class mdiWinChat : AprilFormBase
    {

        private string cUserType { get; set; }
        private string cNickname { get; set; }
        private string cIp { get; set; }
        private string cPort { get; set; }
        private bool cAutoUpdate { get; set; }

        public mdiWinChat()
        {
            InitializeComponent();

            if (!NetMgr.InternetConnected())
            {
                MsgBoxError("인터넷에 연결되어 있지 않습니다. 프로그램을 종료합니다.");
                Application.Exit();
            }

            GetSetting();
        }

        private void tsBtnSetting_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleSetting();
                GetSetting();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
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

        private void btnSetting_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleSetting();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void ClearSetting()
        {
            try
            {
                rdbtnSetting_User.Checked = true;

                rdbtnSetting_UpdateFalse.Checked = true;

                tbSetting_Nickname.Text = string.Empty;
                tbSetting_IP.Text = string.Empty;
                tbSetting_Port.Text = string.Empty;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void GetSetting()
        {
            try
            {
                ClearSetting();

                if (RegistryMgr.OpenKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH) == null)
                    return;

                rdbtnSetting_Server.Checked = RegistryMgr.GetApplicationKeyValue("Settings", "UserType").Equals("1") ? false : true;
                tbSetting_Nickname.Text = RegistryMgr.GetApplicationKeyValue("Settings", "Nickname");
                tbSetting_IP.Text = RegistryMgr.GetApplicationKeyValue("Settings", "IP");
                tbSetting_Port.Text = RegistryMgr.GetApplicationKeyValue("Settings", "Port");
                rdbtnSetting_UpdateFalse.Checked = RegistryMgr.GetApplicationKeyValue("Settings", "AutoUpdate").Equals("1") ? false : true;

                cUserType = rdbtnSetting_Server.Checked ? "Server" : "User";
                cNickname = tbSetting_Nickname.Text;
                cIp = tbSetting_IP.Text;
                cPort = tbSetting_Port.Text;
                cAutoUpdate = !rdbtnSetting_UpdateFalse.Checked;

                if (rdbtnSetting_Server.Checked)
                    rdbtnSetting_Server.PerformClick();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void SaveSetting()
        {
            try
            {
                RegistryMgr.CreateApplicationKeyValue("Settings", "UserType", rdbtnSetting_Server.Checked ? "0" : "1");
                RegistryMgr.CreateApplicationKeyValue("Settings", "Nickname", tbSetting_Nickname.Text);
                RegistryMgr.CreateApplicationKeyValue("Settings", "IP", tbSetting_IP.Text);
                RegistryMgr.CreateApplicationKeyValue("Settings", "Port", tbSetting_Port.Text);
                RegistryMgr.CreateApplicationKeyValue("Settings", "AutoUpdate", rdbtnSetting_UpdateFalse.Checked ? "0" : "1");

                GetSetting();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void ResetSetting()
        {
            try
            {
                if (RegistryMgr.OpenKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH) != null)
                {
                    RegistryMgr.DeleteKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);
                    ClearSetting();
                    cUserType = cNickname = cIp = cPort = string.Empty;
                    cAutoUpdate = false;
                }
                else
                {
                    MsgBoxError("저장된 설정이 존재하지 않습니다.");
                }
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnSetting_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSetting_IP.Text) || string.IsNullOrEmpty(tbSetting_Nickname.Text) || string.IsNullOrEmpty(tbSetting_Port.Text))
            {
                MsgBoxError("빈칸없이 작성하세요.");
                return;
            }

            SaveSetting();
            ToggleSetting();
        }

        private void btnSetting_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgBoxYesNoCancel("모든 설정을 삭제하시겠습니까?") != DialogResult.Yes)
                    return;

                ResetSetting();
                ToggleSetting();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void rdbtnSetting_Server_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSetting_Server.Checked)
            {
                tsBtnOpenServer.Enabled = true;

                tbSetting_IP.Enabled = false;
                tbSetting_IP.Text = NetMgr.GetPublicIP();
            }
            else
            {
                tsBtnOpenServer.Enabled = false;

                tbSetting_IP.Enabled = true;
            }
        }

        private void tsBtnOpenServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormMgr.IsFormOpened("frm_CM_Server"))
                {
                    FormMgr.GetOpenForm("frm_CM_Server").Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cIp) || string.IsNullOrEmpty(cPort))
                {
                    MsgBoxError("설정된 정보가 존재하지 않습니다.");
                    return;
                }

                FormMgr.ShowForm("frm_CM_Server", false, this, new DTOEventArgs(this.GetType().Name, "frm_CM_Server", string.Empty, cIp, cPort));
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void tsBtnConnect_Click(object sender, EventArgs e)
        {
            if (FormMgr.IsFormOpened("frm_CM_Client"))
            {
                FormMgr.GetOpenForm("frm_CM_Client").Focus();
                return;
            }

            if (string.IsNullOrEmpty(cIp) || string.IsNullOrEmpty(cPort))
            {
                MsgBoxError("설정된 정보가 존재하지 않습니다.");
                return;
            }

            FormMgr.ShowForm("frm_CM_Client", false, this, new DTOEventArgs(this.GetType().Name, "frm_CM_Client", string.Empty, cIp, cPort));

        }
    }
}

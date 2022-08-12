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
                    RegistryMgr.DeleteKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);
                else
                    MsgBoxError("저장된 설정이 존재하지 않습니다.");
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
    }
}

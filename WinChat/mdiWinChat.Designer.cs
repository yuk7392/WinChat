namespace WinChat
{
    partial class mdiWinChat
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiWinChat));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsBtnSetting = new System.Windows.Forms.ToolStripButton();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetting_Reset = new System.Windows.Forms.Button();
            this.btnSetting_Cancel = new System.Windows.Forms.Button();
            this.btnSetting_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbtnSetting_Server = new System.Windows.Forms.RadioButton();
            this.rdbtnSetting_User = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbtnSetting_UpdateTrue = new System.Windows.Forms.RadioButton();
            this.rdbtnSetting_UpdateFalse = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.gbSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(997, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(997, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsBtnSetting
            // 
            this.tsBtnSetting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSetting.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.tsBtnSetting.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSetting.Image")));
            this.tsBtnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSetting.Name = "tsBtnSetting";
            this.tsBtnSetting.Size = new System.Drawing.Size(57, 23);
            this.tsBtnSetting.Text = "설정";
            this.tsBtnSetting.Click += new System.EventHandler(this.tsBtnSetting_Click);
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.tableLayoutPanel1);
            this.gbSetting.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.gbSetting.Location = new System.Drawing.Point(498, 169);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(467, 369);
            this.gbSetting.TabIndex = 3;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "설정";
            this.gbSetting.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnSetting_Save, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSetting_Cancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSetting_Reset, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 284);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(453, 53);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(453, 49);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 60);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(453, 49);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 116);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(453, 49);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Controls.Add(this.textBox3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 172);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(453, 49);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 228);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(453, 49);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // btnSetting_Reset
            // 
            this.btnSetting_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting_Reset.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnSetting_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting_Reset.Image")));
            this.btnSetting_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting_Reset.Location = new System.Drawing.Point(4, 4);
            this.btnSetting_Reset.Name = "btnSetting_Reset";
            this.btnSetting_Reset.Size = new System.Drawing.Size(106, 45);
            this.btnSetting_Reset.TabIndex = 4;
            this.btnSetting_Reset.Text = "초기화";
            this.btnSetting_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting_Reset.UseVisualStyleBackColor = true;
            // 
            // btnSetting_Cancel
            // 
            this.btnSetting_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting_Cancel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnSetting_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting_Cancel.Image")));
            this.btnSetting_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting_Cancel.Location = new System.Drawing.Point(230, 4);
            this.btnSetting_Cancel.Name = "btnSetting_Cancel";
            this.btnSetting_Cancel.Size = new System.Drawing.Size(106, 45);
            this.btnSetting_Cancel.TabIndex = 6;
            this.btnSetting_Cancel.Text = " 취소";
            this.btnSetting_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting_Cancel.UseVisualStyleBackColor = true;
            this.btnSetting_Cancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSetting_Save
            // 
            this.btnSetting_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting_Save.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnSetting_Save.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting_Save.Image")));
            this.btnSetting_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting_Save.Location = new System.Drawing.Point(343, 4);
            this.btnSetting_Save.Name = "btnSetting_Save";
            this.btnSetting_Save.Size = new System.Drawing.Size(106, 45);
            this.btnSetting_Save.TabIndex = 7;
            this.btnSetting_Save.Text = " 저장";
            this.btnSetting_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting_Save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "구분";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "닉네임";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "PORT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 47);
            this.label5.TabIndex = 5;
            this.label5.Text = "자동 업데이트";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.rdbtnSetting_User, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.rdbtnSetting_Server, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(140, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(309, 41);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // rdbtnSetting_Server
            // 
            this.rdbtnSetting_Server.AutoSize = true;
            this.rdbtnSetting_Server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbtnSetting_Server.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtnSetting_Server.Location = new System.Drawing.Point(5, 5);
            this.rdbtnSetting_Server.Name = "rdbtnSetting_Server";
            this.rdbtnSetting_Server.Size = new System.Drawing.Size(145, 31);
            this.rdbtnSetting_Server.TabIndex = 0;
            this.rdbtnSetting_Server.TabStop = true;
            this.rdbtnSetting_Server.Text = "서버";
            this.rdbtnSetting_Server.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnSetting_Server.UseVisualStyleBackColor = true;
            // 
            // rdbtnSetting_User
            // 
            this.rdbtnSetting_User.AutoSize = true;
            this.rdbtnSetting_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbtnSetting_User.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtnSetting_User.Location = new System.Drawing.Point(158, 5);
            this.rdbtnSetting_User.Name = "rdbtnSetting_User";
            this.rdbtnSetting_User.Size = new System.Drawing.Size(146, 31);
            this.rdbtnSetting_User.TabIndex = 1;
            this.rdbtnSetting_User.TabStop = true;
            this.rdbtnSetting_User.Text = "클라이언트";
            this.rdbtnSetting_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnSetting_User.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.textBox1.Location = new System.Drawing.Point(140, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(309, 41);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.textBox2.Location = new System.Drawing.Point(140, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(309, 41);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.textBox3.Location = new System.Drawing.Point(140, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(309, 41);
            this.textBox3.TabIndex = 7;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.rdbtnSetting_UpdateTrue, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.rdbtnSetting_UpdateFalse, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(140, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(309, 41);
            this.tableLayoutPanel9.TabIndex = 6;
            // 
            // rdbtnSetting_UpdateTrue
            // 
            this.rdbtnSetting_UpdateTrue.AutoSize = true;
            this.rdbtnSetting_UpdateTrue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbtnSetting_UpdateTrue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtnSetting_UpdateTrue.Location = new System.Drawing.Point(158, 5);
            this.rdbtnSetting_UpdateTrue.Name = "rdbtnSetting_UpdateTrue";
            this.rdbtnSetting_UpdateTrue.Size = new System.Drawing.Size(146, 31);
            this.rdbtnSetting_UpdateTrue.TabIndex = 1;
            this.rdbtnSetting_UpdateTrue.TabStop = true;
            this.rdbtnSetting_UpdateTrue.Text = "사용";
            this.rdbtnSetting_UpdateTrue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnSetting_UpdateTrue.UseVisualStyleBackColor = true;
            // 
            // rdbtnSetting_UpdateFalse
            // 
            this.rdbtnSetting_UpdateFalse.AutoSize = true;
            this.rdbtnSetting_UpdateFalse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbtnSetting_UpdateFalse.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtnSetting_UpdateFalse.Location = new System.Drawing.Point(5, 5);
            this.rdbtnSetting_UpdateFalse.Name = "rdbtnSetting_UpdateFalse";
            this.rdbtnSetting_UpdateFalse.Size = new System.Drawing.Size(145, 31);
            this.rdbtnSetting_UpdateFalse.TabIndex = 0;
            this.rdbtnSetting_UpdateFalse.TabStop = true;
            this.rdbtnSetting_UpdateFalse.Text = "사용안함";
            this.rdbtnSetting_UpdateFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnSetting_UpdateFalse.UseVisualStyleBackColor = true;
            // 
            // mdiWinChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 563);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mdiWinChat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbSetting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnSetting;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSetting_Save;
        private System.Windows.Forms.Button btnSetting_Cancel;
        private System.Windows.Forms.Button btnSetting_Reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.RadioButton rdbtnSetting_User;
        private System.Windows.Forms.RadioButton rdbtnSetting_Server;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.RadioButton rdbtnSetting_UpdateTrue;
        private System.Windows.Forms.RadioButton rdbtnSetting_UpdateFalse;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}


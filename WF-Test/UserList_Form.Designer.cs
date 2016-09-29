namespace WF_Test
{
    partial class UserList_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.UF_BT_BlockUser = new System.Windows.Forms.Button();
            this.UF_BT_Close = new System.Windows.Forms.Button();
            this.UF_BT_EditUser = new System.Windows.Forms.Button();
            this.UF_BT_Refresh = new System.Windows.Forms.Button();
            this.UF_BT_DelUser = new System.Windows.Forms.Button();
            this.UF_BT_AddUser = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WF_Test_TableModelDataSet = new WF_Test._WF_Test_TableModelDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.appUsersTableAdapter = new WF_Test._WF_Test_TableModelDataSetTableAdapters.AppUsersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ToolPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WF_Test_TableModelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.Controls.Add(this.UF_BT_BlockUser);
            this.ToolPanel.Controls.Add(this.UF_BT_Close);
            this.ToolPanel.Controls.Add(this.UF_BT_EditUser);
            this.ToolPanel.Controls.Add(this.UF_BT_Refresh);
            this.ToolPanel.Controls.Add(this.UF_BT_DelUser);
            this.ToolPanel.Controls.Add(this.UF_BT_AddUser);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(997, 60);
            this.ToolPanel.TabIndex = 1;
            // 
            // UF_BT_BlockUser
            // 
            this.UF_BT_BlockUser.Image = ((System.Drawing.Image)(resources.GetObject("UF_BT_BlockUser.Image")));
            this.UF_BT_BlockUser.Location = new System.Drawing.Point(183, 3);
            this.UF_BT_BlockUser.Name = "UF_BT_BlockUser";
            this.UF_BT_BlockUser.Size = new System.Drawing.Size(54, 54);
            this.UF_BT_BlockUser.TabIndex = 4;
            this.toolTip1.SetToolTip(this.UF_BT_BlockUser, "Заблокувати користувача");
            this.UF_BT_BlockUser.UseVisualStyleBackColor = true;
            this.UF_BT_BlockUser.Click += new System.EventHandler(this.UF_BT_BlockUser_Click);
            // 
            // UF_BT_Close
            // 
            this.UF_BT_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UF_BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("UF_BT_Close.Image")));
            this.UF_BT_Close.Location = new System.Drawing.Point(940, 3);
            this.UF_BT_Close.Name = "UF_BT_Close";
            this.UF_BT_Close.Size = new System.Drawing.Size(54, 54);
            this.UF_BT_Close.TabIndex = 6;
            this.toolTip1.SetToolTip(this.UF_BT_Close, "Вийти");
            this.UF_BT_Close.UseVisualStyleBackColor = true;
            this.UF_BT_Close.Click += new System.EventHandler(this.UF_BT_Close_Click);
            // 
            // UF_BT_EditUser
            // 
            this.UF_BT_EditUser.Image = ((System.Drawing.Image)(resources.GetObject("UF_BT_EditUser.Image")));
            this.UF_BT_EditUser.Location = new System.Drawing.Point(63, 3);
            this.UF_BT_EditUser.Name = "UF_BT_EditUser";
            this.UF_BT_EditUser.Size = new System.Drawing.Size(54, 54);
            this.UF_BT_EditUser.TabIndex = 2;
            this.toolTip1.SetToolTip(this.UF_BT_EditUser, "Редагувати облікові дані");
            this.UF_BT_EditUser.UseVisualStyleBackColor = true;
            this.UF_BT_EditUser.Click += new System.EventHandler(this.UF_BT_EditUser_Click);
            // 
            // UF_BT_Refresh
            // 
            this.UF_BT_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("UF_BT_Refresh.Image")));
            this.UF_BT_Refresh.Location = new System.Drawing.Point(243, 3);
            this.UF_BT_Refresh.Name = "UF_BT_Refresh";
            this.UF_BT_Refresh.Size = new System.Drawing.Size(54, 54);
            this.UF_BT_Refresh.TabIndex = 5;
            this.toolTip1.SetToolTip(this.UF_BT_Refresh, "Оновити");
            this.UF_BT_Refresh.UseVisualStyleBackColor = true;
            this.UF_BT_Refresh.Click += new System.EventHandler(this.UF_BT_Refresh_Click);
            // 
            // UF_BT_DelUser
            // 
            this.UF_BT_DelUser.Image = ((System.Drawing.Image)(resources.GetObject("UF_BT_DelUser.Image")));
            this.UF_BT_DelUser.Location = new System.Drawing.Point(123, 3);
            this.UF_BT_DelUser.Name = "UF_BT_DelUser";
            this.UF_BT_DelUser.Size = new System.Drawing.Size(54, 54);
            this.UF_BT_DelUser.TabIndex = 3;
            this.toolTip1.SetToolTip(this.UF_BT_DelUser, "Видалити користувача");
            this.UF_BT_DelUser.UseVisualStyleBackColor = true;
            this.UF_BT_DelUser.Click += new System.EventHandler(this.UF_BT_DelUser_Click);
            // 
            // UF_BT_AddUser
            // 
            this.UF_BT_AddUser.Image = ((System.Drawing.Image)(resources.GetObject("UF_BT_AddUser.Image")));
            this.UF_BT_AddUser.Location = new System.Drawing.Point(3, 3);
            this.UF_BT_AddUser.Name = "UF_BT_AddUser";
            this.UF_BT_AddUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UF_BT_AddUser.Size = new System.Drawing.Size(54, 54);
            this.UF_BT_AddUser.TabIndex = 1;
            this.toolTip1.SetToolTip(this.UF_BT_AddUser, "Додати користувача");
            this.UF_BT_AddUser.UseCompatibleTextRendering = true;
            this.UF_BT_AddUser.UseVisualStyleBackColor = true;
            this.UF_BT_AddUser.Click += new System.EventHandler(this.UF_BT_AddUser_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.dataGridView1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 60);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(997, 266);
            this.ContentPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.saltDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.appUsersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(997, 266);
            this.dataGridView1.TabIndex = 7;
            // 
            // appUsersBindingSource
            // 
            this.appUsersBindingSource.DataMember = "AppUsers";
            this.appUsersBindingSource.DataSource = this._WF_Test_TableModelDataSet;
            // 
            // _WF_Test_TableModelDataSet
            // 
            this._WF_Test_TableModelDataSet.DataSetName = "_WF_Test_TableModelDataSet";
            this._WF_Test_TableModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appUsersTableAdapter
            // 
            this.appUsersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логін";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Хеш пароля";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.passwordDataGridViewTextBoxColumn.Width = 230;
            // 
            // saltDataGridViewTextBoxColumn
            // 
            this.saltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.saltDataGridViewTextBoxColumn.DataPropertyName = "Salt";
            this.saltDataGridViewTextBoxColumn.HeaderText = "Сіль :)";
            this.saltDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.saltDataGridViewTextBoxColumn.Name = "saltDataGridViewTextBoxColumn";
            this.saltDataGridViewTextBoxColumn.ReadOnly = true;
            this.saltDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ПІБ користувача";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Активний";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 70;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isActiveDataGridViewCheckBoxColumn.Width = 70;
            // 
            // UserList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 326);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ToolPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserList_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Користувачі системи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserList_Form_FormClosed);
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.VisibleChanged += new System.EventHandler(this.UF_BT_Refresh_Click);
            this.ToolPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WF_Test_TableModelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UF_BT_DelUser;
        private System.Windows.Forms.Button UF_BT_AddUser;
        private System.Windows.Forms.Button UF_BT_EditUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button UF_BT_Close;
        private _WF_Test_TableModelDataSet _WF_Test_TableModelDataSet;
        private System.Windows.Forms.BindingSource appUsersBindingSource;
        private _WF_Test_TableModelDataSetTableAdapters.AppUsersTableAdapter appUsersTableAdapter;
        private System.Windows.Forms.Button UF_BT_Refresh;
        private System.Windows.Forms.Button UF_BT_BlockUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}
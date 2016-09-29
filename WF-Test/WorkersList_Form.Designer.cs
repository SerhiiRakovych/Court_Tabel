namespace WF_Test
{
    partial class WorkersList_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersList_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WF_Refresh_BT = new System.Windows.Forms.Button();
            this.WF_Archive_BT = new System.Windows.Forms.Button();
            this.WF_Edit_BT = new System.Windows.Forms.Button();
            this.WF_AddUser_BT = new System.Windows.Forms.Button();
            this.WF_Close_BT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WF_Test_TableModelDataSet1 = new WF_Test._WF_Test_TableModelDataSet1();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.workersTableAdapter = new WF_Test._WF_Test_TableModelDataSet1TableAdapters.WorkersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArchiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WF_Test_TableModelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WF_Refresh_BT);
            this.panel1.Controls.Add(this.WF_Archive_BT);
            this.panel1.Controls.Add(this.WF_Edit_BT);
            this.panel1.Controls.Add(this.WF_AddUser_BT);
            this.panel1.Controls.Add(this.WF_Close_BT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 0;
            // 
            // WF_Refresh_BT
            // 
            this.WF_Refresh_BT.Image = ((System.Drawing.Image)(resources.GetObject("WF_Refresh_BT.Image")));
            this.WF_Refresh_BT.Location = new System.Drawing.Point(183, 3);
            this.WF_Refresh_BT.Name = "WF_Refresh_BT";
            this.WF_Refresh_BT.Size = new System.Drawing.Size(54, 54);
            this.WF_Refresh_BT.TabIndex = 4;
            this.toolTip1.SetToolTip(this.WF_Refresh_BT, "Поновити");
            this.WF_Refresh_BT.UseVisualStyleBackColor = true;
            this.WF_Refresh_BT.Click += new System.EventHandler(this.WF_Refresh_BT_Click);
            // 
            // WF_Archive_BT
            // 
            this.WF_Archive_BT.Image = ((System.Drawing.Image)(resources.GetObject("WF_Archive_BT.Image")));
            this.WF_Archive_BT.Location = new System.Drawing.Point(123, 3);
            this.WF_Archive_BT.Name = "WF_Archive_BT";
            this.WF_Archive_BT.Size = new System.Drawing.Size(54, 54);
            this.WF_Archive_BT.TabIndex = 3;
            this.toolTip1.SetToolTip(this.WF_Archive_BT, "Перенести в архів");
            this.WF_Archive_BT.UseVisualStyleBackColor = true;
            this.WF_Archive_BT.Click += new System.EventHandler(this.WF_Archive_BT_Click);
            // 
            // WF_Edit_BT
            // 
            this.WF_Edit_BT.Image = ((System.Drawing.Image)(resources.GetObject("WF_Edit_BT.Image")));
            this.WF_Edit_BT.Location = new System.Drawing.Point(63, 3);
            this.WF_Edit_BT.Name = "WF_Edit_BT";
            this.WF_Edit_BT.Size = new System.Drawing.Size(54, 54);
            this.WF_Edit_BT.TabIndex = 2;
            this.toolTip1.SetToolTip(this.WF_Edit_BT, "Редагувати персональні дані");
            this.WF_Edit_BT.UseVisualStyleBackColor = true;
            this.WF_Edit_BT.Click += new System.EventHandler(this.WF_Edit_BT_Click);
            // 
            // WF_AddUser_BT
            // 
            this.WF_AddUser_BT.Image = ((System.Drawing.Image)(resources.GetObject("WF_AddUser_BT.Image")));
            this.WF_AddUser_BT.Location = new System.Drawing.Point(3, 3);
            this.WF_AddUser_BT.Name = "WF_AddUser_BT";
            this.WF_AddUser_BT.Size = new System.Drawing.Size(54, 54);
            this.WF_AddUser_BT.TabIndex = 1;
            this.toolTip1.SetToolTip(this.WF_AddUser_BT, "Додати працівника");
            this.WF_AddUser_BT.UseVisualStyleBackColor = true;
            this.WF_AddUser_BT.Click += new System.EventHandler(this.WF_AddUser_BT_Click);
            // 
            // WF_Close_BT
            // 
            this.WF_Close_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WF_Close_BT.Image = ((System.Drawing.Image)(resources.GetObject("WF_Close_BT.Image")));
            this.WF_Close_BT.Location = new System.Drawing.Point(927, 3);
            this.WF_Close_BT.Name = "WF_Close_BT";
            this.WF_Close_BT.Size = new System.Drawing.Size(54, 54);
            this.WF_Close_BT.TabIndex = 5;
            this.toolTip1.SetToolTip(this.WF_Close_BT, "Вийти");
            this.WF_Close_BT.UseVisualStyleBackColor = true;
            this.WF_Close_BT.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 340);
            this.panel2.TabIndex = 1;
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
            this.orderNumDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.isArchiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 340);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.WF_Refresh_BT_Click);
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this._WF_Test_TableModelDataSet1;
            // 
            // _WF_Test_TableModelDataSet1
            // 
            this._WF_Test_TableModelDataSet1.DataSetName = "_WF_Test_TableModelDataSet1";
            this._WF_Test_TableModelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 284.264F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderNumDataGridViewTextBoxColumn
            // 
            this.orderNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderNumDataGridViewTextBoxColumn.DataPropertyName = "OrderNum";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderNumDataGridViewTextBoxColumn.FillWeight = 1.040824F;
            this.orderNumDataGridViewTextBoxColumn.HeaderText = "Індекс";
            this.orderNumDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.orderNumDataGridViewTextBoxColumn.Name = "orderNumDataGridViewTextBoxColumn";
            this.orderNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderNumDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 3.733718F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 6.146693F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.FillWeight = 51.64001F;
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Побатькові";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.FillWeight = 353.0076F;
            this.postDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.postDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isArchiveDataGridViewCheckBoxColumn
            // 
            this.isArchiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isArchiveDataGridViewCheckBoxColumn.DataPropertyName = "IsArchive";
            this.isArchiveDataGridViewCheckBoxColumn.FillWeight = 0.1672282F;
            this.isArchiveDataGridViewCheckBoxColumn.HeaderText = "Звільнений";
            this.isArchiveDataGridViewCheckBoxColumn.MinimumWidth = 70;
            this.isArchiveDataGridViewCheckBoxColumn.Name = "isArchiveDataGridViewCheckBoxColumn";
            this.isArchiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isArchiveDataGridViewCheckBoxColumn.Width = 70;
            // 
            // WorkersList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkersList_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Працівники суду";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkersList_Form_FormClosed);
            this.Load += new System.EventHandler(this.WorkersList_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WF_Test_TableModelDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button WF_Close_BT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button WF_AddUser_BT;
        private System.Windows.Forms.Button WF_Edit_BT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button WF_Refresh_BT;
        private System.Windows.Forms.Button WF_Archive_BT;
        private _WF_Test_TableModelDataSet1 _WF_Test_TableModelDataSet1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private _WF_Test_TableModelDataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isArchiveDataGridViewCheckBoxColumn;
    }
}
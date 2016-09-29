namespace WF_Test
{
    partial class WorkerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.WF_FN_TB = new System.Windows.Forms.TextBox();
            this.WF_LN_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WF_MN_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WF_Post_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WF_Order_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WF_Archive_ChBox = new System.Windows.Forms.CheckBox();
            this.WF_Add_BT = new System.Windows.Forms.Button();
            this.WF_Exit_BT = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище";
            // 
            // WF_FN_TB
            // 
            this.WF_FN_TB.Location = new System.Drawing.Point(16, 29);
            this.WF_FN_TB.Name = "WF_FN_TB";
            this.WF_FN_TB.Size = new System.Drawing.Size(286, 22);
            this.WF_FN_TB.TabIndex = 1;
            // 
            // WF_LN_TB
            // 
            this.WF_LN_TB.Location = new System.Drawing.Point(16, 75);
            this.WF_LN_TB.Name = "WF_LN_TB";
            this.WF_LN_TB.Size = new System.Drawing.Size(286, 22);
            this.WF_LN_TB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ім\'я";
            // 
            // WF_MN_TB
            // 
            this.WF_MN_TB.Location = new System.Drawing.Point(16, 123);
            this.WF_MN_TB.Name = "WF_MN_TB";
            this.WF_MN_TB.Size = new System.Drawing.Size(286, 22);
            this.WF_MN_TB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Побатькові";
            // 
            // WF_Post_TB
            // 
            this.WF_Post_TB.Location = new System.Drawing.Point(16, 174);
            this.WF_Post_TB.Name = "WF_Post_TB";
            this.WF_Post_TB.Size = new System.Drawing.Size(286, 22);
            this.WF_Post_TB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Посада";
            // 
            // WF_Order_TB
            // 
            this.WF_Order_TB.Location = new System.Drawing.Point(16, 220);
            this.WF_Order_TB.Name = "WF_Order_TB";
            this.WF_Order_TB.Size = new System.Drawing.Size(163, 22);
            this.WF_Order_TB.TabIndex = 5;
            this.WF_Order_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WF_Order_TB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Індех сортування в табелі";
            // 
            // WF_Archive_ChBox
            // 
            this.WF_Archive_ChBox.AutoSize = true;
            this.WF_Archive_ChBox.Location = new System.Drawing.Point(16, 255);
            this.WF_Archive_ChBox.Name = "WF_Archive_ChBox";
            this.WF_Archive_ChBox.Size = new System.Drawing.Size(136, 17);
            this.WF_Archive_ChBox.TabIndex = 6;
            this.WF_Archive_ChBox.Text = "Звільнений з посади";
            this.WF_Archive_ChBox.UseVisualStyleBackColor = true;
            // 
            // WF_Add_BT
            // 
            this.WF_Add_BT.Image = ((System.Drawing.Image)(resources.GetObject("WF_Add_BT.Image")));
            this.WF_Add_BT.Location = new System.Drawing.Point(16, 283);
            this.WF_Add_BT.Name = "WF_Add_BT";
            this.WF_Add_BT.Size = new System.Drawing.Size(50, 50);
            this.WF_Add_BT.TabIndex = 7;
            this.toolTip1.SetToolTip(this.WF_Add_BT, "Додати працівника");
            this.WF_Add_BT.UseVisualStyleBackColor = true;
            this.WF_Add_BT.Click += new System.EventHandler(this.WF_Add_BT_Click);
            // 
            // WF_Exit_BT
            // 
            this.WF_Exit_BT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WF_Exit_BT.Image = ((System.Drawing.Image)(resources.GetObject("WF_Exit_BT.Image")));
            this.WF_Exit_BT.Location = new System.Drawing.Point(252, 283);
            this.WF_Exit_BT.Name = "WF_Exit_BT";
            this.WF_Exit_BT.Size = new System.Drawing.Size(50, 50);
            this.WF_Exit_BT.TabIndex = 8;
            this.toolTip1.SetToolTip(this.WF_Exit_BT, "Вихід");
            this.WF_Exit_BT.UseVisualStyleBackColor = true;
            // 
            // WorkerAdd
            // 
            this.AcceptButton = this.WF_Add_BT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.WF_Exit_BT;
            this.ClientSize = new System.Drawing.Size(314, 342);
            this.Controls.Add(this.WF_Exit_BT);
            this.Controls.Add(this.WF_Add_BT);
            this.Controls.Add(this.WF_Archive_ChBox);
            this.Controls.Add(this.WF_Order_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WF_Post_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WF_MN_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WF_LN_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WF_FN_TB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(330, 380);
            this.MinimumSize = new System.Drawing.Size(330, 380);
            this.Name = "WorkerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання працівника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkerAdd_FormClosed);
            this.Shown += new System.EventHandler(this.WorkerAdd_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WF_FN_TB;
        private System.Windows.Forms.TextBox WF_LN_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WF_MN_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WF_Post_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WF_Order_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox WF_Archive_ChBox;
        private System.Windows.Forms.Button WF_Add_BT;
        private System.Windows.Forms.Button WF_Exit_BT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
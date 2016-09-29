namespace WF_Test
{
    partial class UserAdd_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdd_Form));
            this.ADF_BT_Accept = new System.Windows.Forms.Button();
            this.ADF_BT_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PIB_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.IsBlock_CHB = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ConfirmPassword_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADF_BT_Accept
            // 
            this.ADF_BT_Accept.Image = ((System.Drawing.Image)(resources.GetObject("ADF_BT_Accept.Image")));
            this.ADF_BT_Accept.Location = new System.Drawing.Point(15, 260);
            this.ADF_BT_Accept.Name = "ADF_BT_Accept";
            this.ADF_BT_Accept.Size = new System.Drawing.Size(50, 50);
            this.ADF_BT_Accept.TabIndex = 6;
            this.toolTip1.SetToolTip(this.ADF_BT_Accept, "Додати користувача");
            this.ADF_BT_Accept.UseVisualStyleBackColor = true;
            this.ADF_BT_Accept.Click += new System.EventHandler(this.ADF_BT_Accept_Click);
            // 
            // ADF_BT_Cancel
            // 
            this.ADF_BT_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("ADF_BT_Cancel.Image")));
            this.ADF_BT_Cancel.Location = new System.Drawing.Point(252, 260);
            this.ADF_BT_Cancel.Name = "ADF_BT_Cancel";
            this.ADF_BT_Cancel.Size = new System.Drawing.Size(50, 50);
            this.ADF_BT_Cancel.TabIndex = 7;
            this.toolTip1.SetToolTip(this.ADF_BT_Cancel, "Відміна");
            this.ADF_BT_Cancel.UseVisualStyleBackColor = true;
            this.ADF_BT_Cancel.Click += new System.EventHandler(this.ADF_BT_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПІБ користувача";
            // 
            // PIB_TB
            // 
            this.PIB_TB.Location = new System.Drawing.Point(15, 25);
            this.PIB_TB.Name = "PIB_TB";
            this.PIB_TB.Size = new System.Drawing.Size(287, 20);
            this.PIB_TB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логін";
            // 
            // Login_TB
            // 
            this.Login_TB.Location = new System.Drawing.Point(15, 75);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(287, 20);
            this.Login_TB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пароль";
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(15, 123);
            this.Password_TB.MaxLength = 16;
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(287, 20);
            this.Password_TB.TabIndex = 3;
            // 
            // IsBlock_CHB
            // 
            this.IsBlock_CHB.AutoSize = true;
            this.IsBlock_CHB.Checked = true;
            this.IsBlock_CHB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsBlock_CHB.Location = new System.Drawing.Point(15, 218);
            this.IsBlock_CHB.Name = "IsBlock_CHB";
            this.IsBlock_CHB.Size = new System.Drawing.Size(74, 17);
            this.IsBlock_CHB.TabIndex = 5;
            this.IsBlock_CHB.Text = "Активний";
            this.IsBlock_CHB.UseVisualStyleBackColor = true;
            // 
            // ConfirmPassword_TB
            // 
            this.ConfirmPassword_TB.Location = new System.Drawing.Point(15, 180);
            this.ConfirmPassword_TB.MaxLength = 16;
            this.ConfirmPassword_TB.Name = "ConfirmPassword_TB";
            this.ConfirmPassword_TB.PasswordChar = '*';
            this.ConfirmPassword_TB.Size = new System.Drawing.Size(287, 20);
            this.ConfirmPassword_TB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Підтвердження";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(279, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserAdd_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfirmPassword_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IsBlock_CHB);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PIB_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADF_BT_Cancel);
            this.Controls.Add(this.ADF_BT_Accept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(330, 360);
            this.MinimumSize = new System.Drawing.Size(330, 360);
            this.Name = "UserAdd_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання користувача";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserAdd_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADF_BT_Accept;
        private System.Windows.Forms.Button ADF_BT_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PIB_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.CheckBox IsBlock_CHB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox ConfirmPassword_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
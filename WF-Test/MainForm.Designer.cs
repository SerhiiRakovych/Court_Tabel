namespace WF_Test
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TAB_Open = new System.Windows.Forms.Button();
            this.TAB_Add = new System.Windows.Forms.Button();
            this.TAB_Worker = new System.Windows.Forms.Button();
            this.TAB_About = new System.Windows.Forms.Button();
            this.TAB_User = new System.Windows.Forms.Button();
            this.TAB_Exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TAB_Open
            // 
            this.TAB_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TAB_Open.Image = ((System.Drawing.Image)(resources.GetObject("TAB_Open.Image")));
            this.TAB_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_Open.Location = new System.Drawing.Point(31, 91);
            this.TAB_Open.Name = "TAB_Open";
            this.TAB_Open.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TAB_Open.Size = new System.Drawing.Size(280, 60);
            this.TAB_Open.TabIndex = 2;
            this.TAB_Open.Text = "Архів";
            this.toolTip1.SetToolTip(this.TAB_Open, "Завантажити табель з архіву");
            this.TAB_Open.UseVisualStyleBackColor = true;
            // 
            // TAB_Add
            // 
            this.TAB_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TAB_Add.Image = ((System.Drawing.Image)(resources.GetObject("TAB_Add.Image")));
            this.TAB_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_Add.Location = new System.Drawing.Point(31, 25);
            this.TAB_Add.Name = "TAB_Add";
            this.TAB_Add.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TAB_Add.Size = new System.Drawing.Size(280, 60);
            this.TAB_Add.TabIndex = 1;
            this.TAB_Add.Text = "Додати табель";
            this.toolTip1.SetToolTip(this.TAB_Add, "Створити новий табель");
            this.TAB_Add.UseVisualStyleBackColor = true;
            // 
            // TAB_Worker
            // 
            this.TAB_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TAB_Worker.Image = ((System.Drawing.Image)(resources.GetObject("TAB_Worker.Image")));
            this.TAB_Worker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_Worker.Location = new System.Drawing.Point(31, 157);
            this.TAB_Worker.Name = "TAB_Worker";
            this.TAB_Worker.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TAB_Worker.Size = new System.Drawing.Size(280, 60);
            this.TAB_Worker.TabIndex = 3;
            this.TAB_Worker.Text = "Працівники суду";
            this.toolTip1.SetToolTip(this.TAB_Worker, "Дані працівників суду");
            this.TAB_Worker.UseVisualStyleBackColor = true;
            this.TAB_Worker.Click += new System.EventHandler(this.TAB_Worker_Click);
            // 
            // TAB_About
            // 
            this.TAB_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TAB_About.Image = ((System.Drawing.Image)(resources.GetObject("TAB_About.Image")));
            this.TAB_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_About.Location = new System.Drawing.Point(31, 288);
            this.TAB_About.Name = "TAB_About";
            this.TAB_About.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TAB_About.Size = new System.Drawing.Size(280, 60);
            this.TAB_About.TabIndex = 5;
            this.TAB_About.Text = "Про програму";
            this.toolTip1.SetToolTip(this.TAB_About, "Довідкова інформація");
            this.TAB_About.UseVisualStyleBackColor = true;
            this.TAB_About.Click += new System.EventHandler(this.TAB_About_Click);
            // 
            // TAB_User
            // 
            this.TAB_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TAB_User.Image = ((System.Drawing.Image)(resources.GetObject("TAB_User.Image")));
            this.TAB_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_User.Location = new System.Drawing.Point(31, 223);
            this.TAB_User.Name = "TAB_User";
            this.TAB_User.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TAB_User.Size = new System.Drawing.Size(280, 60);
            this.TAB_User.TabIndex = 4;
            this.TAB_User.Text = "Користувачі";
            this.toolTip1.SetToolTip(this.TAB_User, "Керування користувачами програми");
            this.TAB_User.UseVisualStyleBackColor = true;
            this.TAB_User.Click += new System.EventHandler(this.TAB_User_Click);
            // 
            // TAB_Exit
            // 
            this.TAB_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TAB_Exit.Image = ((System.Drawing.Image)(resources.GetObject("TAB_Exit.Image")));
            this.TAB_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_Exit.Location = new System.Drawing.Point(31, 354);
            this.TAB_Exit.Name = "TAB_Exit";
            this.TAB_Exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TAB_Exit.Size = new System.Drawing.Size(280, 60);
            this.TAB_Exit.TabIndex = 6;
            this.TAB_Exit.Text = "Вихід";
            this.toolTip1.SetToolTip(this.TAB_Exit, "Вийти з програми");
            this.TAB_Exit.UseVisualStyleBackColor = true;
            this.TAB_Exit.Click += new System.EventHandler(this.TAB_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.TAB_Add);
            this.Controls.Add(this.TAB_User);
            this.Controls.Add(this.TAB_Exit);
            this.Controls.Add(this.TAB_About);
            this.Controls.Add(this.TAB_Worker);
            this.Controls.Add(this.TAB_Open);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 500);
            this.MinimumSize = new System.Drawing.Size(360, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КП \"Т А Б Е Л Ь +\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button TAB_Open;
        private System.Windows.Forms.Button TAB_Add;
        private System.Windows.Forms.Button TAB_Worker;
        private System.Windows.Forms.Button TAB_About;
        private System.Windows.Forms.Button TAB_User;
        private System.Windows.Forms.Button TAB_Exit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Test
{
    public partial class MainForm : Form
    {
        protected DateTime _nowtime;
        public MainForm()
        {
            InitializeComponent();

            _nowtime = DateTime.Now;
            toolStripStatusLabel1.Text = _nowtime.ToString();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _nowtime = DateTime.Now;
            toolStripStatusLabel1.Text = _nowtime.ToString();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UserAdd_Form _add_form = new UserAdd_Form())
            {
                _add_form.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TAB_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TAB_About_Click(object sender, EventArgs e)
        {
            using (AboutBox _myAbout = new AboutBox())
            {
                _myAbout.ShowDialog();
            }
        }

        private void TAB_User_Click(object sender, EventArgs e)
        {
            using (UserList_Form _userform = new UserList_Form())
            {
                this.Hide();
                _userform.ShowDialog(this);
            }
        }

        private void TAB_Worker_Click(object sender, EventArgs e)
        {
            using (WorkersList_Form _workerslist = new WorkersList_Form())
            {
                this.Hide();
                _workerslist.ShowDialog(this);
            }
        }


    }
}

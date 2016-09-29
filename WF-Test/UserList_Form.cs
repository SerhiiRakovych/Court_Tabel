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
    public partial class UserList_Form : Form
    {
        public UserList_Form()
        {
            InitializeComponent();

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_WF_Test_TableModelDataSet.AppUsers' table. You can move, or remove it, as needed.
            this.appUsersTableAdapter.Fill(this._WF_Test_TableModelDataSet.AppUsers);
        }

        private void UF_BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UF_BT_DelUser_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 0)
            {
                string _user = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                var result = MessageBox.Show("Ви дійсно бажаєте видалити обліковий запис користувача \"" + _user + "\" ?", "Підтвердження видалення користувача", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    using (TableModel _context = new TableModel())
                    {
                        var itemToRemove = _context.AppUsers.SingleOrDefault(x => x.Login == _user);
                        if (itemToRemove != null)
                        {
                            _context.AppUsers.Remove(itemToRemove);
                            _context.SaveChanges();
                            RefreshGrid();
                        }
                    }
                }
            }
        }

        private void UF_BT_AddUser_Click(object sender, EventArgs e)
        {
            using (UserAdd_Form _adduser = new UserAdd_Form())
            {
                this.Hide();
                _adduser.ShowDialog(this);
            }
        }

        private void UF_BT_Refresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

       
        private void RefreshGrid()
        {
            this.appUsersTableAdapter.Fill(this._WF_Test_TableModelDataSet.AppUsers);
        }

        private void UF_BT_BlockUser_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 0)
            {
                string _user = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                var result = MessageBox.Show("Ви дійсно бажаєте змінити статус користувача \"" + _user + "\" ?", "Підтвердження зміни статусу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    using (TableModel _context = new TableModel())
                    {
                        var itemToBlock = _context.AppUsers.SingleOrDefault(x => x.Login == _user);
                        if (itemToBlock != null)
                        {
                            if (!itemToBlock.IsActive) itemToBlock.IsActive = true;
                            else itemToBlock.IsActive = false;
                            _context.SaveChanges();
                            RefreshGrid();
                        }
                    }
                }
            }
        }

        private void UF_BT_EditUser_Click(object sender, EventArgs e)
        {
            using (UserEdit_Form _usereditform = new UserEdit_Form())
            {
                if (this.dataGridView1.RowCount > 0)
                {
                    string _user = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    _usereditform.FillFields(_user);
                    this.Hide();
                    _usereditform.ShowDialog(this);
                }
            }
        }

        private void UserList_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
                this.Owner.Show();
                this.Dispose();
        }
    }
}

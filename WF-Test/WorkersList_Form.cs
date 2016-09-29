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
    public partial class WorkersList_Form : Form
    {
        public WorkersList_Form()
        {
            InitializeComponent();
        }

        private void WorkersList_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkersList_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_WF_Test_TableModelDataSet1.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this._WF_Test_TableModelDataSet1.Workers);
        }

        private void WF_Refresh_BT_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void WF_AddUser_BT_Click(object sender, EventArgs e)
        {
            using (WorkerAdd _workeraddform = new WorkerAdd())
            {
                this.Hide();
                _workeraddform.ShowDialog(this);
            }
        }


        private void WF_Edit_BT_Click(object sender, EventArgs e)
        {
            using (WorkerEdit _workereditform = new WorkerEdit())
            {

                if (this.dataGridView1.RowCount > 0)
                {
                    int _workerId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    _workereditform.FillFields(_workerId);
                    this.Hide();
                    _workereditform.ShowDialog(this);
                }
            }
        }

        private void WF_Archive_BT_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 0)
            {
                int _user = Convert.ToInt16(this.dataGridView1.CurrentRow.Cells[0].Value);
                using (TableModel _context = new TableModel())
                {
                    var itemToBlock = _context.Workers.SingleOrDefault(x => x.Id == _user);
                    if (itemToBlock != null)
                    {
                        string _questMess = "Ви дійсно бажаєте звільнити працівника \"" + itemToBlock.FirstName + "\" ?";
                        _questMess += "\nПісля виконання процедури даний працівник не буде включатися до нових табелів.";
                        _questMess += "\nРаніше створені табелі залишаться без змін.";
                        var result = MessageBox.Show(_questMess, "Підтвердження операції", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            int _currentrow = this.dataGridView1.CurrentRow.Index;
                            itemToBlock.IsArchive = true;
                            _context.SaveChanges();
                            RefreshGrid();
                            this.dataGridView1.CurrentCell = dataGridView1.Rows[_currentrow].Cells[0];
                            this.WF_Archive_BT.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Увага!\nВказаний працівник відсутній у базі даних!", "Помилка виконання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void RefreshGrid()
        {
            this.workersTableAdapter.Fill(this._WF_Test_TableModelDataSet1.Workers);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null) 
            {
                var _currentstatus = Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells[6].Value);
                if(_currentstatus){WF_Archive_BT.Enabled = false;}
                else
                {
                    if (WF_Archive_BT.Enabled == false) WF_Archive_BT.Enabled = true;
                }
            }
        }

    }
}

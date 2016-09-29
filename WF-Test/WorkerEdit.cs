using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Test
{
    public partial class WorkerEdit : Form
    {
        public WorkerEdit()
        {
            InitializeComponent();
        }

        private void WorkerEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
        public int WorkerID;
        private void WF_Edit_BT_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.FirstName = this.WF_FN_TB.Text;
            worker.LastName = this.WF_LN_TB.Text;
            worker.MiddleName = this.WF_MN_TB.Text;
            worker.Post = this.WF_Post_TB.Text;
            if (this.WF_Order_TB.Text.Length == 0) worker.OrderNum = -9999;
            else worker.OrderNum = Convert.ToInt32(this.WF_Order_TB.Text);
            worker.IsArchive = this.WF_Archive_ChBox.Checked;

            var _valresults = new List<ValidationResult>();
            var _valcontext = new ValidationContext(worker);
            string _err = string.Empty;

            if (Validator.TryValidateObject(worker, _valcontext, _valresults, true))
            {
                using (TableModel _context = new TableModel())
                {
                    var _editworker = _context.Workers.FirstOrDefault(x => x.Id == this.WorkerID);
                    if (_editworker != null)
                    {
                        _editworker.FirstName = worker.FirstName;
                        _editworker.LastName = worker.LastName;
                        _editworker.MiddleName = worker.MiddleName;
                        _editworker.OrderNum = worker.OrderNum;
                        _editworker.IsArchive = worker.IsArchive;
                        _context.SaveChanges();
                    }

                    this.Close();
                }
            }
            else
            {
                foreach (var error in _valresults)
                {
                    _err += error.ErrorMessage + "\n";
                }
                MessageBox.Show(_err, "Помилка додавання працівника", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WF_Order_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        internal void FillFields(int WorkerId)
        {
            int _workerId = Convert.ToInt32(WorkerId);
            this.WorkerID = _workerId;
            using (TableModel _context = new TableModel())
            {
                var _worker = _context.Workers.SingleOrDefault(x => x.Id == _workerId);
                if (_worker != null)
                {
                    this.WF_FN_TB.Text = _worker.FirstName;
                    this.WF_LN_TB.Text = _worker.LastName;
                    this.WF_MN_TB.Text = _worker.MiddleName;
                    this.WF_Post_TB.Text = _worker.Post;
                    this.WF_Order_TB.Text = _worker.OrderNum.ToString();
                    this.WF_Archive_ChBox.Checked = _worker.IsArchive;
                }
            }
        }

    }
}

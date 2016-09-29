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
    public partial class WorkerAdd : Form
    {
        public WorkerAdd()
        {
            InitializeComponent();
        }

        private void WorkerAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void WF_Add_BT_Click(object sender, EventArgs e)
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
                    _context.Workers.Add(worker);
                    _context.SaveChanges();

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

        private void WorkerAdd_Shown(object sender, EventArgs e)
        {
            using (TableModel _context = new TableModel())
            {
                if (_context.Workers.Count() > 0)
                {
                    int MaxOrderVal = (from workers in _context.Workers
                                       select workers.OrderNum).Max()+1;
                    
                    this.WF_Order_TB.Text = MaxOrderVal.ToString();
                }
                else this.WF_Order_TB.Text = "1";

            }
        }

    }
}

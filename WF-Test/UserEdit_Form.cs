using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Test
{
    public partial class UserEdit_Form : Form
    {
        public UserEdit_Form()
        {
            InitializeComponent();
        }

        public string UserLogin;
        private void ADF_BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADF_BT_Accept_Click(object sender, EventArgs e)
        {
            if (this.PIB_TB.TextLength == 0)
            {
                MessageBox.Show("Поле \"ПІБ користувача\" не може бути порожнім!", "Помилка редагування облікового запису", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                this.PIB_TB.Focus();
                return;
            }

            if (this.Password_TB.Text == this.ConfirmPassword_TB.Text)
            {
                using (TableModel _context = new TableModel())
                {

                    var _edituser = _context.AppUsers
                    .Where(l => l.Login == this.UserLogin)
                    .FirstOrDefault();

                    if (_edituser != null)
                    {
                        _edituser.Name = this.PIB_TB.Text;

                        if (this.Password_TB.Text != "****************")
                        {
                            string _salt = GetSalt();
                            _edituser.Password = GetPassHash(this.Password_TB.Text, _salt); ;
                            _edituser.Salt = _salt;
                        }

                        if (this.IsBlock_CHB.Checked) _edituser.IsActive = true;
                        else _edituser.IsActive = false;

                        _context.SaveChanges();

                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Користувача з логіном \"" + this.UserLogin + "\" не знайдено!", "Помилка редагування облікового запису", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                this.Password_TB.Clear();
                this.ConfirmPassword_TB.Clear();
                this.Password_TB.Focus();
                MessageBox.Show("Введені паролі не співпадають!", "Помилка створення пароля", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private string GetPassHash(string password, string salt)
        {
            using (MD5 _md5 = MD5.Create())
            {
                string _password = this.Password_TB.Text + salt;
                byte[] checkSum = _md5.ComputeHash(Encoding.UTF8.GetBytes(_password));
                string _passhash = BitConverter.ToString(checkSum).Replace("-", string.Empty);
                return _passhash;
            }
        }

        private string GetSalt()
        {
            string _saltString = string.Empty;
            Random rnd = new Random();
            Char[] pwdChars = new Char[36] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < 10; i++)
                _saltString += pwdChars[rnd.Next(0, 35)];
            return _saltString;
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            string messtring = "Ви можете змінити ПІБ користувача та його пароль, \n";
            messtring += "а також виконати блокування/розблокування облікового запису.\n";
            messtring += "Для зміни пароля введіть новий пароль та його підтвердження у відповідні поля форми.\n";
            messtring += "Максимальна довжина пароля - 16 символів!";
            MessageBox.Show(messtring, "Довідка", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        internal void FillFields(string UserLogin)
        {
            using (TableModel _context = new TableModel())
            {
                var _user = _context.AppUsers.SingleOrDefault(x => x.Login == UserLogin);
                if (_user != null)
                {
                    this.UserLogin = _user.Login;
                    this.PIB_TB.Text = _user.Name;
                    this.LoginLabel.Text = "\"" + _user.Login + "\"";
                    this.IsBlock_CHB.Checked = _user.IsActive;
                    this.Password_TB.Text = "****************";
                    this.ConfirmPassword_TB.Text = "****************";
                }
            }
        }

        private void UserEdit_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
                this.Owner.Show();
                this.Dispose();
        }

    }
}

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
    public partial class UserAdd_Form : Form
    {
        public UserAdd_Form()
        {
            InitializeComponent();
        }

        private void ADF_BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADF_BT_Accept_Click(object sender, EventArgs e)
        {
            if (this.PIB_TB.TextLength == 0)
            {
                MessageBox.Show("Поле \"ПІБ користувача\" не може бути порожнім!", "Помилка створення облікового запису", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                this.PIB_TB.Focus();
                return;
            }

            if (this.Login_TB.TextLength == 0)
            {
                MessageBox.Show("Поле \"Логін\" не може бути порожнім!", "Помилка створення облікового запису", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                this.Login_TB.Focus();
                return;
            }

            if (this.Password_TB.Text == this.ConfirmPassword_TB.Text)
            {
                using (TableModel _context = new TableModel())
                {

                    var _existinguser = _context.AppUsers
                    .Where(l => l.Login == this.Login_TB.Text)
                    .FirstOrDefault();

                    if (_existinguser == null)
                    {


                        AppUser _user = new AppUser();
                        _user.Name = this.PIB_TB.Text;
                        _user.Login = this.Login_TB.Text;
                        string _salt = GetSalt();
                        _user.Password = GetPassHash(this.Password_TB.Text, _salt);
                        _user.Salt = _salt;
                        if (this.IsBlock_CHB.Checked) _user.IsActive = true;
                        else _user.IsActive = false;

                        _context.AppUsers.Add(_user);
                        _context.SaveChanges();

                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Користувач з логіном \"" + this.Login_TB.Text + "\" вже існує!", "Помилка додавання облікового запису", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                        this.Login_TB.Clear();
                        this.Login_TB.Focus();
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
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Максимальна довжина пароля - 16 символів!", "Інформація", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        private void UserAdd_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

    }
}

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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (this.Login_TB.TextLength == 0 || this.Password_TB.TextLength == 0)
            {
                MessageBox.Show("Поля \"Лоін\" та \"Пароль\" повинні бути заповнені.", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (TableModel _context = new TableModel())
            {
                var _user = _context.AppUsers.SingleOrDefault(x => x.Login == this.Login_TB.Text);
                if (_user != null)
                {
                    string _baseSalt = _user.Salt;
                    string _baseHash = _user.Password;
                    string _currentHash = GetPassHash(this.Password_TB.Text, _baseSalt);
                    if (_currentHash == _baseHash)
                    {
                        MainForm _mainForm = new MainForm();
                        this.Hide();
                        _mainForm.Show();
                    }
                    else
                    {
                        LoginFailMessage();
                    }
                }
                else
                {
                    LoginFailMessage();
                }
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

        private void LoginFailMessage()
        {
            this.Login_TB.Clear();
            this.Password_TB.Clear();
            MessageBox.Show("Неможливо виконати вхід до програми.\n Введено невірний логін або пароль.", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

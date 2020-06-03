using LabPasswordApp.View.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPasswordApp
{
    public partial class LoginForm : Form, ILoginView
    {

        public event Action Login;

        public LoginForm()
        {
            InitializeComponent();

            buttonLogIn.Click += (sender, args) => Invoke(Login);
        }

        public new void Show()
        {
            Application.Run(this);
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public string Username
        {
            get { return this.textBoxLogin.Text; }
            set { this.textBoxLogin.Text = value; }
        }

        public string Password
        {
            get { return this.textBoxPassword.Text; }
            set { this.textBoxPassword.Text = value; }
        }

        public void ShowError(string messageError)
        {
            MessageBox.Show(
                messageError, 
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
           );
        }
    }
}

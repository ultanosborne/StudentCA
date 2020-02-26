using AdvProgrammingCA.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvProgrammingCA.PresentationLayer
{
    public partial class LoginForm : Form
    {
        LoginCheck lc;

        public LoginForm()
        {
            InitializeComponent();
            lblFail.Visible = false;
            lc = new LoginCheck();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(lc.check(tbUsername.Text, tbPassword.Text))
            {
                DBForm dbf = new DBForm(this);
                this.Hide();
                dbf.Show();
                allClear(); //to clear login details when unhiding this login form
            }
            else
            {
                lblFail.Visible = true;
                allClear();
            }
        }

        private void allClear()
        {
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

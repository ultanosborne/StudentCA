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
    public partial class DBForm : Form
    {
        LoginForm lf;

        public DBForm(LoginForm l)
        {
            lf = l;
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            lf.Show();
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabController(int i)
        {
            switch(i)
            {
                case 0:
                    tabControl1.SelectedIndex = 0;
                    deselect();
                    lblView.ForeColor = Color.DarkBlue;
                    break;
                case 1:
                    tabControl1.SelectedIndex = 1;
                    deselect();
                    lblNew.ForeColor = Color.DarkBlue;
                    break;
                case 2:
                    tabControl1.SelectedIndex = 2;
                    deselect();
                    lblEdit.ForeColor = Color.DarkBlue;
                    break;
                case 3:
                    tabControl1.SelectedIndex = 3;
                    deselect();
                    lblDelete.ForeColor = Color.DarkBlue;
                    break;
                case 4:
                    tabControl1.SelectedIndex = 4;
                    deselect();
                    lblHistory.ForeColor = Color.DarkBlue;
                    break;

            }
        }

        private void deselect()
        {
            lblView.ForeColor = Color.LightSteelBlue;
            lblNew.ForeColor = Color.LightSteelBlue;
            lblEdit.ForeColor = Color.LightSteelBlue;
            lblDelete.ForeColor = Color.LightSteelBlue;
            lblHistory.ForeColor = Color.LightSteelBlue;
        }

        private void lblView_Click(object sender, EventArgs e)
        {
            tabController(0);
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            tabController(1);
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            tabController(2);
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            tabController(3);
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            tabController(4);
        }
    }
}

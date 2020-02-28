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
    public partial class DBForm : Form
    {
        LoginForm lf;
        StudentList sl;

        public DBForm(LoginForm l)
        {
            lf = l;
            InitializeComponent();
            sl = new StudentList();
            dgStudents.DataSource = sl.pullStudentList();
            dgStudents.Refresh();
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
            dgStudents.DataSource = sl.pullStudentList();
            dgStudents.Refresh();
            tabController(0);
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            tabController(1);
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            gbEditStudent.Visible = false;
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

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            short level = 2;

            if (rbNewPostGrad.Checked)
            {
                level = 1;
            }
            else if (rbNewUnderGrad.Checked)
            {
                level = 0;
            }

            AddStudent ast = new AddStudent(tbNewStuN.Text, tbNewFName.Text, tbNewLName.Text, tbNewEmail.Text, tbNewPhone.Text,
                    tbNewAd1.Text, tbNewAd2.Text, tbNewCity.Text, tbNewCountry.Text, level, cbNewCourses.Text);
            ast.addToDB();
            MessageBox.Show($"Added Student: {tbNewFName.Text} {tbNewLName.Text}");

        }

        private void btEditFindStu_Click(object sender, EventArgs e)
        {
            FindStudent fs = new FindStudent(int.Parse(tbEditStuID.Text));
            gbEditStudent.Visible = true;
            tbEditStuID2.Text = fs.stu.StudentID.ToString();
            tbEditFName.Text = fs.stu.FirstName;
            tbEditLName.Text = fs.stu.LastName;
            tbEditPhone.Text = fs.stu.Phone;
            tbEditEmail.Text = fs.stu.Email;
            tbEditA1.Text = fs.stu.AddressLine1;
            tbEditA2.Text = fs.stu.AddressLine2;
            tbEditCity.Text = fs.stu.City;
            tbEditCountry.Text = fs.stu.Country;
            
            if (!fs.stu.Level)
            {
                rbEditUnderGrad.Checked = true;
                rbEditPostGrad.Checked = false;
            }
            else
            {
                rbEditUnderGrad.Checked = false;
                rbEditPostGrad.Checked = true;
            }

            cbEditCourse.Text = fs.stu.Course;
        }

        private void btDelFindStu_Click(object sender, EventArgs e)
        {
            FindStudent fs = new FindStudent(int.Parse(tbDelStuID.Text));
            gbDelStudent.Visible = true;
            tbDelStuID2.Text = fs.stu.StudentID.ToString();
            tbDelFName.Text = fs.stu.FirstName;
            tbDelLName.Text = fs.stu.LastName;
            tbDelPhone.Text = fs.stu.Phone;
            tbDelEmail.Text = fs.stu.Email;
            tbDelA1.Text = fs.stu.AddressLine1;
            tbDelA2.Text = fs.stu.AddressLine2;
            tbDelCity.Text = fs.stu.City;
            tbDelCountry.Text = fs.stu.Country;

            if (!fs.stu.Level)
            {
                rbDelUnderGrad.Checked = true;
                rbDelPostGrad.Checked = false;
            }
            else
            {
                rbDelUnderGrad.Checked = false;
                rbDelPostGrad.Checked = true;
            }

            cbDelCourse.Text = fs.stu.Course;
        }

        private void btEditUpdate_Click(object sender, EventArgs e)
        {

            short level = 2;

            if (rbNewPostGrad.Checked)
            {
                level = 1;
            }
            else if (rbNewUnderGrad.Checked)
            {
                level = 0;
            }

            EditStudent es = new EditStudent(int.Parse(tbEditStuID.Text), tbEditEmail.Text, 
                tbEditPhone.Text, tbEditA1.Text, tbEditA2.Text, tbEditCity.Text,
                tbEditCountry.Text, level);
        }

        private void btDelDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent(int.Parse(tbDelStuID2.Text));
        }
    }
}

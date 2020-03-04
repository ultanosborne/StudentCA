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
        String username;

        public DBForm(LoginForm l, string u)
        {
            lf = l;
            username = u;
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
            gbDelStudent.Visible = false;
            tabController(3);
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            HistoryList hl = new HistoryList();
            dgHistory.DataSource = hl.pullHistory();
            dgHistory.Refresh();
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

            Verification v = new Verification(tbNewStuN.Text, tbNewFName.Text, tbNewLName.Text,
                tbNewEmail.Text, tbNewPhone.Text);

            if(v.Validate())
            {
                AddStudent ast = new AddStudent(tbNewStuN.Text, tbNewFName.Text, tbNewLName.Text, tbNewEmail.Text, tbNewPhone.Text,
                    tbNewAd1.Text, tbNewAd2.Text, tbNewCity.Text, cbNewCounty.Text, level, cbNewCourses.Text, username);
                ast.addToDB();
                MessageBox.Show($"Added Student: {tbNewFName.Text} {tbNewLName.Text}");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

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
            cbEditCounty.Text = fs.stu.Country;
            
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
            cbDelCounty.Text = fs.stu.Country;

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

            if (rbEditPostGrad.Checked)
            {
                level = 1;
            }
            else if (rbEditUnderGrad.Checked)
            {
                level = 0;
            }

            EditStudent es = new EditStudent(tbEditStuID.Text, tbEditFName.Text, tbEditLName.Text, tbEditEmail.Text, 
                tbEditPhone.Text, tbEditA1.Text, tbEditA2.Text, tbEditCity.Text,
                cbEditCounty.Text, level, cbEditCourse.Text, username);

            MessageBox.Show($"Updated Student: {tbEditFName.Text} {tbEditLName.Text}");
        }

        private void btDelDelete_Click(object sender, EventArgs e)
        {
            short level = 2;

            if (rbDelPostGrad.Checked)
            {
                level = 1;
            }
            else if (rbDelUnderGrad.Checked)
            {
                level = 0;
            }

            DeleteStudent ds = new DeleteStudent(tbDelStuID.Text, tbDelFName.Text, tbDelLName.Text, tbDelEmail.Text,
                tbDelPhone.Text, tbDelA1.Text, tbDelA2.Text, tbDelCity.Text,
                cbDelCounty.Text, level, cbDelCourse.Text, username);


            MessageBox.Show($"Deleted Student: {tbDelFName.Text} {tbDelLName.Text}");
        }

        private void btEditXML_Click(object sender, EventArgs e)
        {
            short level = 2;

            if (rbEditPostGrad.Checked)
            {
                level = 1;
            }
            else if (rbEditUnderGrad.Checked)
            {
                level = 0;
            }
            XMLExport xe = new XMLExport(tbEditStuID.Text, tbEditFName.Text, tbEditLName.Text, tbEditEmail.Text,
                tbEditPhone.Text, tbEditA1.Text, tbEditA2.Text, tbEditCity.Text,
                cbEditCounty.Text, level, cbEditCourse.Text);

            MessageBox.Show("Data Exported");
        }
    }
}

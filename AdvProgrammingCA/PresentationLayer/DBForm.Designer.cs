using System.Drawing;
using System.Windows.Forms;

namespace AdvProgrammingCA.PresentationLayer
{
    partial class DBForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblView = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpView = new System.Windows.Forms.TabPage();
            this.dgStudents = new System.Windows.Forms.DataGridView();
            this.tbpNew = new System.Windows.Forms.TabPage();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.cbNewCourses = new System.Windows.Forms.ComboBox();
            this.rbNewPostGrad = new System.Windows.Forms.RadioButton();
            this.rbNewUnderGrad = new System.Windows.Forms.RadioButton();
            this.tbNewCity = new System.Windows.Forms.TextBox();
            this.tbNewAd2 = new System.Windows.Forms.TextBox();
            this.tbNewAd1 = new System.Windows.Forms.TextBox();
            this.tbNewPhone = new System.Windows.Forms.TextBox();
            this.tbNewEmail = new System.Windows.Forms.TextBox();
            this.tbNewLName = new System.Windows.Forms.TextBox();
            this.tbNewFName = new System.Windows.Forms.TextBox();
            this.tbNewStuN = new System.Windows.Forms.TextBox();
            this.lblNewCourse = new System.Windows.Forms.Label();
            this.lblNewDType = new System.Windows.Forms.Label();
            this.lblNewLName = new System.Windows.Forms.Label();
            this.lblNewCounty = new System.Windows.Forms.Label();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.lblNewAd2 = new System.Windows.Forms.Label();
            this.lblNewAd1 = new System.Windows.Forms.Label();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.lblNewPhone = new System.Windows.Forms.Label();
            this.lblNewFName = new System.Windows.Forms.Label();
            this.lblNewStuN = new System.Windows.Forms.Label();
            this.tbpEdit = new System.Windows.Forms.TabPage();
            this.gbEditStudent = new System.Windows.Forms.GroupBox();
            this.btEditXML = new System.Windows.Forms.Button();
            this.cbEditCourse = new System.Windows.Forms.ComboBox();
            this.tbEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.tbEditPhone = new System.Windows.Forms.TextBox();
            this.lblEditPhone = new System.Windows.Forms.Label();
            this.btEditUpdate = new System.Windows.Forms.Button();
            this.rbEditPostGrad = new System.Windows.Forms.RadioButton();
            this.rbEditUnderGrad = new System.Windows.Forms.RadioButton();
            this.tbEditA1 = new System.Windows.Forms.TextBox();
            this.tbEditA2 = new System.Windows.Forms.TextBox();
            this.tbEditCity = new System.Windows.Forms.TextBox();
            this.tbEditLName = new System.Windows.Forms.TextBox();
            this.tbEditFName = new System.Windows.Forms.TextBox();
            this.tbEditStuID2 = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblEditDLevel = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblEditA2 = new System.Windows.Forms.Label();
            this.lblEditFName = new System.Windows.Forms.Label();
            this.lblEditA1 = new System.Windows.Forms.Label();
            this.lblEditStuID2 = new System.Windows.Forms.Label();
            this.btEditFindStu = new System.Windows.Forms.Button();
            this.tbEditStuID = new System.Windows.Forms.TextBox();
            this.lblEditStuID = new System.Windows.Forms.Label();
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.gbDelStudent = new System.Windows.Forms.GroupBox();
            this.cbDelCourse = new System.Windows.Forms.ComboBox();
            this.tbDelEmail = new System.Windows.Forms.TextBox();
            this.lblDelEmail = new System.Windows.Forms.Label();
            this.tbDelPhone = new System.Windows.Forms.TextBox();
            this.lblDelPhone = new System.Windows.Forms.Label();
            this.btDelDelete = new System.Windows.Forms.Button();
            this.rbDelPostGrad = new System.Windows.Forms.RadioButton();
            this.rbDelUnderGrad = new System.Windows.Forms.RadioButton();
            this.tbDelA1 = new System.Windows.Forms.TextBox();
            this.tbDelA2 = new System.Windows.Forms.TextBox();
            this.tbDelCity = new System.Windows.Forms.TextBox();
            this.tbDelLName = new System.Windows.Forms.TextBox();
            this.tbDelFName = new System.Windows.Forms.TextBox();
            this.tbDelStuID2 = new System.Windows.Forms.TextBox();
            this.lblDelLName = new System.Windows.Forms.Label();
            this.lblDelCounty = new System.Windows.Forms.Label();
            this.lblDelCity = new System.Windows.Forms.Label();
            this.lblDelDLevel = new System.Windows.Forms.Label();
            this.lblDelCourse = new System.Windows.Forms.Label();
            this.lblDelA2 = new System.Windows.Forms.Label();
            this.lblDelFName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblDelStuID2 = new System.Windows.Forms.Label();
            this.btDelFindStu = new System.Windows.Forms.Button();
            this.tbDelStuID = new System.Windows.Forms.TextBox();
            this.lblDelStuID = new System.Windows.Forms.Label();
            this.tbpHistory = new System.Windows.Forms.TabPage();
            this.dgHistory = new System.Windows.Forms.DataGridView();
            this.cbNewCounty = new System.Windows.Forms.ComboBox();
            this.cbEditCounty = new System.Windows.Forms.ComboBox();
            this.cbDelCounty = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbpView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).BeginInit();
            this.tbpNew.SuspendLayout();
            this.tbpEdit.SuspendLayout();
            this.gbEditStudent.SuspendLayout();
            this.tbpDelete.SuspendLayout();
            this.gbDelStudent.SuspendLayout();
            this.tbpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblView.Location = new System.Drawing.Point(36, 31);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(130, 20);
            this.lblView.TabIndex = 14;
            this.lblView.Text = "View Database";
            this.lblView.Click += new System.EventHandler(this.lblView_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblHistory.Location = new System.Drawing.Point(573, 31);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(191, 20);
            this.lblHistory.TabIndex = 13;
            this.lblHistory.Text = "View Database History";
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblDelete.Location = new System.Drawing.Point(434, 31);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(131, 20);
            this.lblDelete.TabIndex = 12;
            this.lblDelete.Text = "Delete Student";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblEdit.Location = new System.Drawing.Point(309, 31);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(110, 20);
            this.lblEdit.TabIndex = 11;
            this.lblEdit.Text = "Edit Student";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblNew.Location = new System.Drawing.Point(184, 31);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(112, 20);
            this.lblNew.TabIndex = 10;
            this.lblNew.Text = "New Student";
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(430, 385);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(135, 35);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(241, 385);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(135, 35);
            this.btLogout.TabIndex = 8;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbpView);
            this.tabControl1.Controls.Add(this.tbpNew);
            this.tabControl1.Controls.Add(this.tbpEdit);
            this.tabControl1.Controls.Add(this.tbpDelete);
            this.tabControl1.Controls.Add(this.tbpHistory);
            this.tabControl1.ItemSize = new Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(40, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 324);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 15;
            // 
            // tbpView
            // 
            this.tbpView.BackColor = System.Drawing.SystemColors.Control;
            this.tbpView.Controls.Add(this.dgStudents);
            this.tbpView.Location = new System.Drawing.Point(4, 25);
            this.tbpView.Name = "tbpView";
            this.tbpView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpView.Size = new System.Drawing.Size(716, 295);
            this.tbpView.TabIndex = 0;
            // 
            // dgStudents
            // 
            this.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudents.Location = new System.Drawing.Point(-1, 7);
            this.dgStudents.Name = "dgStudents";
            this.dgStudents.Size = new System.Drawing.Size(714, 286);
            this.dgStudents.TabIndex = 0;
            // 
            // tbpNew
            // 
            this.tbpNew.BackColor = System.Drawing.SystemColors.Control;
            this.tbpNew.Controls.Add(this.cbNewCounty);
            this.tbpNew.Controls.Add(this.btAddStudent);
            this.tbpNew.Controls.Add(this.cbNewCourses);
            this.tbpNew.Controls.Add(this.rbNewPostGrad);
            this.tbpNew.Controls.Add(this.rbNewUnderGrad);
            this.tbpNew.Controls.Add(this.tbNewCity);
            this.tbpNew.Controls.Add(this.tbNewAd2);
            this.tbpNew.Controls.Add(this.tbNewAd1);
            this.tbpNew.Controls.Add(this.tbNewPhone);
            this.tbpNew.Controls.Add(this.tbNewEmail);
            this.tbpNew.Controls.Add(this.tbNewLName);
            this.tbpNew.Controls.Add(this.tbNewFName);
            this.tbpNew.Controls.Add(this.tbNewStuN);
            this.tbpNew.Controls.Add(this.lblNewCourse);
            this.tbpNew.Controls.Add(this.lblNewDType);
            this.tbpNew.Controls.Add(this.lblNewLName);
            this.tbpNew.Controls.Add(this.lblNewCounty);
            this.tbpNew.Controls.Add(this.lblNewCity);
            this.tbpNew.Controls.Add(this.lblNewAd2);
            this.tbpNew.Controls.Add(this.lblNewAd1);
            this.tbpNew.Controls.Add(this.lblNewEmail);
            this.tbpNew.Controls.Add(this.lblNewPhone);
            this.tbpNew.Controls.Add(this.lblNewFName);
            this.tbpNew.Controls.Add(this.lblNewStuN);
            this.tbpNew.Location = new System.Drawing.Point(4, 25);
            this.tbpNew.Name = "tbpNew";
            this.tbpNew.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNew.Size = new System.Drawing.Size(716, 295);
            this.tbpNew.TabIndex = 1;
            // 
            // btAddStudent
            // 
            this.btAddStudent.Location = new System.Drawing.Point(582, 183);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(84, 70);
            this.btAddStudent.TabIndex = 23;
            this.btAddStudent.Text = "Add";
            this.btAddStudent.UseVisualStyleBackColor = true;
            this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
            // 
            // cbNewCourses
            // 
            this.cbNewCourses.FormattingEnabled = true;
            this.cbNewCourses.Items.AddRange(new object[] {
            "Software Development",
            "Arts",
            "Science",
            "Business",
            "Mathematics",
            "English"});
            this.cbNewCourses.Location = new System.Drawing.Point(357, 246);
            this.cbNewCourses.Name = "cbNewCourses";
            this.cbNewCourses.Size = new System.Drawing.Size(121, 21);
            this.cbNewCourses.TabIndex = 22;
            // 
            // rbNewPostGrad
            // 
            this.rbNewPostGrad.AutoSize = true;
            this.rbNewPostGrad.Location = new System.Drawing.Point(384, 207);
            this.rbNewPostGrad.Name = "rbNewPostGrad";
            this.rbNewPostGrad.Size = new System.Drawing.Size(69, 17);
            this.rbNewPostGrad.TabIndex = 21;
            this.rbNewPostGrad.TabStop = true;
            this.rbNewPostGrad.Text = "PostGrad";
            this.rbNewPostGrad.UseVisualStyleBackColor = true;
            // 
            // rbNewUnderGrad
            // 
            this.rbNewUnderGrad.AutoSize = true;
            this.rbNewUnderGrad.Location = new System.Drawing.Point(384, 175);
            this.rbNewUnderGrad.Name = "rbNewUnderGrad";
            this.rbNewUnderGrad.Size = new System.Drawing.Size(77, 17);
            this.rbNewUnderGrad.TabIndex = 20;
            this.rbNewUnderGrad.TabStop = true;
            this.rbNewUnderGrad.Text = "UnderGrad";
            this.rbNewUnderGrad.UseVisualStyleBackColor = true;
            // 
            // tbNewCity
            // 
            this.tbNewCity.Location = new System.Drawing.Point(133, 233);
            this.tbNewCity.Name = "tbNewCity";
            this.tbNewCity.Size = new System.Drawing.Size(100, 20);
            this.tbNewCity.TabIndex = 18;
            // 
            // tbNewAd2
            // 
            this.tbNewAd2.Location = new System.Drawing.Point(133, 204);
            this.tbNewAd2.Name = "tbNewAd2";
            this.tbNewAd2.Size = new System.Drawing.Size(100, 20);
            this.tbNewAd2.TabIndex = 17;
            // 
            // tbNewAd1
            // 
            this.tbNewAd1.Location = new System.Drawing.Point(133, 176);
            this.tbNewAd1.Name = "tbNewAd1";
            this.tbNewAd1.Size = new System.Drawing.Size(100, 20);
            this.tbNewAd1.TabIndex = 16;
            // 
            // tbNewPhone
            // 
            this.tbNewPhone.Location = new System.Drawing.Point(369, 116);
            this.tbNewPhone.Name = "tbNewPhone";
            this.tbNewPhone.Size = new System.Drawing.Size(100, 20);
            this.tbNewPhone.TabIndex = 15;
            // 
            // tbNewEmail
            // 
            this.tbNewEmail.Location = new System.Drawing.Point(133, 116);
            this.tbNewEmail.Name = "tbNewEmail";
            this.tbNewEmail.Size = new System.Drawing.Size(100, 20);
            this.tbNewEmail.TabIndex = 14;
            // 
            // tbNewLName
            // 
            this.tbNewLName.Location = new System.Drawing.Point(369, 70);
            this.tbNewLName.Name = "tbNewLName";
            this.tbNewLName.Size = new System.Drawing.Size(100, 20);
            this.tbNewLName.TabIndex = 13;
            // 
            // tbNewFName
            // 
            this.tbNewFName.Location = new System.Drawing.Point(133, 70);
            this.tbNewFName.Name = "tbNewFName";
            this.tbNewFName.Size = new System.Drawing.Size(100, 20);
            this.tbNewFName.TabIndex = 12;
            // 
            // tbNewStuN
            // 
            this.tbNewStuN.Location = new System.Drawing.Point(133, 31);
            this.tbNewStuN.Name = "tbNewStuN";
            this.tbNewStuN.Size = new System.Drawing.Size(100, 20);
            this.tbNewStuN.TabIndex = 11;
            // 
            // lblNewCourse
            // 
            this.lblNewCourse.AutoSize = true;
            this.lblNewCourse.Location = new System.Drawing.Point(275, 249);
            this.lblNewCourse.Name = "lblNewCourse";
            this.lblNewCourse.Size = new System.Drawing.Size(40, 13);
            this.lblNewCourse.TabIndex = 10;
            this.lblNewCourse.Text = "Course";
            // 
            // lblNewDType
            // 
            this.lblNewDType.AutoSize = true;
            this.lblNewDType.Location = new System.Drawing.Point(275, 179);
            this.lblNewDType.Name = "lblNewDType";
            this.lblNewDType.Size = new System.Drawing.Size(69, 13);
            this.lblNewDType.TabIndex = 9;
            this.lblNewDType.Text = "Degree Type";
            // 
            // lblNewLName
            // 
            this.lblNewLName.AutoSize = true;
            this.lblNewLName.Location = new System.Drawing.Point(297, 73);
            this.lblNewLName.Name = "lblNewLName";
            this.lblNewLName.Size = new System.Drawing.Size(58, 13);
            this.lblNewLName.TabIndex = 8;
            this.lblNewLName.Text = "Last Name";
            // 
            // lblNewCounty
            // 
            this.lblNewCounty.AutoSize = true;
            this.lblNewCounty.Location = new System.Drawing.Point(33, 265);
            this.lblNewCounty.Name = "lblNewCounty";
            this.lblNewCounty.Size = new System.Drawing.Size(40, 13);
            this.lblNewCounty.TabIndex = 7;
            this.lblNewCounty.Text = "County";
            // 
            // lblNewCity
            // 
            this.lblNewCity.AutoSize = true;
            this.lblNewCity.Location = new System.Drawing.Point(33, 236);
            this.lblNewCity.Name = "lblNewCity";
            this.lblNewCity.Size = new System.Drawing.Size(24, 13);
            this.lblNewCity.TabIndex = 6;
            this.lblNewCity.Text = "City";
            // 
            // lblNewAd2
            // 
            this.lblNewAd2.AutoSize = true;
            this.lblNewAd2.Location = new System.Drawing.Point(33, 207);
            this.lblNewAd2.Name = "lblNewAd2";
            this.lblNewAd2.Size = new System.Drawing.Size(77, 13);
            this.lblNewAd2.TabIndex = 5;
            this.lblNewAd2.Text = "Address Line 2";
            // 
            // lblNewAd1
            // 
            this.lblNewAd1.AutoSize = true;
            this.lblNewAd1.Location = new System.Drawing.Point(33, 179);
            this.lblNewAd1.Name = "lblNewAd1";
            this.lblNewAd1.Size = new System.Drawing.Size(77, 13);
            this.lblNewAd1.TabIndex = 4;
            this.lblNewAd1.Text = "Address Line 1";
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.Location = new System.Drawing.Point(33, 119);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(32, 13);
            this.lblNewEmail.TabIndex = 3;
            this.lblNewEmail.Text = "Email";
            // 
            // lblNewPhone
            // 
            this.lblNewPhone.AutoSize = true;
            this.lblNewPhone.Location = new System.Drawing.Point(297, 119);
            this.lblNewPhone.Name = "lblNewPhone";
            this.lblNewPhone.Size = new System.Drawing.Size(38, 13);
            this.lblNewPhone.TabIndex = 2;
            this.lblNewPhone.Text = "Phone";
            // 
            // lblNewFName
            // 
            this.lblNewFName.AutoSize = true;
            this.lblNewFName.Location = new System.Drawing.Point(33, 73);
            this.lblNewFName.Name = "lblNewFName";
            this.lblNewFName.Size = new System.Drawing.Size(57, 13);
            this.lblNewFName.TabIndex = 1;
            this.lblNewFName.Text = "First Name";
            // 
            // lblNewStuN
            // 
            this.lblNewStuN.AutoSize = true;
            this.lblNewStuN.Location = new System.Drawing.Point(33, 34);
            this.lblNewStuN.Name = "lblNewStuN";
            this.lblNewStuN.Size = new System.Drawing.Size(84, 13);
            this.lblNewStuN.TabIndex = 0;
            this.lblNewStuN.Text = "Student Number";
            // 
            // tbpEdit
            // 
            this.tbpEdit.BackColor = System.Drawing.SystemColors.Control;
            this.tbpEdit.Controls.Add(this.gbEditStudent);
            this.tbpEdit.Controls.Add(this.btEditFindStu);
            this.tbpEdit.Controls.Add(this.tbEditStuID);
            this.tbpEdit.Controls.Add(this.lblEditStuID);
            this.tbpEdit.Location = new System.Drawing.Point(4, 25);
            this.tbpEdit.Name = "tbpEdit";
            this.tbpEdit.Size = new System.Drawing.Size(716, 295);
            this.tbpEdit.TabIndex = 2;
            // 
            // gbEditStudent
            // 
            this.gbEditStudent.Controls.Add(this.cbEditCounty);
            this.gbEditStudent.Controls.Add(this.btEditXML);
            this.gbEditStudent.Controls.Add(this.cbEditCourse);
            this.gbEditStudent.Controls.Add(this.tbEditEmail);
            this.gbEditStudent.Controls.Add(this.lblEditEmail);
            this.gbEditStudent.Controls.Add(this.tbEditPhone);
            this.gbEditStudent.Controls.Add(this.lblEditPhone);
            this.gbEditStudent.Controls.Add(this.btEditUpdate);
            this.gbEditStudent.Controls.Add(this.rbEditPostGrad);
            this.gbEditStudent.Controls.Add(this.rbEditUnderGrad);
            this.gbEditStudent.Controls.Add(this.tbEditA1);
            this.gbEditStudent.Controls.Add(this.tbEditA2);
            this.gbEditStudent.Controls.Add(this.tbEditCity);
            this.gbEditStudent.Controls.Add(this.tbEditLName);
            this.gbEditStudent.Controls.Add(this.tbEditFName);
            this.gbEditStudent.Controls.Add(this.tbEditStuID2);
            this.gbEditStudent.Controls.Add(this.lblLName);
            this.gbEditStudent.Controls.Add(this.lblCounty);
            this.gbEditStudent.Controls.Add(this.lblCity);
            this.gbEditStudent.Controls.Add(this.lblEditDLevel);
            this.gbEditStudent.Controls.Add(this.lblCourse);
            this.gbEditStudent.Controls.Add(this.lblEditA2);
            this.gbEditStudent.Controls.Add(this.lblEditFName);
            this.gbEditStudent.Controls.Add(this.lblEditA1);
            this.gbEditStudent.Controls.Add(this.lblEditStuID2);
            this.gbEditStudent.Location = new System.Drawing.Point(36, 100);
            this.gbEditStudent.Name = "gbEditStudent";
            this.gbEditStudent.Size = new System.Drawing.Size(647, 183);
            this.gbEditStudent.TabIndex = 3;
            this.gbEditStudent.TabStop = false;
            // 
            // btEditXML
            // 
            this.btEditXML.Location = new System.Drawing.Point(522, 45);
            this.btEditXML.Name = "btEditXML";
            this.btEditXML.Size = new System.Drawing.Size(75, 53);
            this.btEditXML.TabIndex = 4;
            this.btEditXML.Text = "Export to XML";
            this.btEditXML.UseVisualStyleBackColor = true;
            this.btEditXML.Click += new System.EventHandler(this.btEditXML_Click);
            // 
            // cbEditCourse
            // 
            this.cbEditCourse.Enabled = false;
            this.cbEditCourse.FormattingEnabled = true;
            this.cbEditCourse.Items.AddRange(new object[] {
            "Software Development",
            "Arts",
            "Science",
            "Business",
            "Mathematics",
            "English"});
            this.cbEditCourse.Location = new System.Drawing.Point(358, 146);
            this.cbEditCourse.Name = "cbEditCourse";
            this.cbEditCourse.Size = new System.Drawing.Size(121, 21);
            this.cbEditCourse.TabIndex = 24;
            // 
            // tbEditEmail
            // 
            this.tbEditEmail.Location = new System.Drawing.Point(374, 38);
            this.tbEditEmail.Name = "tbEditEmail";
            this.tbEditEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEditEmail.TabIndex = 23;
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Location = new System.Drawing.Point(307, 45);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEditEmail.TabIndex = 22;
            this.lblEditEmail.Text = "Email";
            // 
            // tbEditPhone
            // 
            this.tbEditPhone.Location = new System.Drawing.Point(161, 38);
            this.tbEditPhone.Name = "tbEditPhone";
            this.tbEditPhone.Size = new System.Drawing.Size(100, 20);
            this.tbEditPhone.TabIndex = 21;
            // 
            // lblEditPhone
            // 
            this.lblEditPhone.AutoSize = true;
            this.lblEditPhone.Location = new System.Drawing.Point(89, 41);
            this.lblEditPhone.Name = "lblEditPhone";
            this.lblEditPhone.Size = new System.Drawing.Size(38, 13);
            this.lblEditPhone.TabIndex = 20;
            this.lblEditPhone.Text = "Phone";
            // 
            // btEditUpdate
            // 
            this.btEditUpdate.Location = new System.Drawing.Point(522, 104);
            this.btEditUpdate.Name = "btEditUpdate";
            this.btEditUpdate.Size = new System.Drawing.Size(75, 65);
            this.btEditUpdate.TabIndex = 19;
            this.btEditUpdate.Text = "Update";
            this.btEditUpdate.UseVisualStyleBackColor = true;
            this.btEditUpdate.Click += new System.EventHandler(this.btEditUpdate_Click);
            // 
            // rbEditPostGrad
            // 
            this.rbEditPostGrad.AutoSize = true;
            this.rbEditPostGrad.Location = new System.Drawing.Point(358, 93);
            this.rbEditPostGrad.Name = "rbEditPostGrad";
            this.rbEditPostGrad.Size = new System.Drawing.Size(69, 17);
            this.rbEditPostGrad.TabIndex = 18;
            this.rbEditPostGrad.TabStop = true;
            this.rbEditPostGrad.Text = "PostGrad";
            this.rbEditPostGrad.UseVisualStyleBackColor = true;
            // 
            // rbEditUnderGrad
            // 
            this.rbEditUnderGrad.AutoSize = true;
            this.rbEditUnderGrad.Location = new System.Drawing.Point(358, 68);
            this.rbEditUnderGrad.Name = "rbEditUnderGrad";
            this.rbEditUnderGrad.Size = new System.Drawing.Size(77, 17);
            this.rbEditUnderGrad.TabIndex = 17;
            this.rbEditUnderGrad.TabStop = true;
            this.rbEditUnderGrad.Text = "UnderGrad";
            this.rbEditUnderGrad.UseVisualStyleBackColor = true;
            // 
            // tbEditA1
            // 
            this.tbEditA1.Location = new System.Drawing.Point(108, 69);
            this.tbEditA1.Name = "tbEditA1";
            this.tbEditA1.Size = new System.Drawing.Size(100, 20);
            this.tbEditA1.TabIndex = 4;
            // 
            // tbEditA2
            // 
            this.tbEditA2.Location = new System.Drawing.Point(108, 94);
            this.tbEditA2.Name = "tbEditA2";
            this.tbEditA2.Size = new System.Drawing.Size(100, 20);
            this.tbEditA2.TabIndex = 5;
            // 
            // tbEditCity
            // 
            this.tbEditCity.Location = new System.Drawing.Point(108, 120);
            this.tbEditCity.Name = "tbEditCity";
            this.tbEditCity.Size = new System.Drawing.Size(100, 20);
            this.tbEditCity.TabIndex = 6;
            // 
            // tbEditLName
            // 
            this.tbEditLName.Enabled = false;
            this.tbEditLName.Location = new System.Drawing.Point(497, 10);
            this.tbEditLName.Name = "tbEditLName";
            this.tbEditLName.Size = new System.Drawing.Size(100, 20);
            this.tbEditLName.TabIndex = 15;
            // 
            // tbEditFName
            // 
            this.tbEditFName.Enabled = false;
            this.tbEditFName.Location = new System.Drawing.Point(296, 10);
            this.tbEditFName.Name = "tbEditFName";
            this.tbEditFName.Size = new System.Drawing.Size(100, 20);
            this.tbEditFName.TabIndex = 14;
            // 
            // tbEditStuID2
            // 
            this.tbEditStuID2.Enabled = false;
            this.tbEditStuID2.Location = new System.Drawing.Point(92, 10);
            this.tbEditStuID2.Name = "tbEditStuID2";
            this.tbEditStuID2.Size = new System.Drawing.Size(100, 20);
            this.tbEditStuID2.TabIndex = 13;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(430, 13);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 12;
            this.lblLName.Text = "Last Name:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(19, 149);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 11;
            this.lblCounty.Text = "County";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(19, 123);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // lblEditDLevel
            // 
            this.lblEditDLevel.AutoSize = true;
            this.lblEditDLevel.Location = new System.Drawing.Point(247, 72);
            this.lblEditDLevel.Name = "lblEditDLevel";
            this.lblEditDLevel.Size = new System.Drawing.Size(71, 13);
            this.lblEditDLevel.TabIndex = 9;
            this.lblEditDLevel.Text = "Degree Level";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(256, 149);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 8;
            this.lblCourse.Text = "Course";
            // 
            // lblEditA2
            // 
            this.lblEditA2.AutoSize = true;
            this.lblEditA2.Location = new System.Drawing.Point(19, 97);
            this.lblEditA2.Name = "lblEditA2";
            this.lblEditA2.Size = new System.Drawing.Size(77, 13);
            this.lblEditA2.TabIndex = 7;
            this.lblEditA2.Text = "Address Line 2";
            // 
            // lblEditFName
            // 
            this.lblEditFName.AutoSize = true;
            this.lblEditFName.Location = new System.Drawing.Point(230, 13);
            this.lblEditFName.Name = "lblEditFName";
            this.lblEditFName.Size = new System.Drawing.Size(60, 13);
            this.lblEditFName.TabIndex = 5;
            this.lblEditFName.Text = "First Name:";
            // 
            // lblEditA1
            // 
            this.lblEditA1.AutoSize = true;
            this.lblEditA1.Location = new System.Drawing.Point(19, 72);
            this.lblEditA1.Name = "lblEditA1";
            this.lblEditA1.Size = new System.Drawing.Size(77, 13);
            this.lblEditA1.TabIndex = 1;
            this.lblEditA1.Text = "Address Line 1";
            // 
            // lblEditStuID2
            // 
            this.lblEditStuID2.AutoSize = true;
            this.lblEditStuID2.Location = new System.Drawing.Point(19, 13);
            this.lblEditStuID2.Name = "lblEditStuID2";
            this.lblEditStuID2.Size = new System.Drawing.Size(61, 13);
            this.lblEditStuID2.TabIndex = 0;
            this.lblEditStuID2.Text = "Student ID:";
            // 
            // btEditFindStu
            // 
            this.btEditFindStu.Location = new System.Drawing.Point(462, 49);
            this.btEditFindStu.Name = "btEditFindStu";
            this.btEditFindStu.Size = new System.Drawing.Size(75, 23);
            this.btEditFindStu.TabIndex = 2;
            this.btEditFindStu.Text = "Find Student";
            this.btEditFindStu.UseVisualStyleBackColor = true;
            this.btEditFindStu.Click += new System.EventHandler(this.btEditFindStu_Click);
            // 
            // tbEditStuID
            // 
            this.tbEditStuID.Location = new System.Drawing.Point(286, 51);
            this.tbEditStuID.Name = "tbEditStuID";
            this.tbEditStuID.Size = new System.Drawing.Size(100, 20);
            this.tbEditStuID.TabIndex = 1;
            // 
            // lblEditStuID
            // 
            this.lblEditStuID.AutoSize = true;
            this.lblEditStuID.Location = new System.Drawing.Point(167, 54);
            this.lblEditStuID.Name = "lblEditStuID";
            this.lblEditStuID.Size = new System.Drawing.Size(61, 13);
            this.lblEditStuID.TabIndex = 0;
            this.lblEditStuID.Text = "Student ID:";
            // 
            // tbpDelete
            // 
            this.tbpDelete.BackColor = System.Drawing.SystemColors.Control;
            this.tbpDelete.Controls.Add(this.gbDelStudent);
            this.tbpDelete.Controls.Add(this.btDelFindStu);
            this.tbpDelete.Controls.Add(this.tbDelStuID);
            this.tbpDelete.Controls.Add(this.lblDelStuID);
            this.tbpDelete.Location = new System.Drawing.Point(4, 25);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Size = new System.Drawing.Size(716, 295);
            this.tbpDelete.TabIndex = 3;
            // 
            // gbDelStudent
            // 
            this.gbDelStudent.Controls.Add(this.cbDelCounty);
            this.gbDelStudent.Controls.Add(this.cbDelCourse);
            this.gbDelStudent.Controls.Add(this.tbDelEmail);
            this.gbDelStudent.Controls.Add(this.lblDelEmail);
            this.gbDelStudent.Controls.Add(this.tbDelPhone);
            this.gbDelStudent.Controls.Add(this.lblDelPhone);
            this.gbDelStudent.Controls.Add(this.btDelDelete);
            this.gbDelStudent.Controls.Add(this.rbDelPostGrad);
            this.gbDelStudent.Controls.Add(this.rbDelUnderGrad);
            this.gbDelStudent.Controls.Add(this.tbDelA1);
            this.gbDelStudent.Controls.Add(this.tbDelA2);
            this.gbDelStudent.Controls.Add(this.tbDelCity);
            this.gbDelStudent.Controls.Add(this.tbDelLName);
            this.gbDelStudent.Controls.Add(this.tbDelFName);
            this.gbDelStudent.Controls.Add(this.tbDelStuID2);
            this.gbDelStudent.Controls.Add(this.lblDelLName);
            this.gbDelStudent.Controls.Add(this.lblDelCounty);
            this.gbDelStudent.Controls.Add(this.lblDelCity);
            this.gbDelStudent.Controls.Add(this.lblDelDLevel);
            this.gbDelStudent.Controls.Add(this.lblDelCourse);
            this.gbDelStudent.Controls.Add(this.lblDelA2);
            this.gbDelStudent.Controls.Add(this.lblDelFName);
            this.gbDelStudent.Controls.Add(this.lbl);
            this.gbDelStudent.Controls.Add(this.lblDelStuID2);
            this.gbDelStudent.Location = new System.Drawing.Point(36, 100);
            this.gbDelStudent.Name = "gbDelStudent";
            this.gbDelStudent.Size = new System.Drawing.Size(647, 183);
            this.gbDelStudent.TabIndex = 7;
            this.gbDelStudent.TabStop = false;
            // 
            // cbDelCourse
            // 
            this.cbDelCourse.Enabled = false;
            this.cbDelCourse.FormattingEnabled = true;
            this.cbDelCourse.Items.AddRange(new object[] {
            "Software Development",
            "Arts",
            "Science",
            "Business",
            "Mathematics",
            "English"});
            this.cbDelCourse.Location = new System.Drawing.Point(358, 146);
            this.cbDelCourse.Name = "cbDelCourse";
            this.cbDelCourse.Size = new System.Drawing.Size(121, 21);
            this.cbDelCourse.TabIndex = 28;
            // 
            // tbDelEmail
            // 
            this.tbDelEmail.Enabled = false;
            this.tbDelEmail.Location = new System.Drawing.Point(374, 38);
            this.tbDelEmail.Name = "tbDelEmail";
            this.tbDelEmail.Size = new System.Drawing.Size(100, 20);
            this.tbDelEmail.TabIndex = 27;
            // 
            // lblDelEmail
            // 
            this.lblDelEmail.AutoSize = true;
            this.lblDelEmail.Location = new System.Drawing.Point(307, 45);
            this.lblDelEmail.Name = "lblDelEmail";
            this.lblDelEmail.Size = new System.Drawing.Size(32, 13);
            this.lblDelEmail.TabIndex = 26;
            this.lblDelEmail.Text = "Email";
            // 
            // tbDelPhone
            // 
            this.tbDelPhone.Enabled = false;
            this.tbDelPhone.Location = new System.Drawing.Point(161, 38);
            this.tbDelPhone.Name = "tbDelPhone";
            this.tbDelPhone.Size = new System.Drawing.Size(100, 20);
            this.tbDelPhone.TabIndex = 25;
            // 
            // lblDelPhone
            // 
            this.lblDelPhone.AutoSize = true;
            this.lblDelPhone.Location = new System.Drawing.Point(89, 41);
            this.lblDelPhone.Name = "lblDelPhone";
            this.lblDelPhone.Size = new System.Drawing.Size(38, 13);
            this.lblDelPhone.TabIndex = 24;
            this.lblDelPhone.Text = "Phone";
            // 
            // btDelDelete
            // 
            this.btDelDelete.Location = new System.Drawing.Point(522, 102);
            this.btDelDelete.Name = "btDelDelete";
            this.btDelDelete.Size = new System.Drawing.Size(75, 65);
            this.btDelDelete.TabIndex = 19;
            this.btDelDelete.Text = "Delete";
            this.btDelDelete.UseVisualStyleBackColor = true;
            this.btDelDelete.Click += new System.EventHandler(this.btDelDelete_Click);
            // 
            // rbDelPostGrad
            // 
            this.rbDelPostGrad.AutoSize = true;
            this.rbDelPostGrad.Enabled = false;
            this.rbDelPostGrad.Location = new System.Drawing.Point(358, 93);
            this.rbDelPostGrad.Name = "rbDelPostGrad";
            this.rbDelPostGrad.Size = new System.Drawing.Size(69, 17);
            this.rbDelPostGrad.TabIndex = 18;
            this.rbDelPostGrad.TabStop = true;
            this.rbDelPostGrad.Text = "PostGrad";
            this.rbDelPostGrad.UseVisualStyleBackColor = true;
            // 
            // rbDelUnderGrad
            // 
            this.rbDelUnderGrad.AutoSize = true;
            this.rbDelUnderGrad.Enabled = false;
            this.rbDelUnderGrad.Location = new System.Drawing.Point(358, 68);
            this.rbDelUnderGrad.Name = "rbDelUnderGrad";
            this.rbDelUnderGrad.Size = new System.Drawing.Size(77, 17);
            this.rbDelUnderGrad.TabIndex = 17;
            this.rbDelUnderGrad.TabStop = true;
            this.rbDelUnderGrad.Text = "UnderGrad";
            this.rbDelUnderGrad.UseVisualStyleBackColor = true;
            // 
            // tbDelA1
            // 
            this.tbDelA1.Enabled = false;
            this.tbDelA1.Location = new System.Drawing.Point(108, 69);
            this.tbDelA1.Name = "tbDelA1";
            this.tbDelA1.Size = new System.Drawing.Size(100, 20);
            this.tbDelA1.TabIndex = 4;
            // 
            // tbDelA2
            // 
            this.tbDelA2.Enabled = false;
            this.tbDelA2.Location = new System.Drawing.Point(108, 94);
            this.tbDelA2.Name = "tbDelA2";
            this.tbDelA2.Size = new System.Drawing.Size(100, 20);
            this.tbDelA2.TabIndex = 5;
            // 
            // tbDelCity
            // 
            this.tbDelCity.Enabled = false;
            this.tbDelCity.Location = new System.Drawing.Point(108, 120);
            this.tbDelCity.Name = "tbDelCity";
            this.tbDelCity.Size = new System.Drawing.Size(100, 20);
            this.tbDelCity.TabIndex = 6;
            // 
            // tbDelLName
            // 
            this.tbDelLName.Enabled = false;
            this.tbDelLName.Location = new System.Drawing.Point(497, 10);
            this.tbDelLName.Name = "tbDelLName";
            this.tbDelLName.Size = new System.Drawing.Size(100, 20);
            this.tbDelLName.TabIndex = 15;
            // 
            // tbDelFName
            // 
            this.tbDelFName.Enabled = false;
            this.tbDelFName.Location = new System.Drawing.Point(296, 10);
            this.tbDelFName.Name = "tbDelFName";
            this.tbDelFName.Size = new System.Drawing.Size(100, 20);
            this.tbDelFName.TabIndex = 14;
            // 
            // tbDelStuID2
            // 
            this.tbDelStuID2.Enabled = false;
            this.tbDelStuID2.Location = new System.Drawing.Point(92, 10);
            this.tbDelStuID2.Name = "tbDelStuID2";
            this.tbDelStuID2.Size = new System.Drawing.Size(100, 20);
            this.tbDelStuID2.TabIndex = 13;
            // 
            // lblDelLName
            // 
            this.lblDelLName.AutoSize = true;
            this.lblDelLName.Location = new System.Drawing.Point(430, 13);
            this.lblDelLName.Name = "lblDelLName";
            this.lblDelLName.Size = new System.Drawing.Size(61, 13);
            this.lblDelLName.TabIndex = 12;
            this.lblDelLName.Text = "Last Name:";
            // 
            // lblDelCounty
            // 
            this.lblDelCounty.AutoSize = true;
            this.lblDelCounty.Location = new System.Drawing.Point(19, 149);
            this.lblDelCounty.Name = "lblDelCounty";
            this.lblDelCounty.Size = new System.Drawing.Size(40, 13);
            this.lblDelCounty.TabIndex = 11;
            this.lblDelCounty.Text = "County";
            // 
            // lblDelCity
            // 
            this.lblDelCity.AutoSize = true;
            this.lblDelCity.Location = new System.Drawing.Point(19, 123);
            this.lblDelCity.Name = "lblDelCity";
            this.lblDelCity.Size = new System.Drawing.Size(24, 13);
            this.lblDelCity.TabIndex = 10;
            this.lblDelCity.Text = "City";
            // 
            // lblDelDLevel
            // 
            this.lblDelDLevel.AutoSize = true;
            this.lblDelDLevel.Location = new System.Drawing.Point(247, 72);
            this.lblDelDLevel.Name = "lblDelDLevel";
            this.lblDelDLevel.Size = new System.Drawing.Size(71, 13);
            this.lblDelDLevel.TabIndex = 9;
            this.lblDelDLevel.Text = "Degree Level";
            // 
            // lblDelCourse
            // 
            this.lblDelCourse.AutoSize = true;
            this.lblDelCourse.Location = new System.Drawing.Point(256, 149);
            this.lblDelCourse.Name = "lblDelCourse";
            this.lblDelCourse.Size = new System.Drawing.Size(40, 13);
            this.lblDelCourse.TabIndex = 8;
            this.lblDelCourse.Text = "Course";
            // 
            // lblDelA2
            // 
            this.lblDelA2.AutoSize = true;
            this.lblDelA2.Location = new System.Drawing.Point(19, 97);
            this.lblDelA2.Name = "lblDelA2";
            this.lblDelA2.Size = new System.Drawing.Size(77, 13);
            this.lblDelA2.TabIndex = 7;
            this.lblDelA2.Text = "Address Line 2";
            // 
            // lblDelFName
            // 
            this.lblDelFName.AutoSize = true;
            this.lblDelFName.Location = new System.Drawing.Point(230, 13);
            this.lblDelFName.Name = "lblDelFName";
            this.lblDelFName.Size = new System.Drawing.Size(60, 13);
            this.lblDelFName.TabIndex = 5;
            this.lblDelFName.Text = "First Name:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(19, 72);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Address Line 1";
            // 
            // lblDelStuID2
            // 
            this.lblDelStuID2.AutoSize = true;
            this.lblDelStuID2.Location = new System.Drawing.Point(19, 13);
            this.lblDelStuID2.Name = "lblDelStuID2";
            this.lblDelStuID2.Size = new System.Drawing.Size(61, 13);
            this.lblDelStuID2.TabIndex = 0;
            this.lblDelStuID2.Text = "Student ID:";
            // 
            // btDelFindStu
            // 
            this.btDelFindStu.Location = new System.Drawing.Point(462, 49);
            this.btDelFindStu.Name = "btDelFindStu";
            this.btDelFindStu.Size = new System.Drawing.Size(75, 23);
            this.btDelFindStu.TabIndex = 6;
            this.btDelFindStu.Text = "Find Student";
            this.btDelFindStu.UseVisualStyleBackColor = true;
            this.btDelFindStu.Click += new System.EventHandler(this.btDelFindStu_Click);
            // 
            // tbDelStuID
            // 
            this.tbDelStuID.Location = new System.Drawing.Point(286, 51);
            this.tbDelStuID.Name = "tbDelStuID";
            this.tbDelStuID.Size = new System.Drawing.Size(100, 20);
            this.tbDelStuID.TabIndex = 5;
            // 
            // lblDelStuID
            // 
            this.lblDelStuID.AutoSize = true;
            this.lblDelStuID.Location = new System.Drawing.Point(167, 54);
            this.lblDelStuID.Name = "lblDelStuID";
            this.lblDelStuID.Size = new System.Drawing.Size(61, 13);
            this.lblDelStuID.TabIndex = 4;
            this.lblDelStuID.Text = "Student ID:";
            // 
            // tbpHistory
            // 
            this.tbpHistory.BackColor = System.Drawing.SystemColors.Control;
            this.tbpHistory.Controls.Add(this.dgHistory);
            this.tbpHistory.Location = new System.Drawing.Point(4, 25);
            this.tbpHistory.Name = "tbpHistory";
            this.tbpHistory.Size = new System.Drawing.Size(716, 295);
            this.tbpHistory.TabIndex = 4;
            // 
            // dgHistory
            // 
            this.dgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistory.Location = new System.Drawing.Point(1, 6);
            this.dgHistory.Name = "dgHistory";
            this.dgHistory.Size = new System.Drawing.Size(714, 286);
            this.dgHistory.TabIndex = 1;
            // 
            // cbNewCounty
            // 
            this.cbNewCounty.FormattingEnabled = true;
            this.cbNewCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbNewCounty.Location = new System.Drawing.Point(133, 262);
            this.cbNewCounty.Name = "cbNewCounty";
            this.cbNewCounty.Size = new System.Drawing.Size(100, 21);
            this.cbNewCounty.TabIndex = 24;
            // 
            // cbEditCounty
            // 
            this.cbEditCounty.FormattingEnabled = true;
            this.cbEditCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbEditCounty.Location = new System.Drawing.Point(108, 146);
            this.cbEditCounty.Name = "cbEditCounty";
            this.cbEditCounty.Size = new System.Drawing.Size(100, 21);
            this.cbEditCounty.TabIndex = 25;
            // 
            // cbDelCounty
            // 
            this.cbDelCounty.FormattingEnabled = true;
            this.cbDelCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbDelCounty.Location = new System.Drawing.Point(108, 146);
            this.cbDelCounty.Name = "cbDelCounty";
            this.cbDelCounty.Size = new System.Drawing.Size(100, 21);
            this.cbDelCounty.TabIndex = 29;
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "DBForm";
            this.Text = "DBForm";
            this.tabControl1.ResumeLayout(false);
            this.tbpView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).EndInit();
            this.tbpNew.ResumeLayout(false);
            this.tbpNew.PerformLayout();
            this.tbpEdit.ResumeLayout(false);
            this.tbpEdit.PerformLayout();
            this.gbEditStudent.ResumeLayout(false);
            this.gbEditStudent.PerformLayout();
            this.tbpDelete.ResumeLayout(false);
            this.tbpDelete.PerformLayout();
            this.gbDelStudent.ResumeLayout(false);
            this.gbDelStudent.PerformLayout();
            this.tbpHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpView;
        private System.Windows.Forms.DataGridView dgStudents;
        private System.Windows.Forms.TabPage tbpNew;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.ComboBox cbNewCourses;
        private System.Windows.Forms.RadioButton rbNewPostGrad;
        private System.Windows.Forms.RadioButton rbNewUnderGrad;
        private System.Windows.Forms.TextBox tbNewCity;
        private System.Windows.Forms.TextBox tbNewAd2;
        private System.Windows.Forms.TextBox tbNewAd1;
        private System.Windows.Forms.TextBox tbNewPhone;
        private System.Windows.Forms.TextBox tbNewEmail;
        private System.Windows.Forms.TextBox tbNewLName;
        private System.Windows.Forms.TextBox tbNewFName;
        private System.Windows.Forms.TextBox tbNewStuN;
        private System.Windows.Forms.Label lblNewCourse;
        private System.Windows.Forms.Label lblNewDType;
        private System.Windows.Forms.Label lblNewLName;
        private System.Windows.Forms.Label lblNewCounty;
        private System.Windows.Forms.Label lblNewCity;
        private System.Windows.Forms.Label lblNewAd2;
        private System.Windows.Forms.Label lblNewAd1;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.Label lblNewPhone;
        private System.Windows.Forms.Label lblNewFName;
        private System.Windows.Forms.Label lblNewStuN;
        private System.Windows.Forms.TabPage tbpEdit;
        private System.Windows.Forms.GroupBox gbEditStudent;
        private System.Windows.Forms.Button btEditUpdate;
        private System.Windows.Forms.RadioButton rbEditPostGrad;
        private System.Windows.Forms.RadioButton rbEditUnderGrad;
        private System.Windows.Forms.TextBox tbEditA1;
        private System.Windows.Forms.TextBox tbEditA2;
        private System.Windows.Forms.TextBox tbEditCity;
        private System.Windows.Forms.TextBox tbEditLName;
        private System.Windows.Forms.TextBox tbEditFName;
        private System.Windows.Forms.TextBox tbEditStuID2;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblEditDLevel;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblEditA2;
        private System.Windows.Forms.Label lblEditFName;
        private System.Windows.Forms.Label lblEditA1;
        private System.Windows.Forms.Label lblEditStuID2;
        private System.Windows.Forms.Button btEditFindStu;
        private System.Windows.Forms.TextBox tbEditStuID;
        private System.Windows.Forms.Label lblEditStuID;
        private System.Windows.Forms.TabPage tbpDelete;
        private System.Windows.Forms.GroupBox gbDelStudent;
        private System.Windows.Forms.Button btDelDelete;
        private System.Windows.Forms.RadioButton rbDelPostGrad;
        private System.Windows.Forms.RadioButton rbDelUnderGrad;
        private System.Windows.Forms.TextBox tbDelA1;
        private System.Windows.Forms.TextBox tbDelA2;
        private System.Windows.Forms.TextBox tbDelCity;
        private System.Windows.Forms.TextBox tbDelLName;
        private System.Windows.Forms.TextBox tbDelFName;
        private System.Windows.Forms.TextBox tbDelStuID2;
        private System.Windows.Forms.Label lblDelLName;
        private System.Windows.Forms.Label lblDelCounty;
        private System.Windows.Forms.Label lblDelCity;
        private System.Windows.Forms.Label lblDelDLevel;
        private System.Windows.Forms.Label lblDelCourse;
        private System.Windows.Forms.Label lblDelA2;
        private System.Windows.Forms.Label lblDelFName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblDelStuID2;
        private System.Windows.Forms.Button btDelFindStu;
        private System.Windows.Forms.TextBox tbDelStuID;
        private System.Windows.Forms.Label lblDelStuID;
        private System.Windows.Forms.TabPage tbpHistory;
        private System.Windows.Forms.TextBox tbEditPhone;
        private System.Windows.Forms.Label lblEditPhone;
        private System.Windows.Forms.TextBox tbEditEmail;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.ComboBox cbEditCourse;
        private System.Windows.Forms.TextBox tbDelEmail;
        private System.Windows.Forms.Label lblDelEmail;
        private System.Windows.Forms.TextBox tbDelPhone;
        private System.Windows.Forms.Label lblDelPhone;
        private System.Windows.Forms.ComboBox cbDelCourse;
        private System.Windows.Forms.DataGridView dgHistory;
        private Button btEditXML;
        private ComboBox cbNewCounty;
        private ComboBox cbEditCounty;
        private ComboBox cbDelCounty;
    }
}
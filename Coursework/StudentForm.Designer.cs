namespace Coursework
{
    partial class StudentForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.enrolledDateLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enrollmentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.studentInformationLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.studentInfoTable = new System.Windows.Forms.DataGridView();
            this.editRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentFormLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.ComboBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.enrolledDate = new System.Windows.Forms.DateTimePicker();
            this.emailLbl = new System.Windows.Forms.Label();
            this.courseLbl = new System.Windows.Forms.Label();
            this.birthDateLbl = new System.Windows.Forms.Label();
            this.contactLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.sortCombo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // enrolledDateLbl
            // 
            this.enrolledDateLbl.AutoSize = true;
            this.enrolledDateLbl.Location = new System.Drawing.Point(14, 59);
            this.enrolledDateLbl.Name = "enrolledDateLbl";
            this.enrolledDateLbl.Size = new System.Drawing.Size(96, 18);
            this.enrolledDateLbl.TabIndex = 8;
            this.enrolledDateLbl.Text = "Enrolled Date:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sortCombo);
            this.panel1.Controls.Add(this.enrollmentChart);
            this.panel1.Controls.Add(this.studentInformationLbl);
            this.panel1.Controls.Add(this.idTxt);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.errorLbl);
            this.panel1.Controls.Add(this.studentInfoTable);
            this.panel1.Controls.Add(this.studentFormLbl);
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Controls.Add(this.emailTxt);
            this.panel1.Controls.Add(this.course);
            this.panel1.Controls.Add(this.birthDate);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.contactTxt);
            this.panel1.Controls.Add(this.addressTxt);
            this.panel1.Controls.Add(this.lastNameTxt);
            this.panel1.Controls.Add(this.firstNameTxt);
            this.panel1.Controls.Add(this.enrolledDate);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.courseLbl);
            this.panel1.Controls.Add(this.birthDateLbl);
            this.panel1.Controls.Add(this.contactLbl);
            this.panel1.Controls.Add(this.addressLbl);
            this.panel1.Controls.Add(this.genderLbl);
            this.panel1.Controls.Add(this.lastNameLbl);
            this.panel1.Controls.Add(this.firstNameLbl);
            this.panel1.Controls.Add(this.enrolledDateLbl);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 588);
            this.panel1.TabIndex = 0;
            // 
            // enrollmentChart
            // 
            chartArea3.Name = "ChartArea1";
            this.enrollmentChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.enrollmentChart.Legends.Add(legend3);
            this.enrollmentChart.Location = new System.Drawing.Point(682, 40);
            this.enrollmentChart.Name = "enrollmentChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.enrollmentChart.Series.Add(series3);
            this.enrollmentChart.Size = new System.Drawing.Size(321, 251);
            this.enrollmentChart.TabIndex = 32;
            this.enrollmentChart.Text = " ";
            // 
            // studentInformationLbl
            // 
            this.studentInformationLbl.AutoSize = true;
            this.studentInformationLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInformationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentInformationLbl.Location = new System.Drawing.Point(10, 343);
            this.studentInformationLbl.Name = "studentInformationLbl";
            this.studentInformationLbl.Size = new System.Drawing.Size(178, 23);
            this.studentInformationLbl.TabIndex = 31;
            this.studentInformationLbl.Text = "Student Informations";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(507, 51);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 26);
            this.idTxt.TabIndex = 30;
            this.idTxt.Visible = false;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(560, 260);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 31);
            this.clearBtn.TabIndex = 29;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(17, 298);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.errorLbl.Size = new System.Drawing.Size(0, 18);
            this.errorLbl.TabIndex = 28;
            // 
            // studentInfoTable
            // 
            this.studentInfoTable.AllowUserToAddRows = false;
            this.studentInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editRow,
            this.deleteRow});
            this.studentInfoTable.Location = new System.Drawing.Point(3, 383);
            this.studentInfoTable.Name = "studentInfoTable";
            this.studentInfoTable.Size = new System.Drawing.Size(1000, 163);
            this.studentInfoTable.TabIndex = 27;
            this.studentInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentInfoTable_CellContentClick);
            // 
            // editRow
            // 
            this.editRow.HeaderText = "Edit";
            this.editRow.Name = "editRow";
            this.editRow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editRow.Text = "Edit";
            this.editRow.UseColumnTextForButtonValue = true;
            // 
            // deleteRow
            // 
            this.deleteRow.HeaderText = "Delete";
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteRow.Text = "Delete";
            this.deleteRow.UseColumnTextForButtonValue = true;
            // 
            // studentFormLbl
            // 
            this.studentFormLbl.AutoSize = true;
            this.studentFormLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentFormLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentFormLbl.Location = new System.Drawing.Point(10, 7);
            this.studentFormLbl.Name = "studentFormLbl";
            this.studentFormLbl.Size = new System.Drawing.Size(118, 23);
            this.studentFormLbl.TabIndex = 26;
            this.studentFormLbl.Text = "Student Form";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(475, 260);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 31);
            this.submitBtn.TabIndex = 25;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(413, 209);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(250, 26);
            this.emailTxt.TabIndex = 24;
            // 
            // course
            // 
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "Computing",
            "Multimedia Technologies",
            "Networks and IT Security"});
            this.course.Location = new System.Drawing.Point(121, 212);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(188, 26);
            this.course.TabIndex = 23;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(413, 167);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(194, 26);
            this.birthDate.TabIndex = 22;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender.Location = new System.Drawing.Point(121, 171);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(188, 26);
            this.gender.TabIndex = 21;
            // 
            // contactTxt
            // 
            this.contactTxt.Location = new System.Drawing.Point(413, 129);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(194, 26);
            this.contactTxt.TabIndex = 20;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(121, 133);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(188, 26);
            this.addressTxt.TabIndex = 19;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(413, 92);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(194, 26);
            this.lastNameTxt.TabIndex = 18;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(121, 95);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(188, 26);
            this.firstNameTxt.TabIndex = 17;
            // 
            // enrolledDate
            // 
            this.enrolledDate.Location = new System.Drawing.Point(121, 59);
            this.enrolledDate.Name = "enrolledDate";
            this.enrolledDate.Size = new System.Drawing.Size(188, 26);
            this.enrolledDate.TabIndex = 16;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(327, 214);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(46, 18);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "Email:";
            // 
            // courseLbl
            // 
            this.courseLbl.AutoSize = true;
            this.courseLbl.Location = new System.Drawing.Point(14, 217);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(61, 18);
            this.courseLbl.TabIndex = 15;
            this.courseLbl.Text = "Courses:";
            // 
            // birthDateLbl
            // 
            this.birthDateLbl.AutoSize = true;
            this.birthDateLbl.Location = new System.Drawing.Point(325, 173);
            this.birthDateLbl.Name = "birthDateLbl";
            this.birthDateLbl.Size = new System.Drawing.Size(74, 18);
            this.birthDateLbl.TabIndex = 14;
            this.birthDateLbl.Text = "Birth Date:";
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Location = new System.Drawing.Point(325, 132);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(80, 18);
            this.contactLbl.TabIndex = 13;
            this.contactLbl.Text = "Contact No:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(14, 137);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(62, 18);
            this.addressLbl.TabIndex = 12;
            this.addressLbl.Text = "Address:";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(14, 178);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(58, 18);
            this.genderLbl.TabIndex = 11;
            this.genderLbl.Text = "Gender:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(325, 95);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(76, 18);
            this.lastNameLbl.TabIndex = 10;
            this.lastNameLbl.Text = "Last Name:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(14, 100);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(82, 18);
            this.firstNameLbl.TabIndex = 9;
            this.firstNameLbl.Text = "First Name: ";
            // 
            // sortCombo
            // 
            this.sortCombo.FormattingEnabled = true;
            this.sortCombo.Items.AddRange(new object[] {
            "Name",
            "Enrolled Date"});
            this.sortCombo.Location = new System.Drawing.Point(882, 351);
            this.sortCombo.Name = "sortCombo";
            this.sortCombo.Size = new System.Drawing.Size(121, 26);
            this.sortCombo.TabIndex = 35;
            this.sortCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 611);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label enrolledDateLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView studentInfoTable;
        private System.Windows.Forms.Label studentFormLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.Label birthDateLbl;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label studentInformationLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart enrollmentChart;
        private System.Windows.Forms.DateTimePicker enrolledDate;
        private System.Windows.Forms.DataGridViewButtonColumn editRow;
        private System.Windows.Forms.DataGridViewButtonColumn deleteRow;
        private System.Windows.Forms.ComboBox sortCombo;
    }
}
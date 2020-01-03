using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            BindGrid();
        }

        //Submit and update button 
        //When edit button is clicked submit button changes into update button
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (submitBtn.Text == "Submit")
            {
                Student obj = new Student();
                if (firstNameTxt.Text == "" || lastNameTxt.Text == "" || addressTxt.Text == "" ||
                    contactTxt.Text == "" || emailTxt.Text == "")
                {
                    errorLbl.Text = "Empty TextField Found";
                }
                else
                {
                    try
                    {
                        string firstName = firstNameTxt.Text.First().ToString().ToUpper() + firstNameTxt.Text.Substring(1);
                        string lastName = lastNameTxt.Text;
                        obj.EnrolledDate = enrolledDate.Value.Date;
                        obj.Name = firstName + " " + lastName;
                        obj.Address = addressTxt.Text;
                        obj.Contact = contactTxt.Text;
                        obj.Gender = gender.SelectedItem.ToString();
                        obj.BirthDate = birthDate.Value.Date;
                        obj.Course = course.SelectedItem.ToString();
                        obj.Email = emailTxt.Text;
                        obj.Add(obj);
                        BindGrid();
                        Clear();
                        errorLbl.Text = "Successfully Added";
                    }
                    catch (Exception)
                    {
                        errorLbl.Text = "Invalid";
                    }
                }
            }
            else
            {
                Student obj = new Student();
                if (firstNameTxt.Text == "" || lastNameTxt.Text == "" || addressTxt.Text == "" ||
                    contactTxt.Text == "" || emailTxt.Text == "")
                {
                    errorLbl.Text = "Empty TextField Found";
                }
                else
                {
                    try
                    {
                        obj.Id = int.Parse(idTxt.Text);
                        string firstName = firstNameTxt.Text.First().ToString().ToUpper() + firstNameTxt.Text.Substring(1);
                        string lastName = lastNameTxt.Text;
                        obj.EnrolledDate = enrolledDate.Value.Date;
                        obj.Name = firstName + " " + lastName;
                        obj.Address = addressTxt.Text;
                        obj.Contact = contactTxt.Text;
                        obj.Gender = gender.SelectedItem.ToString();
                        obj.BirthDate = birthDate.Value.Date;
                        obj.Course = course.SelectedItem.ToString();
                        obj.Email = emailTxt.Text;
                        obj.Edit(obj);
                        BindGrid();
                        Clear();
                        errorLbl.Text = "Updated Successfully";
                        submitBtn.Text = "Submit";
                        clearBtn.Text = "Clear";
                    }
                    catch (Exception)
                    {
                        errorLbl.Text = "Invalid";
                    }
                }
            }
        }

        //bind the data to the datagridtable
        public void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable tableData = Utility.ConvertToDataTable(listStudents);
            studentInfoTable.DataSource = tableData;
            BindChart(listStudents);
        }

        //function to clear all the textfield and change dropdown to initial state
        public void Clear()
        {
            enrolledDate.Value = DateTime.Today;
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            addressTxt.Text = "";
            contactTxt.Text = "";
            gender.SelectedItem = null;
            birthDate.Value = DateTime.Today;
            course.SelectedItem = null;
            emailTxt.Text = "";
            idTxt.Text = "";

        }

        //two events triggers one clear and another cancel while editing is done.
        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (clearBtn.Text == "Clear")
            {
                errorLbl.Text = "";
                Clear();
            }
            else
            {
                Clear();
                submitBtn.Text = "Submit";
                clearBtn.Text = "Clear";

            }
        }

        // binds data of no.of students of sepecific course and displays it in the form of chart.
        private void BindChart(List<Student> list)
        {
            if (list != null)
            {
                var result = list
                    .GroupBy(l => l.Course)
                    .Select(cl => new
                    {
                        Course = cl.First().Course,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                enrollmentChart.DataSource = dt;
                enrollmentChart.Name = "Course";
                enrollmentChart.Series["Series1"].XValueMember = "Course";
                enrollmentChart.Series["Series1"].YValueMembers = "Count";
                this.enrollmentChart.Titles.Remove(this.enrollmentChart.Titles.FirstOrDefault());
                this.enrollmentChart.Titles.Add("Weekly Enrollment Chart");
                enrollmentChart.Series["Series1"].IsValueShownAsLabel = true;
            }
        }

        //edit and delete button present in each row of datagrid.
        //cell button edit and delete was created for editing and deleting of sepecific row
        private void studentInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student obj = new Student();
            int index = e.RowIndex;
            if (!(index < 0))
            {
                if (e.ColumnIndex == 0)
                {
                    errorLbl.Text = "";
                    //get the value of the clicked rows id column                
                    string value = studentInfoTable[2, index].Value.ToString();
                    Console.WriteLine(value);
                    int id = 0;
                    if (String.IsNullOrEmpty(value))
                    {
                        MessageBox.Show("Invalid Data");
                    }
                    else
                    {
                        id = int.Parse(value);
                        Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                        idTxt.Text = s.Id.ToString();
                        firstNameTxt.Text = s.Name.Split(' ')[0];
                        lastNameTxt.Text = s.Name.Split(' ')[1];
                        addressTxt.Text = s.Address;
                        emailTxt.Text = s.Email;
                        birthDate.Value = s.BirthDate;
                        contactTxt.Text = s.Contact;
                        gender.SelectedItem = s.Gender;
                        course.SelectedItem = s.Course;
                        submitBtn.Text = "Update";
                        clearBtn.Text = "Cancel";
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    errorLbl.Text = "";
                    string message = "Do you want to Delete this Record?";
                    string title = "Delete Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        //get the value of the clicked rows id column
                        string value = studentInfoTable[2, e.RowIndex].Value.ToString();
                        obj.Delete(int.Parse(value));
                        BindGrid();
                        errorLbl.Text = "Record Successfully Deleted";
                    }
                }
            }

        }

        private void sortByNameBtn_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            String temp;
            List<Student> listStudents = obj.List();
            string[] arr1 = new string[listStudents.Count];
            for (int i = 0; i < listStudents.Count; i++)
            {
                var id = listStudents[i].Id;
                var name = listStudents[i].Name.Split(' ')[0];
                arr1[i] = name;
            }
            int l = arr1.Length;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    int a = 0;
                    if (arr1[j][a].CompareTo(arr1[j + 1][a]) > 0)
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                    else if (arr1[j][0] == arr1[j + 1][0])
                    {
                        if (arr1[j][1].CompareTo(arr1[j + 1][1]) > 0)
                        {
                            temp = arr1[j];
                            arr1[j] = arr1[j + 1];
                            arr1[j + 1] = temp;
                        }
                    }
                }
                List<Student> listStudents2 = new List<Student>();
                for (int a = 0; a < arr1.Length; a++)
                {
                    for (int b = 0; b < listStudents.Count; b++)
                    {
                        var id = listStudents[b].Id;
                        var name = listStudents[b].Name.Split(' ')[0];
                        Console.WriteLine(listStudents[b].Id);
                        if (arr1[a] == name)
                        {
                            listStudents2.Add(listStudents[b]);
                        }
                    }
                }
                DataTable dt = Utility.ConvertToDataTable(listStudents2);
                studentInfoTable.DataSource = dt;
            }
        }

        private void sortByEnrollDate_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            DateTime temp;
            List<Student> listStudents = obj.List();
            DateTime[] arr1 = new DateTime[listStudents.Count];
            for (int i = 0; i < listStudents.Count; i++)
            {
                var id = listStudents[i].Id;
                var date = listStudents[i].EnrolledDate.Date;
                arr1[i] = date;
            }
            int l = arr1.Length;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                    {

                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {

                Console.WriteLine(arr1[i]);
            }
            List<Student> listStudents2 = new List<Student>();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < listStudents.Count; j++)
                {
                    var id = listStudents[j].Id;
                    var name = listStudents[j].EnrolledDate.Date;
                    if (arr1[i] == name)
                    {
                        listStudents2.Add(listStudents[j]);
                    }
                }
            }
            DataTable dt = Utility.ConvertToDataTable(listStudents2);
            studentInfoTable.DataSource = dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> listofstd = obj.List();
            if (sortCombo.SelectedItem.ToString() == "Name")
            {
                List<Student> list = obj.SortingByName(listofstd);
                DataTable dt = Utility.ConvertToDataTable(list);
                studentInfoTable.DataSource = dt;

            }
            if (sortCombo.SelectedItem.ToString() == "Enrolled Date")
            {
                List<Student> list = obj.SortingByRegDate(listofstd);
                DataTable dt = Utility.ConvertToDataTable(list);
                studentInfoTable.DataSource = dt;
            }
        }
    }


}

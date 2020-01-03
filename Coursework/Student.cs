using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Coursework
{
    class Student
    {
        public int Id { get; set; }
        public DateTime EnrolledDate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }


        private string _filePath = "studentInfo.json";

        public void Add(Student info)
        {
            Random r = new Random();
            info.Id = r.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Console.WriteLine(data);
            Utility.WriteToFile(_filePath, data);
        }

        public List<Student> List()
        {
            string d = Utility.ReadFromFile(_filePath);
            if (d != null)
            {
                List<Student> list = JsonConvert.DeserializeObject<List<Student>>(d);
                return list;
            }
            return null;
        }
        public void Delete(int id)
        {
            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //converting list of student to string
            int count = list.Count;
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of utility class 
            Utility.WriteToFile(_filePath, data, false, count);
        }
        public void Edit(Student info)
        {
            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == info.Id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //adding the updated student object to the list
            list.Add(info);
            //converting list of student to string
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of utility class 
            Utility.WriteToFile(_filePath, data, false);
        }
        public List<Student> SortingByName(List<Student> list)
        {
            int id;
            string name;
            string address;
            string gender;
            string email;
            DateTime regndate;
            string Contact;
            string course;
            if (list != null)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i].Name.ToUpper().CompareTo(list[j].Name.ToUpper()) > 0)
                        {
                            id = list[i].Id;
                            list[i].Id = list[j].Id;
                            list[j].Id = id;

                            name = list[i].Name;
                            list[i].Name = list[j].Name;
                            list[j].Name = name;

                            gender = list[i].Gender;
                            list[i].Gender = list[j].Gender;
                            list[j].Gender = gender;

                            email = list[i].Email;
                            list[i].Email = list[j].Email;
                            list[j].Email = email;

                            regndate = list[i].EnrolledDate;
                            list[i].EnrolledDate = list[j].EnrolledDate;
                            list[j].EnrolledDate = regndate;

                            Contact = list[i].Contact;
                            list[i].Contact = list[j].Contact;
                            list[j].Contact = Contact;
                        }
                    }
                }
                return list;
            }
            return null;
        }




        public List<Student> SortingByRegDate(List<Student> list)
        {
            int id;
            string name;
            string address;
            string gender;
            string email;
            DateTime regndate;
            string Contact;
            string course;
            if (list != null)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i].EnrolledDate.CompareTo(list[j].EnrolledDate) > 0)
                        {
                            id = list[i].Id;
                            list[i].Id = list[j].Id;
                            list[j].Id = id;

                            name = list[i].Name;
                            list[i].Name = list[j].Name;
                            list[j].Name = name;

                            gender = list[i].Gender;
                            list[i].Gender = list[j].Gender;
                            list[j].Gender = gender;

                            email = list[i].Email;
                            list[i].Email = list[j].Email;
                            list[j].Email = email;

                            regndate = list[i].EnrolledDate;
                            list[i].EnrolledDate = list[j].EnrolledDate;
                            list[j].EnrolledDate = regndate;

                            Contact = list[i].Contact;
                            list[i].Contact = list[j].Contact;
                            list[j].Contact = Contact;
                        }
                    }
                }
                return list;
            }
            return null;
        }
    }
}

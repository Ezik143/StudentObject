using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentObjects
{
    class Program
    {
        static void Main()
        {
            var student1 = new Student("Alice Johnson", 20, "Computer Science", 2,  "2003-05-15", "123 Main St", 1234567890, "Tech University", "Smith", "John Johnson");
            Console.WriteLine(student1.DisplayStudentInfo());
            var student2 = new Student("Bob Smith", 22, "Mathematics", 4, "2001-08-20", "456 Elm St", 9876543210, "Tech University", "Doe", "Jane Smith");
            Console.WriteLine(student2.DisplayStudentInfo());
            var student3 = new Student("Charlie Brown", 19, "Physics", 1, "2004-11-30", "789 Oak St", 1231231234, "Tech University", "Brown", "Charlie Brown Sr.");
            Console.WriteLine(student3.DisplayStudentInfo());
            var student4 = new Student("Diana Prince", 21, "Chemistry", 3, "2002-02-14", "321 Pine St", 4564564567, "Tech University", "Prince", "Thomas Prince");
            Console.WriteLine(student4.DisplayStudentInfo());
            var student5 = new Student("Ethan Hunt", 23, "Engineering", 4, "2000-12-01", "654 Maple St", 7897897890, "Tech University", "Hunt", "James Hunt");
            Console.WriteLine(student5.DisplayStudentInfo());
            var student6 = new Student("Fiona Gallagher", 20, "Psychology", 2, "2003-03-03", "987 Cedar St", 3213213210, "Tech University", "Gallagher", "Frank Gallagher");
            Console.WriteLine(student6.DisplayStudentInfo());
            var student7 = new Student("George Costanza", 22, "Business", 4, "2001-07-07", "159 Birch St", 6546546543, "Tech University", "Costanza", "Frank Costanza");
            Console.WriteLine(student7.DisplayStudentInfo());
            var student8 = new Student("Hannah Montana", 19, "Music", 1, "2004-10-10", "753 Spruce St", 9879879876, "Tech University", "Montana", "Billy Ray Cyrus");
            Console.WriteLine(student8.DisplayStudentInfo());
            var student9 = new Student("Ian Malcolm", 21, "Biology", 3, "2002-06-06", "258 Fir St", 3216549870, "Tech University", "Malcolm", "John Malcolm");
            Console.WriteLine(student9.DisplayStudentInfo());
            var student10 = new Student("Julia Roberts", 23, "Literature", 4, "2000-09-09", "369 Willow St", 6543217890, "Tech University", "Roberts", "Walter Roberts");
            Console.WriteLine(student10.DisplayStudentInfo());
            var student11 = new Student("Kevin Hart", 20, "Drama", 2, "2003-04-04", "147 Chestnut St", 7891234560, "Tech University", "Hart", "Henry Hart");
            Console.WriteLine(student11.DisplayStudentInfo());
            var student12 = new Student("Laura Croft", 22, "Archaeology", 4, "2001-01-01", "258 Walnut St", 3219876540, "Tech University", "Croft", "Richard Croft");
            Console.WriteLine(student12.DisplayStudentInfo());
            var student13 = new Student("Mike Wazowski", 19, "Animation", 1, "2004-12-12", "369 Maple St", 4567891230, "Tech University", "Wazowski", "Henry Wazowski");
            Console.WriteLine(student13.DisplayStudentInfo());
            var student14 = new Student("Nina Simone", 21, "History", 3, "2002-05-05", "147 Oak St", 7894561230, "Tech University", "Simone", "Samuel Simone");
            Console.WriteLine(student14.DisplayStudentInfo());
            var student15 = new Student("Oscar Wilde", 23, "Philosophy", 4, "2000-08-08", "258 Pine St", 1234567890, "Tech University", "Wilde", "William Wilde");
            Console.WriteLine(student15.DisplayStudentInfo());
            var student16 = new Student("Paula Abdul", 20, "Dance", 2, "2003-02-02", "369 Birch St", 9876543210, "Tech University", "Abdul", "Anthony Abdul");
            Console.WriteLine(student16.DisplayStudentInfo());
            var student17 = new Student("Quentin Tarantino", 22, "Film Studies", 4, "2001-03-03", "147 Cedar St", 1231231234, "Tech University", "Tarantino", "Tony Tarantino");
            Console.WriteLine(student17.DisplayStudentInfo());
            var student18 = new Student("Rachel Green", 19, "Fashion Design", 1, "2004-11-11", "258 Spruce St", 4564564567, "Tech University", "Green", "Jack Green");
            Console.WriteLine(student18.DisplayStudentInfo());
            var student19 = new Student("Sam Winchester", 21, "Theology", 3, "2002-07-07", "369 Fir St", 7897897890, "Tech University", "Winchester", "John Winchester");
            Console.WriteLine(student19.DisplayStudentInfo());
            var student20 = new Student("Tina Fey", 23, "Comedy Writing", 4, "2000-10-10", "147 Willow St", 3213213210, "Tech University", "Fey", "Donald Fey");
            Console.WriteLine(student20.DisplayStudentInfo());
        }
    }

    public class Student
    {
        public string name;
        public int age;
        public string course;
        public int year;
        public string birthdate;
        public string address;
        public long phonenumber;
        public string school;
        public string maidenName;
        public string fathersName;

        public Student(string Name_, int age_, string course_,int year_ , string birthdate_,string address_ , long phonenumber_, string school_, string maidenName_, string fathersName_)
        {
            name = Name_;
            age = age_;
            course = course_;
            year = year_;
            birthdate = birthdate_;
            address = address_;
            phonenumber = phonenumber_;
            school = school_;
            maidenName = maidenName_;
            fathersName = fathersName_;
        }

        public string DisplayStudentInfo()
        {
            return $"Name: {name},\n Age: {age},\n Course: {course},\n Birthdate: {birthdate},\n Address: {address},\n Phone Number: {phonenumber},\n School: {school},\n Maiden Name: {maidenName},\n Father's Name: {fathersName}";
        }
    }
}

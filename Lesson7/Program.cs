using System;

namespace Lesson7
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gmail { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, string surname, string gmail,int age,string gender, string phonenumber)
        {
            Name = name;
            Surname = surname;
            Gmail = gmail;
            Age = age;
            Gender = gender;
            PhoneNumber = phonenumber;
        }
        public void Show()
        {
            Console.WriteLine(Name+Surname+Gmail+Age+Gender+PhoneNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("fazl","Aziz","aq@gmail.com",20,"male","935516182");
            person.Show();
        }
    }
}

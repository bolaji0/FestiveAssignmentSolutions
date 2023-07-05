using System;
namespace FestiveAssignment
{
	public class Student
	{
        /* Create a class called `Student` with the following properties:
             - `Name` (string): Represents the student's name.
             - `Age` (int): Represents the student's age.
             - `Grade` (double): Represents the student's grade.
        */

        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }


        //Note the constructor here is not compulsory, You can recreate your own without using the constructor.
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

    }
}


namespace FestiveAssignment;
class Program
{
    static void Main(string[] args)
    {
        /*
         *Task: Student Records*

         You are given a list of student records containing their names, ages,
         and grades. Your task is to perform various operations using LINQ to
         extract specific information and generate a report.

         1. Create a class called `Student` with the following properties:
            - `Name` (string): Represents the student's name.
            - `Age` (int): Represents the student's age.
            - `Grade` (double): Represents the student's grade.

         2. In the `Main` method, create a list of `Student` objects with at
            least 5 records. Make sure each student has a unique name, age, and grade.

         3. Use LINQ to perform the following operations:

            a) Sort the students in ascending order based on their grades and,
               for students with the same grade, sort them in descending order based on their ages.

            b) Filter the students who have a grade higher than or equal to 80.

            c) Select and print the names of the filtered students.

         *Example Output:*


         Sorted Students:
         Name: Alice, Age: 18, Grade: 85.5
         Name: Bob, Age: 20, Grade: 92.0
         Name: Charlie, Age: 19, Grade: 85.5
         Name: Dave, Age: 21, Grade: 81.2
         Name: Eve, Age: 19, Grade: 87.8

         Filtered Students:
         Alice
         Bob
         Charlie
         Eve


         *Notes:*
         - You can use either an array or a list to store the student records.
         - You may initialize the student records directly in the code or prompt the user for input.
         - Ensure that the sorting logic in `OrderBy` and `ThenBy` correctly handles
           grades in ascending order and ages in descending order.

         - Make use of the `Where` operator to filter students based on the given condition.
         - Use the `Select` operator to project the student names into a separate collection. 
         */


        // Create a list of students
        List<Student> students = new List<Student>() {
                new Student("Alice", 18, 85.5),
                new Student("Bob", 20, 92.0),
                new Student("Charlie", 19, 85.5),
                new Student("Dave", 21, 81.2),
                new Student("Eve", 19, 87.8)
        };

        //// Filter the students who have a grade higher than or equal to 80
        //var filteredStudents = students.Where(s => s.Grade >= 80);

        //// Print the names of the filtered student
        //foreach (var student in filteredStudents)
        //{
        //    Console.WriteLine("Name: {0}, Age: {1}, Grade: {2}", student.Name, student.Age, student.Grade);
        //}




        //OR







        //Prompt the user for input and create a new student object

        // Prompt the user for input and create a new student object
        string name;
        int age;
        double grade;
        do
        {
            Console.WriteLine("Enter the student's name: ");
            name = Console.ReadLine();
            //Note : The isnullorempty is used to check if a string is empty
        } while (string.IsNullOrEmpty(name));

        do
        {
            Console.WriteLine("Enter the student's age: ");
            age = int.Parse(Console.ReadLine());
        } while (age < 0);

        do
        {
            Console.WriteLine("Enter the student's grade: ");
            grade = double.Parse(Console.ReadLine());
        } while (grade < 0 || grade > 100);

        // Add the student to the list
        Student student = new Student(name, age, grade);
        //The Add method is a method that is used to add an element to a collection
        students.Add(student);

        foreach (var item in students)
        {
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2}", item.Name, item.Age, item.Grade);
        }





        Console.ReadLine();

    }
}


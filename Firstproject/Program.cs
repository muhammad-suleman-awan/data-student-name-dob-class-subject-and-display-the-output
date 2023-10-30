using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        Console.WriteLine("Student Data Collection");

        while (true)
        {
            Console.WriteLine("\nEnter student data or type 'exit' to finish:");

            // Get student name
            Console.Write("Name: ");
            string name = Console.ReadLine();

            // Check if the user wants to exit
            if (name.ToLower() == "exit")
                break;

            // Get date of birth
            Console.Write("Date of Birth (YYYY-MM-DD): ");
            DateTime dob;
            while (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Invalid date format. Please enter the date in YYYY-MM-DD format.");
            }

            // Get class
            Console.Write("Class: ");
            string studentClass = Console.ReadLine();

            // Get subject
            Console.Write("Subject: ");
            string subject = Console.ReadLine();

            // Create a new student object
            Student student = new Student(name, dob, studentClass, subject);

            // Add the student to the list
            students.Add(student);

            Console.WriteLine("\nStudent Data Recorded Successfully!\n");
        }

        // Display the collected information
        Console.WriteLine("\nCollected Student Information:\n");

        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Date of Birth: {student.DateOfBirth.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Class: {student.StudentClass}");
            Console.WriteLine($"Subject: {student.Subject}");
            Console.WriteLine("-----------------------------");
        }
    }
}

class Student
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string StudentClass { get; set; }
    public string Subject { get; set; }

    public Student(string name, DateTime dob, string studentClass, string subject)
    {
        Name = name;
        DateOfBirth = dob;
        StudentClass = studentClass;
        Subject = subject;
    }
}

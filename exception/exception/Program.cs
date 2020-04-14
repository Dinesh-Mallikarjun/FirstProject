using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Student newStudent = null;

        try
        {
            newStudent = new Student();
            newStudent.StudentName = "James";


            ValidateStudent(newStudent);
            Console.ReadKey();
        }
        catch (InvalidStudentNameException ex)
        {
            Console.WriteLine(ex.Message);
        }


        Console.ReadKey();
    }

    private static void ValidateStudent(Student std)
    {
        Regex regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(std.StudentName))
            throw new InvalidStudentNameException(std.StudentName);

    }

    private class Student
    {
        public string StudentName { get; internal set; }
    }

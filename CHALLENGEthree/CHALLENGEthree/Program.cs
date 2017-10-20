using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IDictionary<int, Student> studentDict = new Dictionary<int, Student>()
                    {
                        { 1, new Student(){ StudentAge =1, StudentName = "Bill"}},
                        { 2, new Student(){ StudentAge =2, StudentName = "Steve"}},
                        { 3, new Student(){ StudentAge =3, StudentName = "Ram"}}
                    };

        Student std = new Student() { StudentAge = 1, StudentName = "Bill" };

        KeyValuePair<int, Student> studentToFind = new KeyValuePair<int, Student>(1, std);

        bool result = studentDict.Contains(studentToFind, new StudentDictionaryComparer());

        Console.WriteLine("Found Student? {0}", result);
    }
}

public class Student
{
    public int StudentAge { get; set; }
    public string StudentName { get; set; }
}

class StudentDictionaryComparer : IEqualityComparer<KeyValuePair<int, Student>>
{ };
//Create a new dictionary called roadtohire that holds yourself, name and age(example "Nancy", 22).
//Add each student in your class to the dictionary, as well as a random student, and display your total
//number of students.Once you have done that remove the random student from your roadtohire dictionary, 
//and display your current number of students.Finally find yourself in the dictionary and display your name and your age.
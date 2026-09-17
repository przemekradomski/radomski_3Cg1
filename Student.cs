using System.Security.Cryptography;
using System;

class Student
{
    private string firstName;
    private string lastName;
    private string group;
    private int age;

    public Student(string firstName, string lastName, string group, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.group = group;
        this.age = age;
    }

    public string GetFirstName() => firstName;
    public string GetLastName() => lastName;
    public string getGroup() => group;
    public int getAge() => age;
}

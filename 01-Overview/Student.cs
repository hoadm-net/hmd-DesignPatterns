namespace _01_Overview;

public class Student
{
    private string name;
    private int age;
    private string studentID;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set 
        { 
            if (value > 0)
                age = value; 
        }
    }

    public string StudentID
    {
        get { return studentID; }
        set { studentID = value; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}
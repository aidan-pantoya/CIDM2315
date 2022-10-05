namespace Homework6;
// Aidan Pantoya CIDM 2315 HW 6

class Professor
{
  public string profName;

  public string classTeach;
  private double salary;
  public void SetSalary(double salary_amount)
  {
    salary = salary_amount;
  }
  public double GetSalary()
  {
    return salary;
  }
}

class Student
{
  public string studentName;

  public string classEnroll;
  private double studentGrade;
  public void SetGrade(double newGrade)
  {
    studentGrade = newGrade;
  }
  public double GetGrade()
  {
    return studentGrade;
  }
}

class Program
{
    static void Main(string[] args)
    {
        Professor Alice = new Professor();
        Alice.profName = "Alice";
        Alice.classTeach = "Java";
        Alice.SetSalary(9000);
        double AS = Alice.GetSalary();
        Console.WriteLine("Professor " + Alice.profName + " teaches " + Alice.classTeach + ", and the salary is: " + AS);

         Professor Bob = new Professor();
        Bob.profName = "Bob";
        Bob.classTeach = "Math";
        Bob.SetSalary(8000);
        double BS = Bob.GetSalary();
        Console.WriteLine("Professor " + Bob.profName + " teaches " + Bob.classTeach + ", and the salary is: " + BS);

        Student Lisa = new Student();
        Lisa.studentName = "Lisa";
        Lisa.classEnroll = "Java";
        Lisa.SetGrade(90);
        double LG = Lisa.GetGrade();
        Console.WriteLine("Student " + Lisa.studentName + " enrolls " + Lisa.classEnroll + ", and the grade is: " + LG);

        Student Tom = new Student();
        Tom.studentName = "Tom";
        Tom.classEnroll = "Math";
        Tom.SetGrade(80);
        double TG = Tom.GetGrade();
        Console.WriteLine("Student " + Tom.studentName + " enrolls " + Tom.classEnroll + ", and the grade is: " + TG);

        Console.WriteLine("The salary difference between "+ Alice.profName + " and " + Bob.profName + " is: " + (AS - BS));
        Console.WriteLine("The total grade between "+ Lisa.studentName + " and "+ Tom.studentName + " is: " + (LG + TG));
  }
}
namespace Homework9;
using System.Linq;
// Aidan Pantoya 10/26/2022

class Student{
    public static List<Student> student_list = new List<Student>();
    private int studentID;
    private string studentName;
    public string tryName;
    public void PrintInfo(){
Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int id,string n){
        studentID = id;
        studentName = n;
        tryName = n;
        student_list.Add(this);
    }   
}
// Aidan Pantoya
class Program
{
    static void Main(string[] args)
    {
        Student Alice = new Student(111,"Alice");
        Student Bob = new Student(222,"Bob");
        Student Cathy = new Student(333,"Cathy");
        Student David = new Student(444,"David");

        Dictionary<string,double> gradebook = new Dictionary<string,double>();
        gradebook.Add("Alice",4.0);
        gradebook.Add("Bob",3.6);
        gradebook.Add("Cathy",2.5);
        gradebook.Add("David",1.8);

         if(gradebook.ContainsKey("Tom")){
            Console.WriteLine("Tom is in the List");
        }
        else{
            gradebook.Add("Tom",3.3);
        }
        Console.WriteLine($"The average GPA is: {gradebook.Values.Average()}");
        foreach(var stu in gradebook){
        if(stu.Value > gradebook.Values.Average()){
            string nn = stu.Key;
            foreach(Student stud in Student.student_list){
           if(stud.tryName == nn){
            stud.PrintInfo();
            }
        }
        }
    }
}
}

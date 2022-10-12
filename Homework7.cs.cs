namespace Homework7;

class Customer{
private int cus_id;
public string cus_name;
public int cus_age;
public Customer(int cus_id, string cus_name, int cus_age){
    this.cus_id = cus_id;
    this.cus_name = cus_name;
    this.cus_age = cus_age;
}
public void ChangeID(int new_id)
{
    cus_id = new_id;
}

public void PrintCusInfo()
{
    Console.WriteLine("Customer: "+cus_id+", name: "+cus_name+", age:"+cus_age);
}
public void CompareAge(Customer objCustomer)
{
    if(objCustomer.cus_age > this.cus_age)
    {
        Console.WriteLine(objCustomer.cus_name + " is older");
    }
    else if(objCustomer.cus_age < this.cus_age)
    {
        Console.WriteLine(this.cus_name + " is older");
    }
    else Console.WriteLine("Same age");
}
}
class Program
{
    static void Main(string[] args)
    {
        Customer A = new Customer(110,"Alice",28);
        A.PrintCusInfo();
        Customer B = new Customer(111,"Bob",30);
        B.PrintCusInfo();
        A.ChangeID(220);
        A.PrintCusInfo();
        B.ChangeID(221);
        B.PrintCusInfo();
        A.CompareAge(B);
    }
}

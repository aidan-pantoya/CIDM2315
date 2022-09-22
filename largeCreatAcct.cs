namespace HW3;

// Aidan Pantoya CIDM
// Homework 9/22/2022
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers:");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"a = {x}; b = {y}");
        Console.WriteLine("The largest number is: " + Large(x, y));

        Console.WriteLine("Enter four integers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}");
        int max = Large(a, b);
        int maxx = Large(c, d);
        int maxxx = Large(max, maxx);
        Console.WriteLine("The largest number is: " + maxxx);

        createAccount();
    }

    static int Large(int a, int b)
    {
        if (a >= b)
            return a;
        else return b;
    }

    static bool checkAge(int birth_year)
    {
        int age = 2022 - birth_year;
        if (age >= 18) return true;
        else return false;
    }

    static void createAccount()
    {
        Console.WriteLine("Enter Username:");
        string user = Console.ReadLine();
        Console.WriteLine("Enter Password:");
        string pass = Console.ReadLine();
        Console.WriteLine("Re-Enter Password:");
        string passs = Console.ReadLine();
        Console.WriteLine("Enter Birth Year:");
        int byr = Convert.ToInt32(Console.ReadLine());
        if ((checkAge(byr) == true) && (pass == passs))
        {
            Console.WriteLine("Accound is created successfully");
        }
        else if (pass != passs)
        {
            Console.WriteLine("Wrong password");
        }
        else Console.WriteLine("Could not create account");
    }
}
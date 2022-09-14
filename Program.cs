namespace HW3;

// Aidan Pantoya CIDM
// Homework 9/14/2022
class Program
{
    static void Main(string[] args)
    {
        // Part 1
        Console.WriteLine("Enter two different numbers:");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Largest number is: " + Large(x,y));
        // End Part 1

        // Part 2
        Console.WriteLine("Enter N:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter right or left:");
        string rl = Console.ReadLine();
        part2(n,rl);
        // End part 2
    }
    static int Large(int a, int b) // For part 1
    {
        if(a>b)
        return a;
        else return b;
    }

    static void part2(int n, string s) // For part 2
    {
        if (s == "left"){
           for (int i = 1; i <= n; i++)  
         {  
            for (int j = 1; j <= i; j++)  
            {  
               Console.Write("");  
            }  
            for (int k = 1; k <= i; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
        }

    else if (s == "right"){
        for (int i = 1; i <= n; i++)  
         {  
            for (int j = 1; j <= n-i; j++)  
            {  
               Console.Write(" ");  
            }  
            for (int k = 1; k <= i; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
    }

    else Console.WriteLine("Try again, entered bad info");
    }
    }
    // End part 2

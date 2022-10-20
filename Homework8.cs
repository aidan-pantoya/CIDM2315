namespace Homework8;
class Program
{
    static void ArraySum(int[] int_array)
    {
        int t = 0;
        int n=5;
        for(int i = 0; i<n;i++)
        {
            t = t + int_array[i];
        }
        Console.WriteLine($"The Sum of int_array is: {t}");
    }

    static void PrintAllOddNumber(int[,] array_2d)
    {
        int n=3;
        for(int i = 0; i<n;i++)
        for(int j = 0;j<n;j++){
        {
            if (array_2d[i,j]%2 == 1)
            Console.Write($"{array_2d[i,j]} ");
        }}
        Console.WriteLine("");
    }
    static int ElementSum(int[,]array_2d)
    {
        int t = 0;
        int n=3;
        for(int i = 0; i<n;i++){
        for(int j = 0; j<n;j++)
        {
            t = t + array_2d[i,j];
        }}
        return t;
    }
    
    static int[,]DoubleArray(int[,] array_2d)
    {
        int[,] newArray = {{0,0,0},{0,0,0},{0,0,0}} ;
        int n = 3;
        for(int i = 0;i<n;i++){
        for(int j = 0;j<n;j++)
        {
            newArray[i,j] = array_2d[i,j]*2; 
        }}
       return newArray;
    }
    static void Main(string[] args)
    {
        // Part 1 start
        int[] int_array={11,23,31,42,53};
        ArraySum(int_array);
        // Part 1 End

        // Part 2 start
        int[,] array_2d = {{1,2,3},{4,5,6},{7,8,9}};
        Console.WriteLine("Q1: Print all odd Numbers:");
        PrintAllOddNumber(array_2d);
        Console.WriteLine($"Q2: The sum of the array elements: {ElementSum(array_2d)}");
        Console.WriteLine("Q3: The new 2d array:");
        int [,] newArr = DoubleArray(array_2d);
        for(int i = 0; i<3;i++)
        {for(int j = 0; j<3;j++){
            Console.Write(newArr[i,j] + " ");
        }
        }
    }
}

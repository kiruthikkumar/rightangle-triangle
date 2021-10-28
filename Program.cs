using System;

namespace rightangle_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter the value : ");
            i = Convert.ToInt32(Console.ReadLine());
            for(int n=i;n>0;n--)
            {   
                for (int j=0;j<n;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
                
            }
        }
    }
}

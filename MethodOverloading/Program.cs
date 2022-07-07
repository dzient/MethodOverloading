// See https://aka.ms/new-console-template for more information
//-----------------------------------------------------------------
//Iteration Statements
//
// Name: David Zientara
// Date: 7-4-2022
// Comments: An exercise in method overloading
// Added methods per the instructions
//-----------------------------------------------------------------
namespace MethodOverloading
{
    
    class Program
    {
        public static int Add(int a, int b)
        {
            return (a + b);
        }
        public static double Add(double a, double b)
        {
            return (a + b);
        }
        public static string Add(int a, int b, bool dollar)
        {
            string retval = "";
            a += b;
            retval += a.ToString();
            if (dollar)
            {
                retval += " dollar";
                if (a > 1)
                    retval += "s";
            }
            return retval;
        }
       
        public static void Main(String[] args)
        {
            Random rnd = new Random();
            int s1 = rnd.Next(1000);
            int s2 = rnd.Next(1000);
            double d1 = rnd.Next(1000);
            double d2 = rnd.Next(1000);
            double d3 = rnd.Next(1000);
            double d4 = rnd.Next(1000);
            d1 /= d2;
            d3 /= d4;

            Console.WriteLine($"{s1} + {s2} = {Add(s1, s2)} ");
            Console.WriteLine($"{d1} + {d3} = {Add(d1, d3)} ");
            s1 = rnd.Next(25);
            s2 = rnd.Next(25);
            Console.WriteLine($"${s1} + ${s2} = {Add(s1, s2, true)} ");


        }
    }
}

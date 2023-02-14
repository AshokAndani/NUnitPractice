using System.Collections;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    public static class Patterns
    {//  ^[$
        public static string AnyCharInbetween = @"^a.b$"; // acb,abb
        public static string Name3to9 = @"^[a-zA-Z]{3,7}$";
        public static string optional = @"^ashok|anil$";//Ashok@[A-Z]+[a-z]{2,4}(@[<>\?\*\\\""/\|])+$
        public static string NameWithSurname = @"^$";
        public static string FirstCharCaps = @"^[A-Z][a-z@]{3,9}[@ ][A-Z][a-z]{3,9}$";

    }
    public class Program
    {
        public bool CheckAnyCharInbetween(string input)
        {
            Regex r = new Regex(Patterns.AnyCharInbetween);
            return r.IsMatch(input);
        }
        static  void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Math m = new Math();
            Console.WriteLine(m.Add(12, 12));
            Console.WriteLine(m.divide(2, 2));
            Console.ReadLine();

            ////Console.WriteLine("Enter Value");
            ////Regex r = new Regex(Patterns.AnyCharInbetween);
            ////Console.WriteLine(r.IsMatch(Console.ReadLine()));

            //Console.WriteLine("Enter Name:");
            //Regex r1 = new Regex(Patterns.FirstCharCaps);
            //if (!r1.IsMatch(Console.ReadLine()))
            //{
            //    Console.WriteLine("UserName is not valid");
            //}
            //else{
            //    Console.WriteLine("Welcome");
            //}
            ////Regex r2 = new Regex(Patterns.optional);
            ////Console.WriteLine(r2.IsMatch("anil"));
            ////Console.WriteLine("Enter you name with surname:");
            ////Regex r3 = new Regex(Patterns.NameWithSurname);
            ////Console.WriteLine(r3.IsMatch(Console.ReadLine()));
        }
    }
}
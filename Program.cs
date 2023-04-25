using _25._04Pratice.Models;
using _25._04Pratice.Utilities.Exceptions;
using System;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace _25._04Pratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Student or 2.Coordinator");
            string ans = Console.ReadLine();

            if (ans == "1")
            {
               string Group = Console.ReadLine();
                int Age = Convert.ToInt32(Console.ReadLine());
                string Name = Console.ReadLine();
                string Surname = Console.ReadLine();
                int Id = Convert.ToInt32(Console.ReadLine());
                
            }
            else
            {
               
                
            }

            static void Validator(string Name,string Surname)
            {
                if (Name.Length>3 | Surname.Length>3)
                {
                    throw new Custom_Exception("ttttt");
                }
                Console.WriteLine("");
            }

            try
            {
                Validator();
            }
            catch (Exception Exe)
            {
                Console.WriteLine(Exe.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //###########################################################
            //if (args.Length > 0)
            //{
            //    Console.WriteLine($"Hello, {args[0]} !");
            //}
            //else
            //{
            //  Console.WriteLine("Hello!");
            //}
            //###########################################################d

        
        var book = new Book("Dillons Grade Book");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.5);
        
        var stats =book.ShowStatistics();



        //var book2 = new Book();
        //book2.AddGrade(90.1);

        
            //Console.WriteLine($"Grades totalled : {stats.:N2}");
            Console.WriteLine($"Average grade is : {stats.Average:N1}");
            Console.WriteLine($"Min val is : {stats.Low}");
            Console.WriteLine($"Max val is  : {stats.High}");
        }

      
    }
}
using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Book{
        //constructor   
        public Book(string name ){
            grades=new List<double>();
            Name =name;
        }
        public void AddGrade(double grade)
        { 
            grades.Add(grade);
        }

        private List<double> grades ;
        public string Name;

        public Statistics ShowStatistics()
        {
            // var x = 34.1;
            // var y = 10.3;
            // var result = x + y;
            // Console.WriteLine($"X {x} + Y {y} = {result:N2}");

            // double[] grades = new[] { 12.7, 10.3, 6.11, 4.1 };
            //###########################################################
            // grades[0]=12.7;
            // grades[1]=10.2;
            // grades[2]=6.11;
            //###########################################################
            
            //double result, averageGrade;
            return GetStatistics();
                      

        }
        public  Statistics GetStatistics()
        {
            var result = new Statistics();
            result.High = double.MinValue;
            result.Low =double.MaxValue;
            result.Average = 0.0;
            
            foreach (var grade in grades)
            {
                // (grade>highGrade){
                //     highGrade=grade;
                // }
                result.High=Math.Max(grade,result.High);
                result.Low=Math.Min(grade, result.Low);
                result.Average += grade;
                
            }
            result.Average/=grades.Count;
            return result;

        }
    }
            
}
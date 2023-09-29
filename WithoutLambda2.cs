//using System;
//using System.Collections.Generic;

//class Student
//{
//    public int rollNo { get; set; }
//    public string name { get; set; }
//}

//namespace LambdaExpressions
//{
//    public class WithoutLambda2
//    {
//        static List<Student> SortStudentsByName(List<Student> details)
//        {
//            details.Sort((x, y) => x.name.CompareTo(y.name));
//            return details;
//        }

//        ////public static void Main(string[] args)
//        {
//            List<Student> details = new List<Student>() {
//                new Student { rollNo = 1, name = "Liza" },
//                new Student { rollNo = 2, name = "Stewart" },
//                new Student { rollNo = 3, name = "Tina" },
//                new Student { rollNo = 4, name = "Stefani" },
//                new Student { rollNo = 5, name = "Trish" }
//            };

//            List<Student> sortedDetails = SortStudentsByName(details);

//            foreach (var value in sortedDetails)
//            {
//                Console.WriteLine(value.rollNo + " " + value.name);
//            }
//        }
//    }
//}

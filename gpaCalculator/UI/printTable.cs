using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpaCalculator.UI
{
    public class printTable
    {
        public static void DisplayTable(string courseName,int courseUnit,string grade,int gradeUnit,int weightPoint,string remark)
        {
            Console.WriteLine("| {0,15} | {1,15} | {2,15} | {3,15} | {4,15} | {5,15} |", courseName, courseUnit, grade, gradeUnit, weightPoint, remark);
            Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");

            /*Console.WriteLine("*************************");
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Unit: " + courseUnit);
            Console.WriteLine("Grade Unit: " + gradeUnit);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Weight Point: " + weightPoint);
            Console.WriteLine("Remark: " + remark);
            Console.WriteLine("*************************");*/
        }
        public static void DisplayGP(int totalCourseUnit,int totalCourseUnitPassed,int totalWeightPoint, double GPA)
        {
            Console.WriteLine("Total Course Unit Registered is "+ totalCourseUnit);
            Console.WriteLine("Total Course Unit Passed is " + totalCourseUnitPassed);
            Console.WriteLine("Total Weight Point is " + totalWeightPoint);
            Console.WriteLine("GPA = " + GPA);
        }

        public static void DisplayTableStructure()
        {
            Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("| {0,15} | {1,15} | {2,15} | {3,15} | {4,15} | {5,15} |", "COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE UNIT", "WEIGHT Pt.", "REMARK");
            Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");
        }
    }
}

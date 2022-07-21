using gpaCalculator.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpaCalculator.Core
{
    public class calculation
    {
        public static void CalculateGP(List<string> courseNames, List<int> courseUnits, List<double> courseScores)
        {
            int totalCourseUnitPassed = 0;
            int totalWeightPoint = 0;
            int totalCourseUnit = 0;
            printTable.DisplayTableStructure();
            for(int i = 0; i < courseNames.Count; i++)
            {
                string courseName = courseNames[i];
                int courseUnit = courseUnits[i];
                double courseScore = courseScores[i];
                int gradeUnit = GetGradeUnit(courseScore);
                string grade = GetGrade(gradeUnit);
                int weightPoint = courseUnit * gradeUnit;
                string remark = GetRemark(gradeUnit);
                totalWeightPoint = totalWeightPoint + weightPoint;
                totalCourseUnit = totalCourseUnit + courseUnit;


                if(gradeUnit != 0)
                {
                    totalCourseUnitPassed += courseUnit;
                }
                else
                {
                    //
                }
                // Send Data to Print Table for Display
                printTable.DisplayTable(courseName, courseUnit, grade, gradeUnit, weightPoint, remark);
            }

            double GPA = Math.Round((double)totalWeightPoint / totalCourseUnit, 2);

            //Send GPA to Print Table for Display
            printTable.DisplayGP(totalCourseUnit, totalCourseUnitPassed, totalWeightPoint, GPA);
            
        }

        public static int GetGradeUnit(double courseScore)
        {
            int gradeUnit = 0;
            if(courseScore >= 70 && courseScore <= 100)
            {
                gradeUnit = 5;
            }else if(courseScore >= 60 && courseScore < 70)
            {
                gradeUnit = 4;
            }else if(courseScore>=50 && courseScore < 60)
            {
                gradeUnit = 3;
            }else if(courseScore>=45 && courseScore < 50)
            {
                gradeUnit = 2;
            }else if(courseScore>=40 && courseScore < 45)
            {
                gradeUnit = 1;
            }else if(courseScore >= 0 && courseScore < 40)
            {
                gradeUnit = 0;
            }
            else
            {

            }
            return gradeUnit;
        }

        public static string GetGrade(int gradeUnit)
        {
            string grade = "";
            switch (gradeUnit)
            {
                case 5:
                    grade = "A";
                    break;
                case 4:
                    grade = "B";
                    break;
                case 3:
                    grade = "C";
                    break;
                case 2:
                    grade = "D";
                    break;
                case 1:
                    grade = "E";
                    break;
                case 0:
                    grade = "F";
                    break;
            }
            return grade;
        }

        public static string GetRemark(int gradeUnit)
        {
            string remark = "";
            switch (gradeUnit)
            {
                case 5:
                    remark = "Excellent";
                    break;
                case 4:
                    remark = "Very Good";
                    break;
                case 3:
                    remark = "Good";
                    break;
                case 2:
                    remark = "Fair";
                    break;
                case 1:
                    remark = "Pass";
                    break;
                case 0:
                    remark = "Fail";
                    break;
            }
            return remark;
        }
    }
}

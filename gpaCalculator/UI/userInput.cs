using gpaCalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpaCalculator.UI
{   //to store users input
    
   public class userInput
    {
        List<string> courseNames = new List<string>();
        List<int> courseUnits = new List<int>();
        List<double> courseScores = new List<double>();
        public void GetInput()
        {

            Console.Write("Enter Number of Courses: ");
            int n =int.Parse( Console.ReadLine());

            int i = 1;
            while(n > 0)
            {
                Console.Write($"Enter Course Code {i}: ");
                string code = Console.ReadLine();
                courseNames.Add(code);
                Console.Write($"Enter Course Unit {i}: ");
                int unit = int.Parse(Console.ReadLine());
                courseUnits.Add(unit);
                Console.Write($"Enter Course Score {i}: ");
                int score = int.Parse(Console.ReadLine());
                courseScores.Add(score);
                Console.WriteLine("");
                n--;
                i++;
            }
            calculation.CalculateGP(courseNames, courseUnits, courseScores);
        }
    }
}

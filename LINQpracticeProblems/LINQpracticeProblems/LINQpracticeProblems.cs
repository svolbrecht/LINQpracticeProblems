using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQpracticeProblems
{
    class LINQpracticeProblems
    {

        // 1.Using LINQ, write a function that determines if any word in a list contains the substring “th”.
        public static void IdentifyThWords()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var thWords = words.Where (w => w.Contains("th"));

                foreach(var word in thWords)
                {
                    Console.WriteLine(word);
                }
        }



        // 2.Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
        public static void RemoveDuplicateStrings()
        {

            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };

            var noDuplicates = names.Distinct();

            foreach(var name in noDuplicates)
            {
                Console.WriteLine(name);
            }

        }



        //      3.Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
        //  The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest grade from each string, 
        //  averages the rest of the grades from that string, then averages the averages.
        public static void CalculateGradeAverage()
        {
                List<string> classGrades = new List<string>()
                {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                };

            var averagedGradesWithoutLowestGrade = classGrades.Average(c => c.Split(',').Where(s => s != c.Split(',').Min()).Select(x => int.Parse(x)).Average());


        }


        //      4.Write a function that takes in a string of letters(i.e. “Terrill”) and returns an alphabetically ordered string corresponding
        //   to the letter frequency(i.e. "E1I1L2R2T1")


        public static void ConvertString()
        {
            string terrill = "Terrill";
            

            var newTerrill = terrill.GroupBy(x => x).Select(x => new Terrill(x.Key, x.Count()));

        } 


    }
}

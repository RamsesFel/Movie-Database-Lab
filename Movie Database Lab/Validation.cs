using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    public class Validation
    {
        public static string GetInput(List<string> genres,List<int> genrenum,out string result)
        {
            while (true)
            {
                result = Console.ReadLine().ToLower().Trim();
                int resultnum = 0;

                if (genres.Contains(result))
                {
                    return result;
                }
                else if (int.TryParse(result, out resultnum) && resultnum >=1 && resultnum <=4)
                {
                    if (resultnum == 1)
                    {
                        result = "scifi";
                    }
                    if (resultnum == 2)
                    {
                        result = "animated";
                    }
                    if (resultnum == 3)
                    {
                        result = "horror";
                    }
                    if (resultnum == 4)
                    {
                        result = "drama";
                    }
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input, please choose a category from our selection.");
                }
            }
        }
        public static bool GetInput(string input)
        {
            while (true)
            {
                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                    input = Console.ReadLine();
                }
            }
        }
    }
}

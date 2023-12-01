using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AdventCalender2023
{
    internal class December_1
    {
        public static string fileName = "D1.txt";
        public StreamReader reader = File.OpenText(fileName);
        public int Part1()
        {
            List<int> values = new();
            string? line;
            string pattern = @"(\d)";
            while ((line = reader.ReadLine()) != null)
            {
                values.Add(int.Parse(Regex.Match(line, pattern).Groups[1].Value +
                                     Regex.Match(string.Concat(line.Reverse()), pattern).Groups[1].Value));
            }
            Console.WriteLine(values.Sum());
            return values.Sum();
        }

        public int Part2()
        {
            List<int> values = new();
            string? line;
            string forwardLine = @"(\d|one|two|three|four|five|six|seven|eight|nine)";
            string backwardsLine = @"(\d|eno|owt|eerht|ruof|evif|xis|neves|thgie|enin)";
            while((line = reader.ReadLine()) != null)
            {
                string first = ParseNum(Regex.Match(line, forwardLine).Groups[1].Value);
                string last = ParseNum(Regex.Match(string.Concat(line.Reverse()), backwardsLine).Groups[1].Value);
                values.Add(int.Parse(first + last));
            }
            Console.WriteLine(values.Sum());
            return values.Sum();
        }

        public static string ParseNum(in string num) => num switch
        {
            "one" => "1",
            "two" => "2",
            "three" => "3",
            "four" => "4",
            "five" => "5",
            "six" => "6",
            "seven" => "7",
            "eight" => "8",
            "nine" => "9",
            "eno" => "1",
            "owt" => "2",
            "eerht" => "3",
            "ruof" => "4",
            "evif" => "5",
            "xis" => "6",
            "neves" => "7",
            "thgie" => "8",
            "enin" => "9",
            _ => num
        };
    }
}

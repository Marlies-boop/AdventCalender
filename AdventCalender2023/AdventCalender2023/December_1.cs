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
        //wat moet je kunnen doen:
        //- input invoeren
        //- eerste en laatse nummer uit elke lijn halen(array)
        //- verschil weten tussen lijnen
        //- als er 1 nummer in een lijn zit moet hij hem dubbel op tellen
        //- alle nummers van de lijnen bij elkaar op tellen en terug geven(in een array opslaan en dan bij elkaar optellen)
        //- letters negeren(af)

        /*public static string test = "5ffour295";
        public string input = new String(test.Where(char.IsDigit).ToArray());
        public List<string> Text;
        public static string fileName = "D1.txt";
        public StreamWriter writer = File.CreateText(fileName);
        public StreamReader reader = File.OpenText(fileName);


        //maak een methode waar je de tekst kan invoeren.
        public void Input()
        {
            Console.WriteLine(input);
            int inputnumber = Convert.ToInt32(input);
            Console.WriteLine(FirstNumber(inputnumber) + "" + LastNumber(inputnumber));

            if (File.Exists(fileName))
            {
                StreamReader reader = File.OpenText(fileName);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine("This will now read the contents of the file: " + fileName);
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }

        public int FirstNumber(int inputnumber)
        {
            while (inputnumber >= 10)
            {
                inputnumber /= 10;
            }

            return inputnumber;
        }

        public int LastNumber(int inputnumber)
        {
            return (inputnumber % 10);
        }*/

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
    }
}

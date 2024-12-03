namespace AdventCalender_2024;

public class Day_1
{
    public static string fileName = "D1.txt";
    public StreamReader reader = File.OpenText(fileName);
    
    List<int> list1 = new List<int>();
    List<int> list2 = new List<int>();
    
    public void Part1()
    {
        //Console.WriteLine(reader.ReadToEnd());
        //make 2 lists from the text file
        foreach (var line in reader.ReadToEnd().Split('\n'))
        {
            //Console.WriteLine(line);
            int value = Convert.ToInt32(line);
            Console.WriteLine(value);
        }
        //search for lowest from each list and calculate the difference
        //save all distances in a new list and add them to get the answer
    }

    public void Part2()
    {
        
    }
}
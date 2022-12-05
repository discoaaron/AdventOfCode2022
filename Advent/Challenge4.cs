public static class Challenge4
{
    public static void Process2()
    {
        var filePath = ".\\data\\challenge4.txt";

        using var streamReader = new StreamReader(filePath);
        string line;

        int counter = 0;

        while ((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine("Input: " + line);
            string[] strings = line.Split(",");

            var one = strings[0].Split("-");
            var elf1 = new elf
            {
                low = Convert.ToInt16(one[0]),
                high = Convert.ToInt16(one[1]),
            };

            var two = strings[1].Split("-");
            var elf2 = new elf
            {
                low = Convert.ToInt16(two[0]),
                high = Convert.ToInt16(two[1]),
            };

            if ((elf1.low <= elf2.low && elf2.low <= elf1.high) || 
                (elf2.low <= elf1.low && elf1.low <=elf2.high))
            {

                Console.WriteLine("Elves are contained!");
                counter++;
            }

            else
            {
                Console.WriteLine("No containment");
            }
        }
        Console.WriteLine(counter);
    }

    public static void Process()
    {
        var filePath = ".\\data\\challenge4.txt";

        using var streamReader = new StreamReader(filePath);
        string line;

        int counter = 0;

        while ((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine("Input: " + line);
            string[] strings = line.Split(",");

            var one = strings[0].Split("-");
            var elf1 = new elf
            {
                low = Convert.ToInt16(one[0]),
                high = Convert.ToInt16(one[1]),
            };

            var two = strings[1].Split("-");
            var elf2 = new elf
            {
                low = Convert.ToInt16(two[0]),
                high = Convert.ToInt16(two[1]),
            };

            if (
                (elf1.low <= elf2.low && elf1.high >= elf2.high) ||
                (elf2.low <= elf1.low && elf2.high >= elf1.high))
            {

                Console.WriteLine("Elves are contained!");
                counter++;
            }

            else
            {
                Console.WriteLine("No containment");
            }
        }
        Console.WriteLine(counter);
    }

}

public class elf{
    public int high;
    public int low;
}


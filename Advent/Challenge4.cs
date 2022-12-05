public static class Challenge4
{


    public static void Process()
    {
        var filePath = ".\\data\\challenge4.txt";

        using var streamReader = new StreamReader(filePath);
        string line;

        while ((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }

}


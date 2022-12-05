public static class Challenge3
{

    public static void Process2()
    {
        var filePath = "C:\\Users\\aaron.small\\OneDrive - Datacom\\Desktop\\advent\\challenge3.txt";

        using var streamReader = new StreamReader(filePath);
        var lines = File.ReadAllLines(filePath);
        
        
        var currentGroup = new List<string>();
        var results = new List<char>();
        foreach (var backpack in lines)
        {
            currentGroup.Add(backpack);
            if(currentGroup.Count == 3)
            {
                results.Add(FindMatch(currentGroup));
                currentGroup.Clear();
            }
        }

        var result = results.Sum(x => GetCharValue(x));

        Console.WriteLine(result);



        string line;
        var total = 0;
        var itemsInBoth = new List<char>();


    }

    public static char FindMatch(IList<string> currentGroup)
    {
        char badge = new char();
        bool found = false;
        foreach (var one in currentGroup[0])
        {
            foreach (var two in currentGroup[1])
            {
                foreach (var three in currentGroup[2])
                {
                    if (one == two && two == three)
                    {
                        Console.WriteLine($"Comparing {one}, {two}, {three}");
                        badge = one;
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
            if (found) break;
        }
        Console.WriteLine($"Returning {badge}");
        return badge;
    }


    public static void Process()
    {
        var filePath = "C:\\Users\\aaron.small\\OneDrive - Datacom\\Desktop\\advent\\challenge3.txt";

        using var streamReader = new StreamReader(filePath);

        string line;
        var total = 0;
        var itemsInBoth = new List<char>();

        while ((line = streamReader.ReadLine()) != null)
        {
            var halfwayIndex = (line.Length / 2);
            var pocket1 = line.Substring(0, halfwayIndex);
            var pocket2 = line.Substring(halfwayIndex);


            char? itemInBoth = null;
            foreach (char item in pocket1)
            {   
                foreach (char item2 in pocket2)
                {
                    if (item == item2)
                    {
                        itemInBoth = item;
                        break;
                    }
                }
                if(itemInBoth != null) break;
            }
            
            if(itemInBoth != null)
            {
                itemsInBoth.Add((char)itemInBoth);
            }else {
                Console.WriteLine($"Noshared item in line: {line}");
                Console.WriteLine($"{pocket1} - {pocket2}");
            }
        }

        itemsInBoth.ForEach(x => {
            int value = x - '0';
            if (char.IsUpper(x))
            {
                value += 10;
            }
            else
            {
                value -= 48;
            }
            total += value;
            Console.WriteLine($"letter: {x} = {value}");
        }
        );
        Console.WriteLine($"TOTAL: {total}");
    }

    private static int GetCharValue(char badge)
    {
        int value = badge - '0';
        if (char.IsUpper(badge))
        {
            value += 10;
        }
        else
        {
            value -= 48;
        }
        return value;
    }
}


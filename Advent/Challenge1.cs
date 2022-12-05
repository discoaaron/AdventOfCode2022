using System.Text.RegularExpressions;

public static class Challenge1
{
    public static IList<int> GetTotals()
    {
        var totals = new List<int>();
        int currentChampion = 0;
        
        var filePath = "C:\\Users\\aaron.small\\OneDrive - Datacom\\Desktop\\advent\\challenge1.txt";

        int total = 0;
        using var streamReader = new StreamReader(filePath);
        string line;

        while ((line = streamReader.ReadLine()) != null)
        {
            if (line != string.Empty)
            {
                total += Convert.ToInt32(line);
            }
            else
            {
                // old aaron
                totals.Add(total);
                
                // new
                currentChampion = total > currentChampion ? total : currentChampion;


                total = 0;
            }
        }

        // handle the final 
        totals.Add(total);


        totals.ForEach(x => Console.WriteLine(x));
        Console.WriteLine("CHAMP IS: " + currentChampion);

        return totals;






        ///return File.R("C:\\Users\\aaron.small\\OneDrive - Datacom\\Desktop\\advent\\challenge1.txt");
    }

    public static void FindTotalOfTopThree(IList<int> totals)
    {
        var orderedTotals = totals.OrderByDescending(x => x).ToList();
        Console.WriteLine(orderedTotals[0] + orderedTotals[1] + orderedTotals[2]);
    }



    public static void Parse(string data)
    {
        var regex = new Regex("\n\n");
        var list = regex.Split(data);
        Console.WriteLine(list.Length);

        foreach (var item in list)
        {
            Console.WriteLine(item);
            Console.WriteLine('-');
        }
        //data.Split([Environment.NewLine, Environment.NewLine]);
    }
}


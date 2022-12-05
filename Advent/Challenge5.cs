public static class Challenge5
{
    public static void Process()
    {
        var filePath = ".\\data\\challenge5.txt"; // I manually transformed this data
        var crates = File.ReadAllLines(filePath).ToList();

        var filePath2 = ".\\data\\challenge5-moves.txt";
        var moves = File.ReadAllLines(filePath2).ToList();



        foreach (var move in moves)
        {
            var movesList = move.Split(' ');


            //movesList.ToList().ForEach(x => Console.WriteLine(x));

            var fromStack = Convert.ToInt32(movesList[3]) - 1;
            var toStack = Convert.ToInt32(movesList[5]) - 1;
            var count = Convert.ToInt32(movesList[1]);

            //Console.WriteLine($"From: {fromIndex}");
            //Console.WriteLine($"To: {toIndex}");
            //Console.WriteLine($"Count: {count}");

            crates[fromStack].ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();
            crates[toStack].ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();

            var indexOfItemsToRemove = crates[fromStack].Length - count;

            var itemsToMove = crates[fromStack].Substring(indexOfItemsToRemove);

            crates[toStack] += string.Join("", itemsToMove);

            //crates[toStack] += string.Join("", itemsToMove.Reverse());

            var itemsToKeep = crates[fromStack].Substring(0, indexOfItemsToRemove);
            crates[fromStack] = itemsToKeep;


            //AFTER
            crates[fromStack].ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();
            crates[toStack].ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();
        }

        Console.WriteLine("DONE!");
        crates.ToList().ForEach(x => Console.WriteLine(x));

    }
}
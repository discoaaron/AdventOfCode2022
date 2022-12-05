using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class Challenge2
{

    public static void Read()
    {
        var filePath = "C:\\Users\\aaron.small\\OneDrive - Datacom\\Desktop\\advent\\challenge2.txt";

        using var streamReader = new StreamReader(filePath);

        string line;
        var totalScore = 0;
        while ((line = streamReader.ReadLine()) != null)
        {
            // Part 1
            //totalScore = Part1(line, totalScore);

            //  Part 2
            totalScore = Part2(line, totalScore);
        }
        Console.WriteLine(totalScore);
    }

    private static int Part2(string line, int totalScore)
    {
        var input = line.Split(" ");
        var roundScore = Resolve2(Tuple.Create(input[0], input[1]));

        totalScore += roundScore;
        Console.WriteLine($"input: {input[0]} {input[1]} - score: {totalScore}");
        return totalScore;
    }

    private static int Resolve2(Tuple<string, string> tuple)
    {
        int roundScore = GetRoundScore(tuple.Item2);

        int handScore = GetHandScore(tuple);

        return roundScore + handScore;
    }

    private static int GetHandScore(Tuple<string, string> tuple)
    {
        string theirHand = GetHand(tuple.Item1);
        string target = GetTarget(tuple.Item2);
        if (theirHand == "rock" && target == "win" || 
            theirHand == "scissors" && target == "loss" ||
            theirHand == "paper" && target == "draw")
        {
            // paper
            return 2;
        }else if (theirHand == "paper" && target == "win" ||
            theirHand == "rock" && target == "loss" ||
            theirHand == "scissors" && target == "draw")
        {
            // scissors
            return 3;
        }else if (theirHand == "scissors" && target == "win" ||
            theirHand == "paper" && target == "loss" ||
            theirHand == "rock" && target == "draw")
        {
            // rock
            return 1;
        }
        throw new Exception("yo fucked up");
    }

    private static string GetTarget(string input)
    {
        switch (input)
        {
            case "X":
                return "loss";
            case "Y":
                return "draw";
            case "Z":
                return "win";
            default:
                return "";
        }
    }

    private static int GetRoundScore(string input)
    {
        if (input == "X")
        {
            return 0;
        }else if (input == "Y") 
        {
            return 3;
        }else if (input == "Z")
        {
            return 6;
        }else
        {
            throw new Exception("Invalid end condition");
        }
    }

    public static int Part1(string line, int totalScore)
    {
        var input = line.Split(" ");
        var roundScore = Resolve(Tuple.Create(input[0], input[1]));
        totalScore += roundScore;
        Console.WriteLine($"input: {input[0]} {input[1]} - score: {totalScore}");
        return totalScore;
    }







    public static int Resolve(Tuple<string, string> input)
    {
        return GetBaseScore(input) + GetResult(input);
    }

    private static int GetResult(Tuple<string, string> input)
    {
        var theirHand = GetHand(input.Item1);
        var myHand = GetHand(input.Item2);
        if (theirHand == myHand)
        {
            Console.WriteLine("Draw - 3 points");
            return 3;
        } else if (theirHand == "paper" && myHand == "rock" ||
                   theirHand == "scissors" && myHand == "paper" ||
                   theirHand == "rock" && myHand == "scissors")
        {
            Console.WriteLine("Elf wins - 0 points");
            return 0;
        }else if (myHand == "paper" && theirHand == "rock" ||
                   myHand == "scissors" && theirHand == "paper" ||
                   myHand == "rock" && theirHand == "scissors")
        {
            Console.WriteLine("I wins - 6 points");
            return 6;
        }
       throw new Exception("invalid result");
    }

    private static string GetHand(string input)
    {
        switch (input)
        {
            case "X":
            case "A":
                return "rock";
            case "Y":
            case "B":
                return "paper";
            case "Z":
            case "C":
                return "scissors";
            default:
                return "";
        }
    }

    private static int GetBaseScore(Tuple<string, string> input)
    {
        switch (input.Item2)
        {
            case "X":
                return 1;
            case "Y":
                return 2;
            case "Z":
                return 3;
            default:
                return 0;
        }
    }
}




using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var leftList = new List<long>();
        var rightList = new List<long>();
        foreach (var line in File.ReadLines(leftList.csv))
        {
            var parts = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2)
            {
                if (long.TryParse(parts[0], out long leftVal) &&
                    long.TryParse(parts[1], out long rightVal))
                {
                    leftList.Add(leftVal);
                    rightList.Add(rightVal);
                }
            }
        }
        leftList.Sort();
        rightList.Sort();

        long totalDistance = 0;
        for (int i = 0; i < leftList.Count && i < rightList.Count; i++)
        {
            totalDistance += Math.Abs(leftList[i] - rightList[i]);
        }
        Console.WriteLine(totalDistance);
    }
}
 

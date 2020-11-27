// The program reads a set of marks until the user enters "end", then calculates the average.

using System;

public class Average {
    public static void Main() {
        double sum = 0, mark, count = 0, average;
        string userInput;

        Console.Write("Insert a mark: ");
        userInput = Console.ReadLine();

        while (userInput != "end") {
            mark = Convert.ToDouble(userInput);
            count++;
            sum += mark;
            Console.Write("Insert a mark: ");
            userInput = Console.ReadLine();
        }

        if (count != 0) {
	        average = sum / count;
            Console.WriteLine("The average is {0}.", average);
        }
    }
}

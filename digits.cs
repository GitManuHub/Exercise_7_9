// The program asks the user to enter numbers until they enter "end",
// then shows the amount of numbers of each type according to the
// number of digits it has.

using System;

class digits {

    static void Main() {
    
        int oneDigitCounter = 0, twoDigitsCounter = 0, threeDigitsCounter = 0, moreDigitsCounter = 0;
        
        Console.Write("Insert a number: ");
        string userInput = Console.ReadLine();
        
        while(userInput != "end") {
            int enteredNumber = Convert.ToInt32(userInput);
            
            if (enteredNumber != 0) {
                if (enteredNumber / 10 == 0)
                oneDigitCounter++;
                else if (enteredNumber / 100 == 0)
	            twoDigitsCounter++;
                else if (enteredNumber / 1000 == 0)
                threeDigitsCounter++;
                else
                moreDigitsCounter++;
            }
            Console.WriteLine("Insert a number: ");
            userInput = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigitCounter, twoDigitsCounter,
        threeDigitsCounter, moreDigitsCounter);
    }
}


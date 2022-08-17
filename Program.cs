// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome To MasterMind! Please enter a 4 Digit number with each digit between 1-6! You will have 10 guess to get my number!");

var random = new Random();
var gameWon = false;

//We will store in array to easily compare the position of each int entered to correct answer position
var correctAnswer = new List<string>();

//This will fill our array with the auto generated 4 number
for(int i = 0; i < 4; i++)
{
    correctAnswer.Add(random.Next(1, 6).ToString());
}

for(int i = 0; i < 10; i++)
{
    var input = Console.ReadLine();
    
    if(input == null || input.Length != 4)
    {
        //This will check if they enter an null or too many/not enough characters
        Console.WriteLine("Please enter a valid 4 digit number!");
        //We will subtract 1 from i so that a player will not lose a turn for invalid input
        i -= 1;
        continue;
    }

    string printCorrect = "";
    var currentChar = 0;

    foreach(var number in input)
    {
        if (number.ToString() == correctAnswer[currentChar])
        {
            printCorrect += "+";
        }
        else if (correctAnswer.Contains(number.ToString()) == true)
        {
            printCorrect += "-";
        }
        else
        {
            printCorrect += " ";
        }

        currentChar++;
    }

    if(printCorrect == "++++")
    {
        Console.WriteLine("YOU HAVE GUESSED THE CORRECT NUMBER!");
        gameWon = true;
        break;
    }

    Console.WriteLine(printCorrect);
}

if(!gameWon) 
{
   Console.WriteLine("You have failed to guess in 10 tries! Game Over");
}

//declare variables
int number;
int reversed;
int reversedNumber = 0;
bool playAgain = true;
bool validNumber;
bool validDigits;
int countNum = 0;

Console.WriteLine("Let's play a game where you type in a 4 digit number and I reverse that number for you!");

while (playAgain)
{
    //output asking user to enter a four digit number
    Console.WriteLine("Please enter a four digit number to see it reversed");
    validNumber = false;

    while (!validNumber)
    {
        validDigits = int.TryParse(Console.ReadLine(), out number);
        for (int i = 0; i <= 3; i++)
        {
            countNum++;
        }

        if (!validDigits || countNum <= 3)
        {
            Console.WriteLine("Please type in a valid number containing whole numbers. Must be 4 digits.");
        }
        else
        {
            validDigits = true;
            validNumber = true;
        }
        ReversedNumber();
    }

 
    //Establish a Function that we are setting to void
    void ReversedNumber()

    {
        //create a do while loop inside of my function
        do

        {
            //here i am initialzing another variable named reversed and setting it equal to the value of number divided by 10 and getting the remainder using the modulus operator.
            reversed = number % 10;
            number = number / 10;
            reversedNumber = (reversedNumber * 10) + reversed;
            Console.Write(reversed);


        }
        //loop will repeat as long as number is greater than zero, if number is not greater than zero, will exit loop
        while (number > 0);

    }

    //calling our funtion. without calling our function our code will not run.
   


}

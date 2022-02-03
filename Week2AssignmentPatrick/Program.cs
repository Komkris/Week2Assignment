using System;

class Program
{
    static void Main(string[] args)
    {
        //initialize variables

        int myVar = 7; //variable that will determine the answers

        //variables to hold answers
        int questionOne = 0;
        int questionTwo = 0;
        int questionThree = 0;
        int questionFour = 0;

        //process answers
        questionOne = (-1 + 4 * myVar);
        questionTwo = (35 + 5) % myVar;
        questionThree = (14 + -4 * 6 / 12);
        questionFour = (2 + 12 / 6 * 1 - myVar % 2);

        //output answers to user
        Console.WriteLine(questionOne);
        Console.WriteLine(questionTwo);
        Console.WriteLine(questionThree);
        Console.WriteLine(questionFour);
        
        if((myVar*myVar) > 10)
        {
            Console.WriteLine("myVar is greater than 4");
        }
        else
        {
            Console.WriteLine("myVar is less than 4");
        }


        //end of program
    }
}
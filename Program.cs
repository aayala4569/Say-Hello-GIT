//Angelica Ayala
//Date Revised:10/20/22
//Mini Challenge #1- "Say Hello"
//-------Description-----------------
//I created a string with a variable. 
//I then output the question "What is your name?". 
//Then I created variable with user input using Console.ReadLine. 
//Once provider inputs name, the response "Hello (user name)" will appear.

//Peer Reviewed by;
//Date:"
//Review:
string name;
bool playAgain = true;
bool validResponse = true;
string userAnswer;

while(playAgain == true)
{

 Console.WriteLine("What is your name?");

 name = Console.ReadLine();

 Console.WriteLine($"Hello {name}.");

 validResponse = true;

 while(validResponse == true)
        {
            Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again
            userAnswer = Console.ReadLine().ToUpper();
            

            if(userAnswer == "Y")
            {
                playAgain = true;
                validResponse = false;
            }
            else if(userAnswer == "N")
            {
                playAgain = false;
                validResponse = false;
            }
            else
            {   
                playAgain = false;
                validResponse = true;
                Console.WriteLine(userAnswer + " isn't a valid response. Please Enter an actual valid response please.");


            }


        }
    
        Console.WriteLine("Thanks for playing!");
}


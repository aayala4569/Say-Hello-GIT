//Angelica Ayala
//Date Revised:10/20/22
//Mini Challenge #1- "Say Hello"
//-------Description-----------------
//I created a string with a variable. 
//I then output the question "What is your name?". 
//Then I created variable with user input using Console.ReadLine. 
//Once provider inputs name, the response "Hello (user name)" will appear.


string name;

Console.WriteLine("What is your name?");

name = Console.ReadLine();

Console.WriteLine($"Hello {name}.");

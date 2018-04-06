using System;
using System.Numerics;

namespace unicamFattoriale
{

    class unicamFattoriale
    {
        static void Main(string[] args)
        {
            //Print some helpful messages to the user, so he will know what he should do
            
            
            Console.WriteLine("This program calculates the factorial of a number");
            
            Console.WriteLine("Press any keys to continue or Esc to exit: ");
            //If you will press the Esc button the program will stop immediately.
            //The while doesn't let the program to stop after every execution
            while(Console.ReadKey().Key != ConsoleKey.Escape){
                
            Console.Write("Type a number then press Enter.");

            
            //By using Console.ReadLine, we wait for the user until he types something and presses Enter.
            //When he/she's pressed enter, the text he/she typed will be assigned to a string variable
            string testoDigitatoDallUtente = Console.ReadLine();

            //Let's convert the text to an integer; using the uint type the user is not able to type negative numbers.
            //The try-catch block is needed to handle the exception for an invalid input.
            try{
            uint numero = uint.Parse(testoDigitatoDallUtente);
          
            BigInteger risultato=1;
            while (numero > 1) {
                risultato *= numero;
                numero--;
            }
            //The factorial for 0 number is 1
            if(numero==0){
                risultato=1;
            }
           
            //Print the result
            Console.WriteLine($"The factorial of {testoDigitatoDallUtente} is {risultato}");

            //This message will show itself after every execution.
            Console.WriteLine("Press any keys to continue or Esc to exit: ");
           
            //If the input is invalid the program will exit.
            }catch{
                Console.WriteLine("Sorry, the input is invalid!!");
                  Console.ReadKey();
                return;
            }
            }

           
        }
}
}
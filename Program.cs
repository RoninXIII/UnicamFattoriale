using System;

namespace UnicamFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stampo dei messaggi di cortesia per l'utente, così lo guido all'utilizzo del programma
            //Print some helpful messages to the user, so he will know what he should do
            
            //This program calculates the factorial of a number
            Console.WriteLine("Questo programma calcola il fattoriale di un numero");
            //Type a number then press Enter
            Console.Write("Digita un numero e premi invio: ");

            //Console.ReadLine si mette in attesa che l'utente digiti qualcosa e prema invio.
            //Quando ha premuto invio, il testo che ha digitato lo assegno ad una variabile di tipo string.
            
            //By using Console.ReadLine, we wait for the user until he types something and presses Enter.
            //When he/she's pressed enter, the text he/she typed will be assigned to a string variable
            string testoDigitatoDallUtente = Console.ReadLine();

            //Interpreto il testo come un numero intero
            //Attenzione: questa istruzione fallirà se l'utente ha digitato un testo
            //che non è interpretabile come un numero! (Es. ABCD)
            
            //Let's convert the text to an integer
            //Beware: this instruction will fail if the user has input a text
            //which is not convertible to a number! (e.g. ABCD)
            int numero = int.Parse(testoDigitatoDallUtente);

            //Calcolo il fattoriale: qui ci sono degli errori!
            //Factorial calculation: this is currently wrong!
            int risultato = 0;
            while (numero >= 0) {
                risultato *= numero;
                numero--;
            }

            //Stampo il risultato
            //Print the result
            Console.WriteLine($"Il fattoriale di {numero} e' {risultato}");
            //Attendo che l'utente prema un tasto prima di uscire
            //Let's wait for another Enter, or the program would close and we wouldn't see its output
            Console.ReadKey();
        }
    }
}

# UnicamFattoriale
Questo programma chiede all'utente di digitare un numero per calcolare il suo [fattoriale](https://it.wikipedia.org/wiki/Fattoriale).

## Comportamento desiderato (specifica del programma)
 1. All'utente dev'essere chiesto di digitare un numero intero;
 2. Se l'utente non digita un numero intero o se digita un numero intero troppo grande, il programma non deve andare in errore ma deve mostrare il messaggio "Spiacente, non posso calcolare il fattoriale per questo valore";
 3. Se l'utente ha digitato un numero intero valido, allora il programma mostrerà il messaggio "Il fattoriale di `numero` è `risultato`", dove le parole "fattoriale" e "risultato" vanno ovviamente sostituite con i numeri in questione;
 4. Il risultato del calcolo fattoriale deve essere corretto;
 5. Per convenzione, il fattoriale di 0 è 1. Il programma deve gestire questo caso;
 6. *Nice-to-have*: dopo il calcolo, il programma non deve uscire ma chiedere all'utente di inserire un altro numero, finché non inserisce un testo non valido. *Nota: le funzionalità cosiddette "nice-to-have" NON sono essenziali al corretto funzionamento del programma ma migliorano l'esperienza di utilizzo dell'utente.*

 ## Email da Bob (il cliente) a proposito del funzionamento attuale del programma
Ciao,
senti, ho provato ad usare il programma ma ancora non va bene. Ti segnalo queste difformità dalla specifica che avevamo concordato insieme.
* Il punto 1 della specifica chiede di inserire un "numero intero" ma il programma mi dice di inserire un "numero" e basta. Bisognerebbe correggerlo per maggiore chiarezza;
* Ho degli errori sia digitando un testo a caso che digitando un numero grande;
* Se digito un numero qualsiasi, il programma mi dice sempre "Il fattoriale di -1 è 0". Che roba è?
* Ogni volta che digito un numero, poi sono costretto a riaprire il programma per digitarne un altro ma... vabbé, avevamo detto che questa cosa l'avremmo vista in seguito.

Fammi sapere.


# UnicamFattoriale
This program asks the user to input a number so it can print its [factorial](https://en.wikipedia.org/wiki/Factorial).

## Desired behavior (program specifics)
 1. The user must be asked to input an integer number;
 2. The program should not throw exceptions even if the user inputs a large number (take a look at the [BigInteger](https://msdn.microsoft.com/it-it/library/system.numerics.biginteger(v=vs.110).aspx) type instead of int). When the user inputs a non-numerical value, than the program should print "Your input was not correct, please type an integer number again";
 3. If the user inputs a correct value, then the program should print "The factorial of the number `number` is `result`";
 4. The result must be correct;
 5. By convention, the factorial of 0 is 1. The program must handle this case;
 6. *Nice-to-have*: after the calculation, the program should ask the user to input another number, until he provides an invalid input. *Notice: features labeled as "nice-to-have" ARE NOT essential but they improve the user experience*

 ## Email from Bob (the client) about the current state of this program
Hey,
listen, I tried using the program but it's still not working correctly. Here's the shortcomings.
* Whenever I type some random text or a large number, the application gives an error;
* If I type any numner, the program prints "The factorial of -1 us 0". Why is that?
* Whenever I type a number, then I have to close and reopen the application... however, I know we said this problem would be solved later.

Let me know when it's working.

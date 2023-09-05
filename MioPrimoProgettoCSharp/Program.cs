// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Come ti chiami?"); // visualizza in console del testo

var nome = Console.ReadLine(); // chiede all'utente di inserire un testo e lo salvo dentro una variabile di tipo var

Console.WriteLine("Benvenuto " +  nome + ", piacere di conoscerti!"); // visualizza in console del testo concatenato al contenuto di una variabile

int[] numeriEstratti = { 5, 10, 18, 90, 83, 47 }; // dichiaro un array di numeri interi

Console.WriteLine("I numeri della lotteria estratti sono: ");

for (int i = 0; i < numeriEstratti.Length; i++) // ciclo la mia array di numeri interi grazie al ciclo for
{
    Console.Write(numeriEstratti[i]); // con Write da solo non va a capo

    if (numeriEstratti[i] % 2 == 0) // imposto una condizione di controllo, se il numero è modulo di 2 è un numero pari altrimenti è dispari
    {
        Console.WriteLine(" - pari"); // con WriteLine da solo va a capo
    } else
    {
        Console.WriteLine(" - dispari");// con WriteLine da solo va a capo
    }
}

Console.WriteLine("Alla prossima giocata!");


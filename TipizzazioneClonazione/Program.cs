// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// visualizza in console del testo
Console.WriteLine("Come ti chiami?");
// chiede all'utente di inserire un testo quindi lo dichiara come string
string nome = Console.ReadLine();
// visualizza in console del testo concatenato tramite template literal
Console.WriteLine($"Benvenuto {nome} piacere di conoscerti!");
// chiedo all'utente quanti numeri vincenti vuole inserire
Console.Write("Dimmi quanti numeri vincenti vuoi inserire: ");
// salvo il numero scritto dall'utente dentro una variabile di tipo int
int quantitaNumeriVincenti = Convert.ToInt32(Console.ReadLine()); // oppure int.Parse(Console.ReadLine())
// definisco un array di numeri interi della dimensione della variabile precedentemente salvata
int[] numeriVincenti = new int[quantitaNumeriVincenti];
//faccio inserire all'utente i numeri uno ad uno e li salvo nell'array precedentemente dichiarata
for (int i = 0; i < numeriVincenti.Length; i++)
{
    Console.Write($"Inserisci il {i + 1} numero: ");
    numeriVincenti[i] = Convert.ToInt32(Console.ReadLine()); // oppure int.Parse(Console.ReadLine())
}
//clono l'array dei numeri estratti
int[] numeriVincentiOriginali = (int[])numeriVincenti.Clone();

// sommo 1 a tutti i numeri vincenti
for (int i = 0; i < numeriVincenti.Length; i++)
{
    numeriVincenti[i] = numeriVincenti[i] + 1;
}
// mostro i numeri estratti sommati di 1 e se sono pari o dispari
Console.WriteLine("I numeri della lotteria estratti sommati di 1 sono: ");

for (int i = 0; i < numeriVincenti.Length; i++)
{
    Console.Write(numeriVincenti[i]); // con Write da solo non va a capo

    if (numeriVincenti[i] % 2 == 0)
    {
        Console.WriteLine(" - pari"); // con WriteLine da solo va a capo
    }
    else
    {
        Console.WriteLine(" - dispari");// con WriteLine da solo va a capo
    }
}
// mostro i numeri estratti e se sono pari o dispari
Console.WriteLine("I numeri della lotteria originali estratti sono: ");

for (int i = 0; i < numeriVincentiOriginali.Length; i++)
{
    Console.Write(numeriVincentiOriginali[i]); // con Write da solo non va a capo

    if (numeriVincentiOriginali[i] % 2 == 0)
    {
        Console.WriteLine(" - pari"); // con WriteLine da solo va a capo
    }
    else
    {
        Console.WriteLine(" - dispari");// con WriteLine da solo va a capo
    }
}

Console.WriteLine("Alla prossima giocata!");

Console.WriteLine(Environment.NewLine);
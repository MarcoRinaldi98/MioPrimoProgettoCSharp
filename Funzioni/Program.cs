/*
 * //funzione per sommare due numeri
int SommaNumeri(int a, int b) // ritorna un numero intero(int)
{
    int somma = a + b;
    return somma;
}

Console.WriteLine(SommaNumeri(1, 2));

//funzione usata solo per stampare del testo
void FunzioneCheNonRitornaNulla() // le funzione indicate con void non ritornano nulla
{
    Console.WriteLine("Ciao a tutti!");
}
FunzioneCheNonRitornaNulla();


int[] numeri = {1,2,3,4,5};

//funzione per calcolare la somma degli elementi di un array
int SommaElementiArray(int[] numeri)
{
    int sommaElementi = 0;
    for (int i = 0; i < numeri.Length; i++)
    {
        sommaElementi += numeri[i];
    }
    return sommaElementi;
}
//funzione per calcolare la media degli elementi di un array
double CalcolaMediaArray(int[] numeri)
{
    int sommaArray = SommaElementiArray(numeri);
    double media = (double)sommaArray / numeri.Length;
    return media;
}
Console.WriteLine($"La somma di tutti gli elementi dell'array è {SommaElementiArray(numeri)}");
Console.WriteLine($"La media di tutti gli elementi dell'array è {CalcolaMediaArray(numeri)}");

// funzione per stampare un array correttamente a schermo con ogni elemento diviso da virgola
int[] numeriInteri = {10, 20, 30, 40, 50, 60};
void StampaArray(int[] array)
{
    Console.WriteLine($"Array di numeri interi: [{string.Join(", ", array)}]"); // join serve per concatenare gli elementi di un array
}
StampaArray(numeriInteri);

// funzione che moltiplica due numeri
Console.WriteLine("Inserisci il numero da moltiplicare:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il moltiplicatore da moltiplicare:");
int mult = int.Parse(Console.ReadLine());

int originalN = n;

MultiplyNumberRef(ref n, mult);
int result = MultiplyNumberValue(n, mult);

Console.WriteLine($"{originalN} x {mult} = {result}");

void MultiplyNumberRef(ref int number, int multiplier)
{
    number = number * multiplier;
}

int MultiplyNumberValue(int number, int multiplier)
{
    int result = number * multiplier;
    return result;
}
*/

bool IsTwoWordIdenticalLength(string word1, string word2)
{
    return word1.Length == word2.Length;
}

string ReturnLongerWord(string word1, string word2)
{
    if (word1.Length > word2.Length)
    {
        return word1;
    } else if (word1.Length < word2.Length) 
    { 
        return word2;
    } else
    {
        return "";
    }
}

void PrintLongerOrBothWord(string word1, string word2)
{
    bool isEqualLength = IsTwoWordIdenticalLength(word1, word2);    
    if (isEqualLength)
    {
        Console.WriteLine($"{word1} {word2}");
    } else
    {
        Console.WriteLine(ReturnLongerWord(word1, word2));
    }
}

Console.WriteLine("Inserisci la prima parola:");
string word1 = Console.ReadLine().Trim();

Console.WriteLine("Inserisci la seconda parola:");
string word2 = Console.ReadLine().Trim();

Console.Write("Risultato: ");
PrintLongerOrBothWord(word1, word2);
// See https://aka.ms/new-console-template for more information

string title = "Clean Code";
string author = "Robert C. Martin";
string ISBN = "978-0-13-235088-4";
uint pages = 431;
float weight = 0.8f;
uint height = 23;
uint depth = 2;
uint width = 17;
float meanRate = 4.7f;
uint reviews = 5668;
bool flexibleCover = true;
bool kindleAvailable = true;


// Stampo le informazione del libro a schermo
Console.WriteLine($"------ LIBRO DEL GIORNO: {title} di {author} ------");
Console.WriteLine("Informazioni generiche: ");
Console.WriteLine($"ISBN: {ISBN}");
Console.WriteLine($"Numero pagine: {pages} pagine");
Console.WriteLine($"Peso: {weight} kg");

Console.WriteLine(Environment.NewLine);

Console.WriteLine("Informazioni amazon: ");
Console.WriteLine($"Numero di recensioni: {reviews} recensioni");
Console.WriteLine($"Valutazione: {meanRate} stelline");
Console.WriteLine($"Kindle: {(kindleAvailable? "si":"no")}");
Console.WriteLine($"Compertina flessibile: {(flexibleCover ? "si" : "no")}");
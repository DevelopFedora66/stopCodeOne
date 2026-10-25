/* 
 Primo Stop And Code
 Scrivere programma C# per determianre se uno studente è promosso o bocciato
 1) Creazione lista vuota
 2) Chiedere all utente quanti voti vuole inserire
 3) Per ogni voto inserire un valore da 0 a 10

 ========================================

Calcolare:

1)  Stampare la somma dei voti
2)  Calcolare la media dei voti
3)  Capire se lo studente e promosso o bocciato: PROMOSSO == media >= 6 altrimenti BOCCIATO

*/

using System.Reflection;

// Lista vuota per numero voti 
List<int> listGrades  = [];

// Voglio usare le costanti per Promosso o Bocciato per capirle
const string PROMOSSO = "PROMOSSO";
const string BOCCIATO = "BOCCIATO";

// Chiedo all utente quanti voti vuole memorizzare e lo memorizzo
// Metto l'unita di misura bassa perche non penso che siano chissa quante materie :-)
Console.Write("Inserisci il numero dei voti che vuoi calcolare:");
ushort numberGrades = Convert.ToUInt16(Console.ReadLine());

for(ushort i=0; i<numberGrades; i++)
{
    Console.Write($"Inserisci il voto n.{i+1} (da 0 a 10): ");
    ushort vote = Convert.ToUInt16(Console.ReadLine());
    listGrades.Add(vote);
}
// Stampo l'elenco dei voti inseriti divisa dalla ","
Console.WriteLine();    // Per dare spazio alla console
Console.WriteLine($"L'elenco dei voti inseriti è: {string.Join(",", listGrades)}");

ushort sum = 0;
double average = 0d;    // metto la media come double per avere eventualmente la , altrimenti cast tutto ad ushort

// Ciclo per la memorizzare la somma e utilizzarla anche dopo per la media
foreach(ushort element in listGrades)
{
    sum+=element;
}
Console.WriteLine();    // Per dare spazio alla console

// Stampo la somma dei voti
Console.WriteLine($"La somma dei {listGrades.Count} voti è: {sum}");

// Calcolo la media -> Somma dei voti / numero di voti. Cast a double sum perchè è un ushort
average = ((double)sum / numberGrades);
Console.WriteLine($"La media dei voti è {average}");

Console.WriteLine();    // Per dare spazio alla console
// Stampa della promozione o della bocciatura
if(average >= 6.0)
{
    Console.WriteLine($"L'alunno è stato {PROMOSSO}");
}
else
{
    Console.WriteLine($"Ci dispiace, purtroppo l'alunno è stato {BOCCIATO}");
}



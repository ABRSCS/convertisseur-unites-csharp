using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Convertisseur de longueurs ===");
        Console.Write("Entrez une longueur en centimètres : ");
        
        string input = Console.ReadLine();
        double cm;

        if (double.TryParse(input, out cm))
        {
            double m = cm / 100;
            double inch = cm / 2.54;
            double feet = cm / 30.48;

            Console.WriteLine($"\n{cm} cm = {m} m");
            Console.WriteLine($"{cm} cm = {inch:F2} pouces");
            Console.WriteLine($"{cm} cm = {feet:F2} pieds");
        }
        else
        {
            Console.WriteLine("Valeur invalide. Veuillez entrer un nombre.");
        }

        Console.WriteLine("\nAppuyez sur une touche pour quitter.");
        Console.ReadKey();
    }
}

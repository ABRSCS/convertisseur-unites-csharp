using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Convertisseur de longueurs ===");
        while (true)
        {
            Console.Write("Entrez une longueur en centimètres (ou 'q' pour quitter) : ");
            string input = Console.ReadLine();
            if (input.ToLower() == "q") break;

            if (double.TryParse(input, out double cm))
            {
                Console.WriteLine($"{cm} cm = {cm / 100} m");
                Console.WriteLine($"{cm} cm = {cm * 10} mm");
                Console.WriteLine($"{cm} cm = {cm / 2.54:F2} pouces");
                Console.WriteLine($"{cm} cm = {cm / 30.48:F2} pieds\n");
            }
            else
            {
                Console.WriteLine("Valeur invalide. Veuillez entrer un nombre.\n");
            }
        }
        Console.WriteLine("Au revoir !");
    }
}

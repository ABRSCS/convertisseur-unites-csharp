using System;

namespace ConvertisseurUnites
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le convertisseur d'unités !");
            Console.Write("Entrez une longueur en centimètres : ");

            string? input = Console.ReadLine();

if (input != null && double.TryParse(input, out double cm))


            if (double.TryParse(input, out cm))
            {
                double metres = cm / 100;
                double pouces = cm / 2.54;
                double pieds = cm / 30.48;

                Console.WriteLine($"\nConversions pour {cm} cm :");
                Console.WriteLine($"- Mètres : {metres:F2} m");
                Console.WriteLine($"- Pouces : {pouces:F2} in");
                Console.WriteLine($"- Pieds : {pieds:F2} ft");
            }
            else
            {
                Console.WriteLine("Erreur : Veuillez entrer un nombre valide.");
            }

            Console.WriteLine("\nAppuyez sur une touche pour quitter.");
            Console.ReadKey();
        }
    }
}

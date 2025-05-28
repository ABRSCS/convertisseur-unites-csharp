using System;

class Program
{
    static void Main(string[] args)
    {
        double centimetres = 30;
        
        // Conversion en mètres
        double metres = centimetres / 100;
        
        // Conversion en millimètres
        double millimetres = centimetres * 10;
        
        // Conversion en pouces (1 pouce = 2.54 cm)
        double pouces = centimetres / 2.54;
        
        // Conversion en pieds (1 pied = 30.48 cm)
        double pieds = centimetres / 30.48;

        Console.WriteLine($"30 centimètres équivaut à :");
        Console.WriteLine($"{metres} mètres");
        Console.WriteLine($"{millimetres} millimètres");
        Console.WriteLine($"{pouces:F2} pouces");
        Console.WriteLine($"{pieds:F2} pieds");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Fraction Assignment Verification ===\n");

        // Test case 1: Default / implicit 1 (e.g., Fraction())
        Fraction f1 = new Fraction();
        DisplayFractionInfo("Default Constructor (1/1)", f1);

        // Test case 2: Whole number 5 (e.g., Fraction(5))
        Fraction f2 = new Fraction(5);
        DisplayFractionInfo("Whole Number Constructor (5)", f2);

        // Test case 3: 3/4 (e.g., Fraction(3, 4))
        Fraction f3 = new Fraction(3, 4);
        DisplayFractionInfo("Two-Parameter Constructor (3/4)", f3);

        // Test case 4: 1/3 (e.g., Fraction(1, 3))
        Fraction f4 = new Fraction(1, 3);
        DisplayFractionInfo("Two-Parameter Constructor (1/3)", f4);
    }

    // Helper method to keep our output clean and consistent
    static void DisplayFractionInfo(string label, Fraction fraction)
    {
        Console.WriteLine($"{label}:");
        Console.WriteLine($"  Fraction String: {fraction.GetFractionString()}");
        Console.WriteLine($"  Decimal Value:   {fraction.GetDecimalValue()}");
        Console.WriteLine();
    }
}
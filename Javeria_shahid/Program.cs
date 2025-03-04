using System;

class UnitConverter
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nUnit Converter");
            Console.WriteLine("1. Temperature");
            Console.WriteLine("2. Length");
            Console.WriteLine("3. Weight");
            Console.WriteLine("4. Exit");
            Console.Write("Choose a category: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ConvertTemperature();
                    break;
                case "2":
                    ConvertLength();
                    break;
                case "3":
                    ConvertWeight();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void ConvertTemperature()
    {
        Console.WriteLine("\nTemperature Converter");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Celsius to Kelvin");
        Console.WriteLine("3. Fahrenheit to Celsius");
        Console.WriteLine("4. Fahrenheit to Kelvin");
        Console.WriteLine("5. Kelvin to Celsius");
        Console.WriteLine("6. Kelvin to Fahrenheit");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();
        Console.Write("Enter temperature value: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        double result = choice switch
        {
            "1" => (temp * 9 / 5) + 32,
            "2" => temp + 273.15,
            "3" => (temp - 32) * 5 / 9,
            "4" => ((temp - 32) * 5 / 9) + 273.15,
            "5" => temp - 273.15,
            "6" => ((temp - 273.15) * 9 / 5) + 32,
            _ => double.NaN
        };

        if (double.IsNaN(result))
            Console.WriteLine("Invalid option.");
        else
            Console.WriteLine($"Converted Temperature: {result}");
    }

    static void ConvertLength()
    {
        Console.WriteLine("\nLength Converter");
        Console.WriteLine("1. Meters to Kilometers");
        Console.WriteLine("2. Meters to Miles");
        Console.WriteLine("3. Kilometers to Meters");
        Console.WriteLine("4. Kilometers to Miles");
        Console.WriteLine("5. Miles to Meters");
        Console.WriteLine("6. Miles to Kilometers");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();
        Console.Write("Enter length value: ");
        double length = Convert.ToDouble(Console.ReadLine());

        double result = choice switch
        {
            "1" => length / 1000,
            "2" => length * 0.000621371,
            "3" => length * 1000,
            "4" => length * 0.621371,
            "5" => length * 1609.34,
            "6" => length / 0.621371,
            _ => double.NaN
        };

        if (double.IsNaN(result))
            Console.WriteLine("Invalid option.");
        else
            Console.WriteLine($"Converted Length: {result}");
    }

    static void ConvertWeight()
    {
        Console.WriteLine("\nWeight Converter");
        Console.WriteLine("1. Kilograms to Grams");
        Console.WriteLine("2. Kilograms to Pounds");
        Console.WriteLine("3. Grams to Kilograms");
        Console.WriteLine("4. Grams to Ounces");
        Console.WriteLine("5. Pounds to Kilograms");
        Console.WriteLine("6. Ounces to Grams");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();
        Console.Write("Enter weight value: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        double result = choice switch
        {
            "1" => weight * 1000,
            "2" => weight * 2.20462,
            "3" => weight / 1000,
            "4" => weight * 0.035274,
            "5" => weight / 2.20462,
            "6" => weight / 0.035274,
            _ => double.NaN
        };

        if (double.IsNaN(result))
            Console.WriteLine("Invalid option.");
        else
            Console.WriteLine($"Converted Weight: {result}");
    }
}

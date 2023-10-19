// Declare variables for storing temperature values and units.
double temperature, conversion;
string unit1, unit2;

// Display a welcome message and instructions.
Console.WriteLine("Welcome to Temperature Conversion!");
Console.WriteLine("==================================");
Console.WriteLine("Available units are (C)elcius, (F)ahrenheit, and (K)elvin.\n");

// Prompt the user to input the temperature value.
Console.Write("Enter Temperature: ");
temperature = double.Parse(Console.ReadLine()); // Convert the input string to a double.

// Prompt the user to input the current temperature unit.
Console.Write("Enter Unit: ");
unit1 = Console.ReadLine().ToUpper(); // Normalize the input to uppercase.

// Prompt the user to input the desired unit for conversion.
Console.Write("Enter Conversion Unit: ");
unit2 = Console.ReadLine().ToUpper(); // Normalize the input to uppercase.

Console.WriteLine(); // Print a blank line for output clarity.

// Check if the source and target units are the same.
if (unit1 == unit2)
{
    // Notify the user that conversion doesn't occur between identical units.
    Console.WriteLine($"We cannot convert {unit1} to {unit2}!");
}
// Validate the entered source unit.
else if (unit1 != "C" && unit1 != "F" && unit1 != "K")
{
    // Inform the user that the entered source unit is not supported.
    Console.WriteLine($"The unit {unit1} is not valid!");
}
// Validate the entered target unit.
else if (unit2 != "C" && unit2 != "F" && unit2 != "K")
{
    // Inform the user that the entered target unit is not supported.
    Console.WriteLine($"The unit {unit2} is not valid!");
}
else
{
    // At this point, we know the units are valid and different. We proceed with conversion.
    if (unit1 == "C") // Current unit is Celsius.
    {
        if (unit2 == "F") // Convert to Fahrenheit.
        {
            conversion = Math.Round(temperature * 9 / 5 + 32, 2); // Apply Celsius to Fahrenheit formula.
        }
        else // The only other option is Kelvin since we already checked for equality and validity.
        {
            conversion = Math.Round(temperature + 273.15, 2); // Apply Celsius to Kelvin formula.
        }
    }
    else if (unit1 == "F") // Current unit is Fahrenheit.
    {
        if (unit2 == "K") // Convert to Kelvin.
        {
            conversion = Math.Round(((temperature - 32) * 5 / 9) + 273.15, 2); // Apply Fahrenheit to Kelvin formula.
        }
        else // The only other option is Celsius.
        {
            conversion = Math.Round((temperature - 32) * 5 / 9, 2); // Apply Fahrenheit to Celsius formula.
        }
    }
    else // The only remaining option is that the current unit is Kelvin.
    {
        if (unit2 == "F") // Convert to Fahrenheit.
        {
            conversion = Math.Round((temperature - 273.15) * 9 / 5 + 32, 2); // Apply Kelvin to Fahrenheit formula.
        }
        else // The only other option is Celsius.
        {
            conversion = Math.Round(temperature - 273.15, 2); // Apply Kelvin to Celsius formula.
        }
    }

    // Display the result of the conversion to the user.
    Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
}
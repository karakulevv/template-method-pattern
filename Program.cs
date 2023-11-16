using TemplateMethodPattern.Models;
using TemplateMethodPattern.Services;

class Program
{
    static void Main(string[] args)
    {
        // Creating assembly lines for Sedan and SUV
        AutomobileAssemblyLine sedanLine = new SedanAssemblyLine();
        AutomobileAssemblyLine suvLine = new SUVAssemblyLine();

        // Producing cars using the template method
        Console.WriteLine("Building Sedan Car:");
        sedanLine.ManufactureCar();

        Console.WriteLine("\nBuilding SUV:");
        suvLine.ManufactureCar();
    }
}
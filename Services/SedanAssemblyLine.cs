using TemplateMethodPattern.Models;

namespace TemplateMethodPattern.Services;

// Concrete Class
public class SedanAssemblyLine : AutomobileAssemblyLine
{
    protected override void AssembleChassis()
    {
        Console.WriteLine("Assembling Sedan Chassis...");
    }

    protected override void InstallEngine()
    {
        Console.WriteLine("Installing Sedan Engine...");
    }

    protected override void PaintCar()
    {
        Console.WriteLine("Painting Sedan Car...");
    }

    protected override void QualityCheck()
    {
        Console.WriteLine("Conducting Quality Checks for Sedan...");
    }
}
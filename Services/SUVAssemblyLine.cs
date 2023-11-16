using TemplateMethodPattern.Models;

namespace TemplateMethodPattern.Services;

// Concrete Class
public class SUVAssemblyLine : AutomobileAssemblyLine
{
    protected override void AssembleChassis()
    {
        Console.WriteLine("Assembling SUV Chassis...");
    }

    protected override void InstallEngine()
    {
        Console.WriteLine("Installing SUV Engine...");
    }

    protected override void PaintCar()
    {
        Console.WriteLine("Painting SUV Car...");
    }

    protected override void QualityCheck()
    {
        Console.WriteLine("Conducting Quality Checks for SUV...");
    }
}
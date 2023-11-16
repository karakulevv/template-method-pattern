namespace TemplateMethodPattern.Models;

// Abstract Class (Template)
public abstract class AutomobileAssemblyLine
{
    // Template method defining the sequence of steps to manufacture a car
    public void ManufactureCar()
    {
        AssembleChassis();
        InstallEngine();
        PaintCar();
        QualityCheck();
    }

    // Abstract methods representing specific steps
    protected abstract void AssembleChassis();
    protected abstract void InstallEngine();
    protected abstract void PaintCar();
    protected abstract void QualityCheck();
}
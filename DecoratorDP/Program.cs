using DecoratorDP.Components;
using DecoratorDP.Decorators;

namespace StringDecorator;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a ConcreteComponent
        IComponent<string> component = new ConcreteComponent();

        // Create decorators
        IComponent<string> plainDecorator = new PlainDecorator(component);
        IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
        IComponent<string> colorDecorator = new ColorDecorator(component);

        // Call GetText() on each object and print the result
        Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
        Console.WriteLine("Upper Case Decorator: " + upperCaseDecorator.GetText());
        Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
    }
}
using DecoratorDP.Components;

namespace DecoratorDP.Decorators;

public class UpperCaseDecorator : Decorator<string>
{
    public UpperCaseDecorator(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        string text = component.GetText();
        return text.ToUpper();
    }
}
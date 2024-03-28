public class ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        string text = component.GetText();
        return $"\u001b[94m{text}\u001b[0m"; 
    }
}
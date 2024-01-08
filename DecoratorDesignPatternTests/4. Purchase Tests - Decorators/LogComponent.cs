﻿namespace DecoratorDesignPattern.FourthVersion;

public class LogComponent : ComponentDecorator
{
    public LogComponent(Component element)
    : base(element)
    {
    }

    public override By By => Element?.By;

    public override string Text
    {
        get
        {
            Console.WriteLine($"Element Text = {Element?.Text}");
            return Element?.Text;
        }
    }

    public override bool? Enabled
    {
        get
        {
            Console.WriteLine($"Element Enabled = {Element?.Enabled}");
            return Element?.Enabled;
        }
    }

    public override bool? Displayed
    {
        get
        {
            Console.WriteLine($"Element Displayed = {Element?.Displayed}");
            return Element?.Displayed;
        }
    }

    public override void Click()
    {
        Console.WriteLine($"Element Clicked");
        Element?.Click();
    }

    public override Component FindComponent(By locator)
    {
        throw new NotImplementedException();
    }

    public override List<Component> FindComponents(By locator)
    {
        throw new NotImplementedException();
    }

    public override string GetAttribute(string attributeName)
    {
        Console.WriteLine($"Get Element's Attribute = {attributeName}");
        return Element?.GetAttribute(attributeName);
    }

    public override void Hover()
    {
        Element?.Hover();
    }

    public override void TypeText(string text)
    {
        Console.WriteLine($"Type Text = {text}");
        Element?.TypeText(text);
    }
}
using Godot;
using System;

public partial class Start : Control
{
	private string theOperator = "";
	private float firstNumber = 0;
	private float secondNumber = 0;

    private Label screen;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Engine Has Started! ");

        // Connecting screen node to screen label, lmao :')
        screen = GetNode<Label>("VBoxContainer/Screen");

        // Adding all buttons
        // The Numbers
        Button b1 = GetNode<Button>("VBoxContainer/GridContainer/b1");
        Button b2 = GetNode<Button>("VBoxContainer/GridContainer/b2");
        Button b3 = GetNode<Button>("VBoxContainer/GridContainer/b3");
        Button b4 = GetNode<Button>("VBoxContainer/GridContainer/b4");
        Button b5 = GetNode<Button>("VBoxContainer/GridContainer/b5");
        Button b6 = GetNode<Button>("VBoxContainer/GridContainer/b6");
        Button b7 = GetNode<Button>("VBoxContainer/GridContainer/b7");
        Button b8 = GetNode<Button>("VBoxContainer/GridContainer/b8");
        Button b9 = GetNode<Button>("VBoxContainer/GridContainer/b9");
        Button b0 = GetNode<Button>("VBoxContainer/GridContainer/b0");
        // The Operators
        Button plus = GetNode<Button>("VBoxContainer/GridContainer/Addition");
        Button minus = GetNode<Button>("VBoxContainer/GridContainer/Subtraction");
        Button devide = GetNode<Button>("VBoxContainer/GridContainer/Division");
        Button multiply = GetNode<Button>("VBoxContainer/GridContainer/Multiplication");
        Button equal = GetNode<Button>("VBoxContainer/GridContainer/Equal");
        // Other things or whatever
        Button dot = GetNode<Button>("VBoxContainer/GridContainer/dot");
        Button clear = GetNode<Button>("VBoxContainer/GridContainer/ClearButton");

        b1.Pressed += () => ButtonPressed(b1);
        b2.Pressed += () => ButtonPressed(b2);
        b3.Pressed += () => ButtonPressed(b3);
        b4.Pressed += () => ButtonPressed(b4);
        b5.Pressed += () => ButtonPressed(b5);
        b6.Pressed += () => ButtonPressed(b6);
        b7.Pressed += () => ButtonPressed(b7);
        b8.Pressed += () => ButtonPressed(b8);
        b9.Pressed += () => ButtonPressed(b9);
        b0.Pressed += () => ButtonPressed(b0);

        plus.Pressed += () => ButtonPressed(plus);
        minus.Pressed += () => ButtonPressed(minus);
        devide.Pressed += () => ButtonPressed(devide);
        multiply.Pressed += () => ButtonPressed(multiply);
        equal.Pressed += () => ButtonPressed(equal);
        dot.Pressed += () => ButtonPressed(dot);
        clear.Pressed += () => ButtonPressed(clear);
	}

    private void ButtonPressed(Button Button)
    {
        string theText = Button.Text;

        if (theText == "+" || theText == "-" || theText == "*" || theText == "/" || theText == "C" || theText == "=")
        {
            HandleOperator(theText);
        }
        else
        {
            HandleNumber(theText);
        }
    }
    private void HandleOperator(string op)
    {
        GD.Print("Handling Operator...");

        if (op == "C")
        {
            screen.Text = "0";
            firstNumber = 0;
            theOperator = "";
        }
        else if (op == "=")
        {
            secondNumber = float.Parse(screen.Text);
            theOperator = "";
        }
        else
        {
            firstNumber = float.Parse(screen.Text);
            theOperator = op;
        }
    }
    private void HandleNumber()
    {
        GD.Print("Handling Number...");
    }
    private void TheCalculation()
    {
        float result = 0;
        switch (theOperator)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "/":
                result = firstNumber / secondNumber;
                break;
        }
    }
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}

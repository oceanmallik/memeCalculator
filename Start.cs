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

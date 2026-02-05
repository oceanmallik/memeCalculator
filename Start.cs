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

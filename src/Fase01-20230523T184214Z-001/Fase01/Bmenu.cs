using Godot;
using System;

public partial class Bmenu : Button
{
public override void _Ready()
{
	var button1 = new Button();
	button1.Text = "Fase01";
	button1.Pressed += ButtonPressed;
	AddChild(button1);
}

private void ButtonPressed()
{
	GetTree().ChangeSceneToFile("res://History Line.tscn");
}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

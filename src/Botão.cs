using Godot;
using System;

public partial class Botão : Button
{
	public override void _Ready()
{
	var button = new Button();
	button.Text = "Voltar pra fase";
	button.Pressed += ButtonPressed;
	AddChild(button);
}

private void ButtonPressed()
{
	GetTree().ChangeSceneToFile("res://Fase1.tscn");
}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

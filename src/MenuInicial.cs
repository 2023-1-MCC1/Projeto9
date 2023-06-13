using Godot;
using System;

public partial class MenuInicial : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	
private void _on_button_button_down(Node2D button)
{
	GetTree().ChangeSceneToFile("res://Fase1.tscn");
}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}


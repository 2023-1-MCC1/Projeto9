using Godot;
using System;

public partial class Menu : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	private void _on_button_pressed()
{
	GetTree().ChangeSceneToFile("res://History Line.tscn");
}
private void _on_button_2_pressed()
{
	GetTree().ChangeSceneToFile("res://Crédito.tscn");
}



	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}





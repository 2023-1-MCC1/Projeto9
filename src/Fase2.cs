using Godot;
using System;

public partial class Fase2 : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	
private void _on_area_2d_body_entered(Node2D body)
{
	GetTree().ChangeSceneToFile("res://Game Over.tscn");
}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

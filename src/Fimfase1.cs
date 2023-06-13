using Godot;
using System;

public partial class Fimfase1 : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	

private void _on_body_shape_entered(Rid body_rid, Node2D body, long body_shape_index, long local_shape_index)
{
	GetTree().ChangeSceneToFile("res://IFase2.tscn");
}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

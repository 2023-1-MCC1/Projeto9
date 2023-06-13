using Godot;
using System;

public partial class ponto3 : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	private void _on_area_2d_body_shape_entered(Rid body_rid, Node2D body, long body_shape_index, long local_shape_index)
{
		GD.Print("Coletou");
	this.Visible=false;
	this.QueueFree();
}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}




using Godot;
using System;

public partial class amulethof_ares : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
		Sword.DamageVariable = Sword.DamageVariable+10;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

using Godot;
using System;

public partial class Sword : CharacterBody2D
{
	public static int DamageVariable = 30;
	// Called when the node enters the scene tree for the first time.
	public void sword(){}
	public override void _Ready(){}
	public override void _Process(double delta){
		if (Input.IsActionJustPressed("Attack")){
			var ap = GetNode("AnimationPlayer") as AnimationPlayer;
			ap.Play("slash");
			//GD.Print("Slash");
		}		
	}
}

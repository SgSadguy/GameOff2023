using Godot;
using System;
using HealthSystem_Player;

public partial class Trap : Area2D
{
	public override void _Ready()
	{
		
	}
	private void _on_body_entered(Node2D body)
	{
			 // Create an instance of MyScript1 and call its function
			Playerhealth PlayerStandInstance = new Playerhealth();
			PlayerStandInstance.TakeDamage(10000000);
			GD.Print("Player has been hitted by a Trap!");
	}
}

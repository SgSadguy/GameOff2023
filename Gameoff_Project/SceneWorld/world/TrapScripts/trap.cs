using Godot;
using System;
using HealthSystem_Player;

public partial class Trap : Area2D
{
	public override void _Ready()
	{
		
	}
	private void _on_area_entered(Area2D area)
	{
		if (area == null) {
			return;
			}
		else {
			 // Create an instance of MyScript1 and call its function
			Playerhealth PlayerStandInstance = new Playerhealth();
			PlayerStandInstance.TakeDamage(10000000);
			GD.Print("Player has been hitted by a Trap!");
			}
	}
}

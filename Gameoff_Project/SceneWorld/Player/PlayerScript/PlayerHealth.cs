using Godot;
using System;

public static class CurrentPlayerHealth
{
	public static int health = 100;
}

namespace HealthSystem_Player {
public partial class Playerhealth : Resource
{
	
	// This function reduces the player's health when called
	public void TakeDamage(int damageAmount)
	{
		CurrentPlayerHealth.health -= damageAmount;
		GD.Print("Player Health : " + CurrentPlayerHealth.health);
		// Check if the player's health has dropped to zero or below
		if (CurrentPlayerHealth.health <= 0){
			Die();
		}
	}
	private void Die(){
		GD.Print("Player has died!");
	}
}
}

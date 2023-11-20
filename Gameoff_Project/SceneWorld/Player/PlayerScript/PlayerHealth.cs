using Godot;
using System;

public partial class Playerhealth : Resource
{
	private int health = 100;

	// This function reduces the player's health when called
	public void TakeDamage(int damageAmount)
	{
		health -= damageAmount;
		GD.Print(health);
		// Check if the player's health has dropped to zero or below
		if (health <= 0){
			Die();
		}
	}
	private void Die(){
		GD.Print("Player has died!");
	}
}

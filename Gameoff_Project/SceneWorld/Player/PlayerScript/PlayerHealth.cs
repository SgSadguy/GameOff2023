using Godot;
using System;

public partial class PlayerHealth : Node
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

	// This function is called when the player's health reaches zero
	private void Die(){
		GD.Print("Player has died!");
	}
}

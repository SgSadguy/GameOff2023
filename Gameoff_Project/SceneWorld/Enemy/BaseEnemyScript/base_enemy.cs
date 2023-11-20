using Godot;
using System;

public partial class base_enemy : Node2D
{
	public float Health = 100.0f;
	public void TakeDamage(float damageAmount){
		GD.Print("Hit");
		Health -= damageAmount;
		GD.Print(Health);
	}
}

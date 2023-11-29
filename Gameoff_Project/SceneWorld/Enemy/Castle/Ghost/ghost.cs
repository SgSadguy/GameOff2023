using Godot;
using System;

public partial class ghost : CharacterBody2D
{
	public float Health = 100.0f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void TakeDamage(float damageAmount){
		//GD.Print("Hit");
		Health -= damageAmount;
		GD.Print(Health);
		if (Health <= 0 ){
			Die();
		}
	}
	private void Die(){
		GD.Print("Enemy has died!");
		QueueFree();
	}
}

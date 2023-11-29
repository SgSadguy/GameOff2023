using Godot;
using System;

public partial class hitbox : Area2D
{
private void OnBodyEntered(Node2D body)
{
	if (body.IsInGroup("sword")){
		if (Owner.HasMethod("TakeDamage")){
			var DamageValue =  Sword.DamageVariable;
			Owner.Call("TakeDamage",DamageValue);
		}
	}
}
}


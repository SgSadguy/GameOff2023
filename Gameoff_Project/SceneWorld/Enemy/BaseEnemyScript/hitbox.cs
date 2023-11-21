using Godot;
using System;

public partial class hitbox : Area2D
{
private void OnBodyEntered(Node2D body)
{
	if (body.IsInGroup("sword")){
		if (Owner.HasMethod("TakeDamage")){
			Owner.Call("TakeDamage",20);
		}
	}
}
}


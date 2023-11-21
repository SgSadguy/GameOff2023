using Godot;
using System;

public partial class hitbox : Area2D
{
private void _on_area_entered(Area2D area)
{
	if (area == null){
		return;
		}
	if (area.HasMethod("sword")){
		if (Owner.HasMethod("TakeDamage")){
			Owner.Call("TakeDamage",20);
		}
	}
}
private void OnBodyEntered(Node2D body)
{
	GD.Print("Min");
	if (body.HasMethod("sword")){
		if (Owner.HasMethod("TakeDamage")){
			Owner.Call("TakeDamage",20);
		}
}
}
}

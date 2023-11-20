using Godot;
using System;

public partial class hitbox : Area2D
{
	public override void _Ready(){
	}
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
}

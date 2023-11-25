using Godot;
using System;

public partial class PlayerDetection : Area2D
{
	private Godot.Collections.Dictionary<string, bool> _Object_STRCTURE = new Godot.Collections.Dictionary<string, bool>();
	
	public void _ready() {
		_Object_STRCTURE["IS_FALLED"] = false;
	}
	
	private void _on_body_entered(Node2D body)
	{
		bool is_fall = (bool)_Object_STRCTURE["IS_FALLED"];
		if (is_fall == false) {
			var ap = GetNode($"../AnimationPlayer") as AnimationPlayer;
			ap.Play("FallingintoYOU");
			is_fall = true;
			}
	}
}

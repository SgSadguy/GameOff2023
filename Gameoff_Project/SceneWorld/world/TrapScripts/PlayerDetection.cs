using Godot;
using System;

public static class IS_FALLED
{
	public static bool fall = false;
}

public partial class PlayerDetection : Area2D
{
	private void _on_body_entered(Node2D body)
	{
		if (IS_FALLED.fall == false) {
			var ap = GetNode($"../AnimationPlayer") as AnimationPlayer;
			ap.Play("FallingintoYOU");
			IS_FALLED.fall = true;
			}
	}
}

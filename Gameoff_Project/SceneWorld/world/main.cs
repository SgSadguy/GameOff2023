using Godot;
using System;

public partial class main : Node2D
{
	public override void _Ready()
	{
		PackedScene room0 = GD.Load<PackedScene>("res://SceneWorld/world/Room/room_1.tscn");
		Node2D room0Instance = (Node2D)room0.Instantiate();
		AddChild(room0Instance);
		PackedScene room1 = GD.Load<PackedScene>("res://SceneWorld/world/Room/room_2.tscn");
		Node2D room1Instance = (Node2D)room1.Instantiate();
		AddChild(room1Instance);
		room1Instance.Position = new Vector2(room1Instance.Position.X + 1000, room1Instance.Position.Y);
	}

}

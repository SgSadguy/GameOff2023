using Godot;
using System;

public partial class main : Node2D
{
	public override void _Ready(){
		//load Scene
		PackedScene room0 = GD.Load<PackedScene>("res://SceneWorld/world/Room/room_1.tscn");
		PackedScene room1 = GD.Load<PackedScene>("res://SceneWorld/world/Room/room_2.tscn");
		PackedScene room2 = GD.Load<PackedScene>("res://SceneWorld/world/Room/room_3.tscn");
		//Keep it with Node2D
		Node2D room0Instance = (Node2D)room0.Instantiate();
		Node2D room1Instance = (Node2D)room1.Instantiate();
		Node2D room2Instance = (Node2D)room2.Instantiate();
		Node2D[] roomInstances;
		//Array Keep Room 
		roomInstances = new Node2D[] { room0Instance, room1Instance ,room2Instance};
		// AddChild(roomInstances[1]);
		ShuffleArray(roomInstances);
		//For loop to spawn room
		for (int i = 0; i < roomInstances.Length ; i++) {
		AddChild(roomInstances[i]);
				if (i>0){
					roomInstances[i].Position = new Vector2(roomInstances[i-1].Position.X + 3000, roomInstances[i-1].Position.Y);
				}
		}
		
		//RemoveChild(roomInstances[1]);
	}
	static void ShuffleArray(Node2D[] array){
		Random rng = new Random();
		int n = array.Length;
		while (n > 1){
			n--;
			int k = rng.Next(n + 1);
			Node2D temp = array[k];
			array[k] = array[n];
			array[n] = temp;}}
}

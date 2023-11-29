using Godot;
using System;

public partial class main : Node2D
{	//load Scene
	public PackedScene room0 = GD.Load<PackedScene>("res://SceneWorld/world/Room/room_1.tscn");
	public PackedScene room1 = GD.Load<PackedScene>("res://SceneWorld/world/Room/room_2.tscn");
	public PackedScene room2 = GD.Load<PackedScene>("res://SceneWorld/world/Room/room_3.tscn");
	//loadAmuleth	
	public PackedScene ares = GD.Load<PackedScene>("res://Amuleth/AmulethScene/amulethof_ares.tscn");
	public PackedScene alive = GD.Load<PackedScene>("res://Amuleth/AmulethScene/amulethof_alive.tscn");
	public PackedScene areturn = GD.Load<PackedScene>("res://Amuleth/AmulethScene/amulethof_return.tscn");
		
	public Node2D[] amulethInstances;
	public Node2D[] roomInstances;
	
	public static int score = 0;
	public override void _Ready(){
	//Keep it with Node2D
		Node2D room0Instance = (Node2D)room0.Instantiate();
		Node2D room1Instance = (Node2D)room1.Instantiate();
		Node2D room2Instance = (Node2D)room2.Instantiate();
		//Array Keep Room 
		roomInstances = new Node2D[] { room0Instance, room1Instance ,room2Instance};
		// AddChild(roomInstances[1]);
		ShuffleArray(roomInstances);
		//For loop to spawn room
		for (int i = 0; i < roomInstances.Length ; i++) {
				AddChild(roomInstances[i]);
				if (i>0){
					roomInstances[i].Position = new Vector2(roomInstances[i-1].Position.X + 3000, roomInstances[i-1].Position.Y);
				}}
	}
	public override void _Process(double delta){
		Amuleth();
	}
	public static void ShuffleArray(Node2D[] array){
		Random rng = new Random();
		int n = array.Length;
		while (n > 1){
			n--;
			int k = rng.Next(n + 1);
			Node2D temp = array[k];
			array[k] = array[n];
			array[n] = temp;}}

	public void Amuleth(){
		Node2D aresInstance = (Node2D)ares.Instantiate();
		Node2D aliveInstance = (Node2D)alive.Instantiate();
		Node2D areturnInstance = (Node2D)areturn.Instantiate();
		amulethInstances = new Node2D[] { aresInstance,  aliveInstance , areturnInstance};
		if(room.clearwave > 1){
			GD.Print("Hi");
			AddChild(amulethInstances[1]);
			GD.Print(amulethInstances[1]);
			//ShuffleArray(amulethInstances);
			room.clearwave -= 1;
		}	}
}

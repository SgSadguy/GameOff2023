using Godot;
using System;

public partial class room : Node2D{
	public override void _Ready(){
	PackedScene Ghosts = GD.Load<PackedScene>("res://SceneWorld/Enemy/Castle/Ghost/ghost.tscn");
		
		Random random = new Random();

		// Generate a random number between 3 and 10
		int randomNumber = random.Next(3, 11);

		// Print the random number
		GD.Print("Random number: " + randomNumber);
		
		//Random Spawn Enemy
		for (int i = 0; i < randomNumber; i++) {
		Node2D GhostsInstance = (Node2D)Ghosts.Instantiate();
		AddChild(GhostsInstance);	
		GhostsInstance.Position = new Vector2(GhostsInstance.Position.X+100*i, GhostsInstance.Position.Y+100);
		}
	}
}

using Godot;
using System;

public partial class room : Node2D{
	public int clearwave = 0;
	private RandomNumberGenerator rng;

	// Declare a public integer variable for the random number
	public int RandomInteger;

	public override void _Ready(){
		// Initialize the RNG in the _Ready method
		rng = new RandomNumberGenerator();
		// Seed the RNG with a unique value, such as the current time
		rng.Randomize();
		// Generate a random integer within a specified range (e.g., 1 to 100)
		RandomInteger = rng.RandiRange(3,5);
		// Print the random integer to the console
		GD.Print("Random Integer: " + RandomInteger);
		
		SpawnEnemy(RandomInteger);
	}
		//Check Playerinroom
		private void _on_check_playerin_map_body_entered(Node2D body){
				if (body.IsInGroup("sword")){
					//GD.Print("Player in Room");
				}}
		//Check EnemyiSDEAD
		private void _on_check_playerin_map_body_exited(Node2D body){
			if (body.IsInGroup("enemy")){
					//GD.Print("EnemyisDead");
					clearwave += 1;
					GD.Print(clearwave);
				}}
				
		public void SpawnEnemy(int randomNumber){
			PackedScene Ghosts = GD.Load<PackedScene>("res://SceneWorld/Enemy/Castle/Ghost/ghost.tscn");
			//Random Spawn Enemy
			for (int i = 0; i < randomNumber; i++) {
			Node2D GhostsInstance = (Node2D)Ghosts.Instantiate();
			AddChild(GhostsInstance);	
			GhostsInstance.Position = new Vector2(GhostsInstance.Position.X+100*i, GhostsInstance.Position.Y+100);
			}
		}
		public override void _Process(double delta){
			checkwave();
		}
		
		public void checkwave(){
			if (clearwave >= RandomInteger){
			GD.Print("D");
				
				}
			
		}
}

using Godot;
using System;

public partial class room : Node2D{
	private int clearwaveunit = 0;
	private RandomNumberGenerator rng;
	public bool playerinroom = false;
	public static int clearwave = 0;

	// Declare a public integer variable for the random number
	public int RandomInteger;

	public override void _Ready(){
		// Initialize the RNG in the _Ready method
		rng = new RandomNumberGenerator();
		// Seed the RNG with a unique value, such as the current time
		rng.Randomize();
		// Generate a random integer within range 
		RandomInteger = rng.RandiRange(1,3);
		// Print the random integer to the console
		GD.Print("Random Integer: " + RandomInteger);
		
		SpawnEnemy(RandomInteger);
	}
		//Check EnemyiSDEAD
		private void _on_check_playerin_map_body_exited(Node2D body){
			if (body.IsInGroup("enemy") && playerinroom == true){
					clearwaveunit += 1;
					GD.Print("ClearWave Unit " + clearwaveunit);}}
				
		public void SpawnEnemy(int randomNumber){
			var mk1 = GetNode("Marker1") as Marker2D;
			var mk2 = GetNode("Marker2") as Marker2D;
			var mk3 = GetNode("Marker3") as Marker2D;
			var mk4 = GetNode("Marker4") as Marker2D;
			Marker2D[] marker;
			marker = new Marker2D[] { mk1, mk2 , mk3 , mk4};
			PackedScene Ghosts = GD.Load<PackedScene>("res://SceneWorld/Enemy/Castle/Ghost/ghost.tscn");
			//Random Spawn Enemy
			for (int i = 0; i < randomNumber; i++) {
			Node2D GhostsInstance = (Node2D)Ghosts.Instantiate();
			AddChild(GhostsInstance);	
			GhostsInstance.Position = new Vector2(marker[i].Position.X+10*i,  marker[i].Position.Y);
			}
		}
		public override void _Process(double delta){
			if(clearwaveunit >= RandomInteger){
			var ap = GetNode("AnimationPlayer") as AnimationPlayer;
			ap.Play("Dooropen");
			}}
		private void _on_warp_body_entered(Node2D body){
			if(clearwaveunit >= RandomInteger){
			if (body.IsInGroup("player")){
					body.Position = new Vector2(body.Position.X+2000, body.Position.Y);
					 clearwave += 1;
					 main.score +=1;
					GD.Print("Score"+ main.score);
				}}
		}

		private void _on_check_playerin_map_body_entered(Node2D body){	
				if (body.IsInGroup("player")){
				GD.Print("Playerinroom");
				playerinroom = true; }
		
			}
}

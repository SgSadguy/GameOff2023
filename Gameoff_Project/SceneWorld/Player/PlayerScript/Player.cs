using Godot;
using System;
using HealthSystem_Player;

public partial class Player : CharacterBody2D
{
	public const float Speed = 500.0f;
	public const float DashSpeed = 10000.0f;
	public bool CanDash = true;
	public override void _PhysicsProcess(double delta){
		Vector2 velocity = Velocity;

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero){
			velocity.X = direction.X * Speed;
			velocity.Y = direction.Y * Speed;
		}
		else{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, Speed);
		}
		if (Input.IsActionPressed("Dash") && CanDash == true){
			var Dt = GetNode("DashTimer") as Timer;
			velocity.X = direction.X * DashSpeed;
			velocity.Y = direction.Y * DashSpeed;
			CanDash = false;
			Dt.Start();
		}
		Velocity = velocity;
		MoveAndSlide();
		//Playerhealth functionhealth = new Playerhealth();
		//functionhealth.TakeDamage(100);
		 barfunction();
	}
	public void barfunction(){
	var hp = GetNode("HealthBar") as ProgressBar;
		hp.MaxValue = CurrentPlayerHealth.Maxhealth;
		hp.Value = CurrentPlayerHealth.health;
	
	var sc = GetNode("ScoreBar") as ProgressBar;
	sc.Value = main.score;
	
	}
	
	private void _on_dash_timer_timeout()
	{
		var Dt = GetNode("DashTimer") as Timer;
		Dt.Stop();
		CanDash = true;
		GD.Print("CanDash!");
	}
}

using Godot;
using System;

public partial class PlayerMovemnt : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float DashSpeed = 5000.0f;
	public const bool CanDashSpeed = true;
	
	public override void _PhysicsProcess(double delta)
	{
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

		// Dash Function
		if (Input.IsActionJustPressed("Dash")){
			velocity.X = direction.X * DashSpeed;
			velocity.Y = direction.Y * DashSpeed;
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}







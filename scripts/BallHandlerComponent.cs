using Godot;
using System;

public partial class BallHandlerComponent : Node
{

    [Export] private CharacterBody2D _entity;

    private Vector2 _direction = Vector2.Zero;
    public override void _Ready()
    {
        MovementAttributes.Instance.Speed = 300.0f;

        int XAxis = new Random().Next(0, 2) == 0 ? -1 : 1;
        int yAxis = -1;

        _direction = new Vector2(XAxis, yAxis);
    }

    public override void _PhysicsProcess(double delta)
    {
        _entity.Velocity = _direction / (float)delta;
        _entity.MoveAndSlide();
        BounceBall();
    }

    private void BounceBall()
    {
        float invertDirection = -_direction.Y;
        if (_entity.IsOnCeiling())
        {
            _direction.Y = invertDirection;
        }
    }


}

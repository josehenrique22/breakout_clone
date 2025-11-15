using Godot;
using System;

public partial class BallHandlerComponent : Node
{

    [Export] private CharacterBody2D _entity;
    [Export] private StateMachine _stateMachine;

    public override void _Ready()
    {
        InitializationValues();

    }

    public override void _PhysicsProcess(double delta)
    {
        _entity.Velocity = StatusBall.Instance.Direction / (float)delta;
        _entity.MoveAndSlide();
        _stateMachine.ChangeState(_entity);
    }

    private void InitializationValues()
    {
        StatusBall.Instance.Speed = 600f;

        int XAxis = new Random().Next(0, 2) == 0 ? -1 : 1;
        int yAxis = -1;

        StatusBall.Instance.Direction = new Vector2(XAxis, yAxis);
    }
}

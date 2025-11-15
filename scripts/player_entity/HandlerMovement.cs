using Godot;
using System;

public partial class HandlerMovement : Node
{
    [Export] private CharacterBody2D _entity;

    public override void _Ready()
    {
        InitializationNode();
    }

    public override void _PhysicsProcess(double delta)
    {
        const string leftDirection = "left";
        const string rightDirection = "right";
        MovementAttributes.Instance.Speed = 2.0f / (float)delta;
        var verticalDirection = MovementAttributes.Instance.XInput = Input.GetAxis(leftDirection, rightDirection);


        Vector2 direction = new Vector2(verticalDirection, 0.0f);
        Vector2 entityVelocity = direction;

        _entity.Velocity = entityVelocity * MovementAttributes.Instance.Speed;
        _entity.MoveAndSlide();

        GD.Print(entityVelocity);
    }

    private void InitializationNode()
    {
        if (_entity is null)
        {
            var rootPlayerNode = GetParent().GetParent().GetNode<CharacterBody2D>(".");
            _entity = rootPlayerNode;
        }
    }
}

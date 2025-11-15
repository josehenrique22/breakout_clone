using Godot;
using System;

public partial class StateMachine : Node
{
    public void ChangeState(CharacterBody2D _entity)
    {

        Vector2 direction = StatusBall.Instance.Direction;
        float invertDirection = -direction.Y;
        if (_entity.IsOnCeiling())
        {
            direction.Y = invertDirection;
        }

        if (_entity.IsOnWall())
        {
            direction.X = -direction.X;
        }

        if (_entity.IsOnFloor())
        {
            direction.Y = invertDirection;
        }

        StatusBall.Instance.Direction = direction;
    }
}

using Godot;
using System;

public partial class StatusBall : Node
{
    public static StatusBall Instance {get; set;}
    public float Speed { get; set; }
    public Vector2 Direction { get; set; }

    public override void _Ready()
    {
        Instance = this;
    }
    
}

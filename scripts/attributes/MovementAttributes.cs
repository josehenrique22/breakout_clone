using Godot;

public partial class MovementAttributes : Node
{
    public static MovementAttributes Instance {get; set;}
    public float Speed { get; set; }
    public float XInput { get; set; }

    public override void _Ready()
    {
        Instance = this;
    }
}

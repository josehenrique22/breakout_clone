using Godot;
using System;

public partial class SpawnScene : Node
{
    [Export] private PackedScene _spawnScene;
    [Export] private Camera2D _camera;

    public override void _Ready()
    {
        InstanciateScene();
    }

    private void InstanciateScene()
    {
        var instanceSpawnScene = _spawnScene.Instantiate();
        Node2D objectSpawnScene = instanceSpawnScene as Node2D;

        objectSpawnScene.Name = "BallScene";
        objectSpawnScene.Position = SpawnPosition();

        AddChild(objectSpawnScene);        
    }

    private Vector2 SpawnPosition()
    {
        return _camera.GetScreenCenterPosition();
    }
}

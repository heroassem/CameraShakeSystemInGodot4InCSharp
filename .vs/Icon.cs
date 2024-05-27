using Godot;
using System;

public partial class Icon : Sprite2D
{
    public CamerShake _CameraShake;
    public camer Camera;
    public override void _Ready()
    {
        _CameraShake = (CamerShake)GetNode("/root/D");
        Camera = (camer)GetNode("/root/C");
    }
    public override void _PhysicsProcess(double delta)
    {
        if (Input.IsActionJustPressed("Spase"))
        {
            Camera._CreateShake(100.0f, 1f);
        }
    }
}

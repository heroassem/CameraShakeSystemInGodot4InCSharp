using Godot;
using System;

public partial class test : Node2D
{
    public CamerShake _CameraShake;
    public override void _Ready()
    {
        _CameraShake = (CamerShake)GetNode("/root/D");
    }
    public override void _PhysicsProcess(double delta)
    {
        GD.Print(_CameraShake.camera);
    }
}

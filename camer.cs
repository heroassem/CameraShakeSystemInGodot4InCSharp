using Godot;
using System;

public partial class camer : Camera2D
{
    public CamerShake _CameraShake;
    public float _CameraShakeSpeed;
    public Timer _Timer;
    public float delta;

	public override void _Ready()
	{
        _Timer = GetNode<Timer>("Timer");
        _CameraShake = (CamerShake)GetNode("/root/D");
        _CameraShake.camera = this;
    }
    public override void _PhysicsProcess(double delta)
    {
        Offset = new Vector2((float)GD.RandRange(_CameraShakeSpeed, -_CameraShakeSpeed), (float)GD.RandRange(-_CameraShakeSpeed, _CameraShakeSpeed)) * (float)delta;
    }
    public void _CreateShake(float ShakePower, float ShakeTimer)
    {
        _CameraShakeSpeed = (int)ShakePower * 2;
        _Timer.WaitTime =  (float)ShakeTimer;
        _Timer.Start();
        GD.Print(_CameraShakeSpeed);
        GD.Print(_CameraShakeSpeed.GetType());
    }

    public void _on_timer_timeout()
    {
        _CameraShakeSpeed = 0;
        GD.Print("done");
    }

}
using Godot;
using System;

public partial class CameraZoom : Camera2D
{
	[Export(PropertyHint.Range, "0, 1")] private float _step = 0.1f;
    [Export] private float _minZoom = 0.1f;
    [Export] private float _maxZoom = 10.0f;

    public override void _Input(InputEvent @event)
    {
		if (@event.IsActionPressed("zoom_in"))
		{
            ZoomIn();
        }
        else if (@event.IsActionPressed("zoom_out"))
        {
            ZoomOut();
        }
    }

    private void ZoomIn() 
    {
        var new_zoom = Zoom.X + _step;
        if (new_zoom > _minZoom && new_zoom < _maxZoom) 
        {
            Zoom = new Vector2(new_zoom, new_zoom);
        }
    }

    private void ZoomOut()
    {
        var new_zoom = Zoom.X - _step;
        if (new_zoom > _minZoom && new_zoom < _maxZoom)
        {
            Zoom = new Vector2(new_zoom, new_zoom);
        }
    }
}

using Godot;
using System;

public partial class Info : Control
{
    [Export] private Label _label;

    public void Show(string[] info) 
    {
        Clear();

        for (int index = 0; index < info.Length; index++) 
        {
            _label.Text += info[index];
            if (index < info.Length - 1) 
            {
                _label.Text += "\n------------\n";
            }
        }
    }

    public void Show(string info)
    {
        Show([info]);
    }

    public void Clear() 
    {
        _label.Text = string.Empty;
    }
}

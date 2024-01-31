using System;


    public class Fan
{
    private const int SLOW = 1;
    private const int MEDIUM = 2;
    private const int FAST = 3;

    private int speed;
    private bool on;
    private double radius;
    private string color;

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Phương thức khởi tạo không tham số tạo đối tượng fan mặc định
    public Fan()
    {
        speed = SLOW;
        on = false;
        radius = 5;
        color = "blue";
    }

    // Phương thức ToString()
    public override string ToString()
    {
        if (on)
        {
            return $"Fan is on. Speed: {speed}, Color: {color}, Radius: {radius}";
        }
        else
        {
            return $"Fan is off. Color: {color}, Radius: {radius}";
        }
    }
}




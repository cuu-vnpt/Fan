class Program
{
    static void Main(string[] args)
    {
        // Tạo 2 đối tượng Fan
        Fan fan1 = new Fan();

        fan1.Radius = 10;       // Radius là 10
        fan1.Color = "yellow";   // Màu yellow
        fan1.On = true;         // Trạng thái bật

        Fan fan2 = new Fan();
       
        fan2.Radius = 5;          // Radius là 5
        fan2.Color = "blue";       // Màu blue
        fan2.On = false; 
     

        // Hiển thị thông tin các đối tượng
        Console.WriteLine("Fan 1: " + fan1.ToString());
        Console.WriteLine("Fan 2: " + fan2.ToString());
   
    }
}
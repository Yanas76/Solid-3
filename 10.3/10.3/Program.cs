//До помилкового результату призвело порушення принципу підстановки Лісков

class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : Rectangle
{
    public int Side
    {
        get { return Width; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;
            Console.WriteLine(rect.GetRectangleArea());
            Console.ReadKey();
        }
    }
}

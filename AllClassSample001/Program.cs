using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample001
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            MyShape rect = new MyRectangle() { Width = 10, Height = 10 };
            Console.WriteLine($"方形的面積是 {rect.GetArea()}");
            MyShape circle = new MyCircle() { Redius = 3 };
            Console.WriteLine($"圓形的面積是 {circle.GetArea()}");

            Console.ReadLine();
        }
    }
}

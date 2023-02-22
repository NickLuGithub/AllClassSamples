using System;

namespace AllClassSample001
{
    internal partial class Program
    {
        public class MyCircle : MyShape
        {
            public double Redius { get; set; }
            public override double GetArea()
            {
                return Math.PI * Math.Pow(Redius, 2);
            }
        }
    }
}

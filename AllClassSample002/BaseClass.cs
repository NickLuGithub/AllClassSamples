using System;

namespace AllClassSample002
{
    internal partial class Program
    {
        public class BaseClass
        {
            public virtual void Execute()
            {
                Console.WriteLine("BaseClass Execute Method");
            }
            public virtual void Begin()
            {
                Console.WriteLine("BaseClass Begin Method");
            }
        }
    }
}

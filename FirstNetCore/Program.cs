uusing System;

namespace FirstNetCoreApp
{
    public delegate int MathOpDelegate(int M,int N);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now.ToString());
            MathOpDelegate delAdd = Add;
            int result = delAdd(55,32);
            Console.WriteLine("Result of Add:\t"+ result.ToString());
        }
    }

    static int Add(int X, int Y){
        return X+Y;
    }

}


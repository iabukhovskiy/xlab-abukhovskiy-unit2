using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short s = 0;
            int i = 0;
            long l = 0;
            float f = 0;
            double d = 0;
            object o = d;
            double d2 = (double)o;

            i = (int)l; 
            l = i;
            ushort a = 15050;
            byte b = (byte)a; // урежетса

            TestFunc(ref i); // in ref out

            var c = 0f; // неопределённый тип
            if (o != null)
            {
                int i2 = Convert.ToInt32(o);
            }
            int[] array = new int[10000];

            List<int> list = new List<int>(80);

            void TestFunc(ref int j)
            {
                j = 10;
                Console.WriteLine(j);
            }

            void Exp()
            {
                int intt = 1;
                Console.WriteLine(intt);
                object obj = intt; // boxing
                Console.WriteLine(obj);
                int q = (int)obj; // unboxing
                Console.WriteLine(q); 
            }

            Exp();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Mathematical_Op obj = new Mathematical_Op();
            Mathematical_Op obj2 = new Mathematical_Op();
            obj2 = obj;
            Console.WriteLine("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Object 1");
            int res=obj.sum(x, y);
            Console.WriteLine("Result of sum:" + res);
             res=obj.sub(x, y);
            Console.WriteLine("Result of sub:" + res);
            res =obj.div(x, y);
            Console.WriteLine("Result of div:" + res);
            res =obj.mul(x, y);
            Console.WriteLine("Result of mul:" + res);


            mis obj3 = new mis();
            obj3.Ss();


            Console.WriteLine("Object 2");
            res = obj2.sum(x, y);
            Console.WriteLine("Result of sum:" + res);
            res = obj2.sub(x, y);
            Console.WriteLine("Result of sub:" + res);
            res = obj2.div(x, y);
            Console.WriteLine("Result of div:" + res);
            res = obj2.mul(x, y);
            Console.WriteLine("Result of mul:" + res);


            b obj4 = new b();
            b.c obj5 = new b.c();
            obj5.sum(5,6);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的声明
{
    class MyHelloWorld
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
        public void CSayHello()
        {
            Console.WriteLine("你好！");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /////静态的方法，无需实例化。在编译已经分配空间，编译完成后释放
            MyHelloWorld.SayHello();
            ////非静态，需要将类实例化形成对象。然后调用
            MyHelloWorld myHelloWorld = new MyHelloWorld();
            myHelloWorld.CSayHello();
            /////释放对象的内存空间
            myHelloWorld = null;
            Console.ReadKey();
        }
    }
}

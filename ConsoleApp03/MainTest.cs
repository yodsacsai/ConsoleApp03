using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp03
{
    class MainTest
    {
        static void Main(string[] args)
        {
            Test1 ob1 = new Test1();
            Test1 ob2 = new Test1();
            Test1 ob3 = new Test1();
            Test1 ob4 = new Test1();
            Test2 ob5 = new Test2();

            Console.WriteLine(ob1.NumStu);
            ob1.SalaryStu = 800.755;

            ob5.showA();

            Test5 sau1 = new Test5();
            //Test3 sau2 = new Test3(); abstract class new ไม่ได้
            //Test4 sau3 = new Test4(); interface class new ไม่ได้




        }
    }
}

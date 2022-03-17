using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp03
{
    class Test2 : Test1
    {
        private string nameStu;


        public string NameStu
        {
            get { return nameStu; }
            set { nameStu = value; }
        }

        public void showB()
        {
            Console.WriteLine("BBB");
        }

        //Overiding method ด้วยคุณสมบัติ Polymorpims
        public void showA()
        {
            Console.WriteLine("wow wow wow");
        }

    }
}

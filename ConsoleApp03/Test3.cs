using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp03
{
    
    abstract class Test3 //abstract class
    {
        public int score;
        public void showWow()
        {

        }

        public abstract void showHi();

    }

    interface Test4 //interface class
    {

        public abstract void showA();
        public abstract void showB();
        public int showC();
        public void showD();
    }

    class Test5 //normal class
    {

    }
}

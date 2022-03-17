using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp03
{
    class Test1
    {
        //field, attribute, data
        private int numStu = 20;
        private double salaryStu;
        public int scoreStu;


        public int NumStu
        {
            get { return numStu; }
            set { numStu = value; }
        }

        public double SalaryStu
        {
            get { return salaryStu; }
            set { salaryStu = value; }
        }

        //contructor
        //public Test1(double salaryStu)
        //{
        //    this.salaryStu = salaryStu;
        //    Console.WriteLine("Hello...");
        //}



        //method

        public void showA()
        {
            Console.WriteLine("AAA");
        }


        public int calNumber(int x)
        {
            return 20 * x;
        }

       

       
    }
}

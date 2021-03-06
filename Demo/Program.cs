﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Foo
    {
        public string Value { get; set; }

        public Foo()
        {
            Console.WriteLine("Foo");
        }

        public Foo(string value)
        {
            Value = value;
        }

        public string F()
        {
            return "Shirt";
        }

        public virtual int G()
        {
            return 2;
        }    

        public override string ToString()
        {
            return Value;
        }
    }



    class Bar : Foo
    {
        public string MyValue { get; set; }

        public Bar()
        {
            Console.WriteLine("Bar");
        }

        public Bar(string value)
            : base(value + "Blah")
        {
            MyValue = value; 
        }

        public new string F()
        {
            return "Pants";
        }

        public override int G()
        {
            return 4;
        }

        public int G(int n)
        {
            return base.G() + this.G() + n;
        }

        public override string ToString()
        {
            return MyValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Demo 1
            Console.WriteLine("Demo 1:\n");

            var a = new Bar();          // Foo, Bar
            Console.WriteLine(a.F());   // Pants
            Console.WriteLine(a.G());   // 4


            // Demo 2
            Console.WriteLine("\n\nDemo 2:\n");

            var b = new Bar();       
            Console.WriteLine(b.F());   
            Console.WriteLine(b.G());
            Console.WriteLine(b.G(3));


            // Demo 3
            Console.WriteLine("\n\nDemo 1:\n");

            var list = new List<object>();
            list.Add(new Foo("Bits"));
            list.Add(new Bar("Bytes"));
            list.Add(17);
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }

            // Bits
            // Bytes
            // 17




        }
    }
}

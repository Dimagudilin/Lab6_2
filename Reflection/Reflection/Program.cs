using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class _Reflection
    {
        class _3DPoint
        {
            //x-coordinate
            private double _xc;
            public double xc
            {
                get { return _xc; }
                set { _xc = value; }
            }

            //y-coordinate
            private double _yc;
            public double yc
            {
                get { return _yc; }
                set { _yc = value; }
            }

            //z-coordinate
            private double _zc;
            public double zc
            {
                get { return _zc; }
                set { _zc = value; }
            }

            /// <summary>
            /// Default constructor
            /// </summary>
            public _3DPoint()
            {
                xc = 0;
                yc = 0;
                zc = 0;
            }

            /// <summary>
            /// Constructor for a point with equal coords "a"
            /// </summary>
            /// <param name="a"></param>
            public _3DPoint(double a)
            {
                xc = a;
                yc = a;
                zc = a;
            }

            /// <summary>
            /// Constructor for a point with different coords
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="z"></param>
            public _3DPoint(double x, double y, double z)
            {
                xc = x;
                yc = y;
                zc = z;
            }

            /// <summary>
            /// Method of reversing point coords
            /// </summary>
            void Reverse()
            {
                xc = -xc;
                yc = -yc;
                zc = -zc;
            }
        }

        static void Main(string[] args)
        {
            _3DPoint obj = new _3DPoint();
            Type t = obj.GetType();
            Console.WriteLine("\nИнформация о типе:");
            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace); Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);
            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
                Console.WriteLine(x);
            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
                Console.WriteLine(x);
            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
                Console.WriteLine(x);
            Console.WriteLine("\nПоля данных (public):");
            foreach (var x in t.GetFields())
                Console.WriteLine(x);
            Console.WriteLine("\nForInspection реализует IComparable -> " + t.GetInterfaces().Contains(typeof(IComparable)));

            Console.ReadKey();
        }
    }
}

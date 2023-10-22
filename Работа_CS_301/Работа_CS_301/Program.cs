using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using static Работа_CS_301.Program;

namespace Работа_CS_301
{
    internal class Program
    {

        public delegate void dlgSet(int a, int b);

        public delegate void dlgPointOp(Point2 a, Point2 b);

        public delegate void dlgPointOp1(Point2 a);

        public delegate void WashDelegate(Car car);

        static void PointIncrement(Point2 a)
        {
            a.x += 1;
            a.y += 1;
        }

        public class Point
        {
            public int x;
            public int y;

            public Point()
            {
                x = 0;
                y = 0;
            }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void SetValues(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return "(" + x.ToString() + ", " + y.ToString() + ")";
            }

        }

        public class Fraction
        {
            protected int num;
            protected int den;

            public Fraction() 
            {
                num = 0;
                den = 1;
            }

            public Fraction(int num, int den)
            {
                this.num = num;
                this.den = den;
            }

            public void SetValues(int num, int den)
            {
                this.num = num;
                this.den = den;
            }

            public override string ToString()
            {
                return "(" + num.ToString() + ", " + den.ToString() + ")";
            }
        }

        public class Point2
        {
            public int x;
            public int y;

            public Point2()
            {
                x = 0;
                y = 0;
            }

            public Point2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static void pointAdd(Point2 a, Point2 b)
            {
                a.x += b.x; 
                a.y += b.y;
            }

            public static void pointSub(Point2 a, Point2 b)
            {
                a.x -= b.x;
                a.y -= b.y;
            }

            public void Operatin(dlgPointOp d, Point2 b)
            {
                d(this, b);
            }


            public override string ToString()
            {
                return "(" + x.ToString() + ", " + y.ToString() + ")";
            }
        }

        class Points : IEnumerable
        {
            private Point2[] points;

            public Points()
            {
                points = new Point2[1];
                points[0] = new Point2();
            }

            public Points(int number)
            {
                points = new Point2[number];
                for (int i = 0; i < number; i++)
                {
                    points[i] = new Point2();
                }
            }

            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < points.Length; i++)
                {
                    yield return points[i];
                }
            }

            public Point2 this[int index]
            {
                get
                {
                    return points[index];
                }
            }

            public void Operation(dlgPointOp d, Point2 b)
            {
                foreach (Point2 p in points)
                {
                    d(p, b);
                }
            }

            public void Operation1(dlgPointOp1 d)
            {
                foreach(Point2 p in points)
                {
                    d(p);
                }
            }

        }

        public class Car
        {
            public string Model;

            public Car() 
            {
                Model = string.Empty;
            }

            public Car(string model)
            {
                Model = model;
            }
        }

        public class Garage
        {
            public Car[] cars;

            public Garage()
            {
                cars = new Car[1];
                cars[0] = new Car();
            }

            public Garage(int number)
            {
                cars = new Car[number];
                for (int i = 0; i < number; i++)
                {
                    cars[i] = new Car();
                }
            }

            public Car this[int index]
            {
                get
                {
                    return cars[index];
                }
                set
                {
                    cars[index] = value;
                }
            }
        }

        public class Washer
        {
            public Washer() {}

            public static void Wash(Car car)
            {
                Console.WriteLine($"Моем автомобиль {car.Model}");
            }
        }



        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 1);
            //Point p2 = new Point(2, 2);

            //Fraction f1 = new Fraction(1, 1);

            //dlgSet d1 = p1.SetValues;
            //d1 += p2.SetValues;
            //d1 += f1.SetValues;

            //Console.WriteLine("p1" + p1.ToString());
            //Console.WriteLine("p2" + p2.ToString());
            //Console.WriteLine("f1" + f1.ToString());
            //Console.WriteLine("//////////////////");

            //d1(6, 6);


            //Console.WriteLine("p1" + p1.ToString());
            //Console.WriteLine("p2" + p2.ToString());
            //Console.WriteLine("f1" + f1.ToString());
            //Console.WriteLine("//////////////////");

            //d1 -= p1.SetValues;
            //d1(7,7);

            //Console.WriteLine("p1" + p1.ToString());
            //Console.WriteLine("p2" + p2.ToString());
            //Console.WriteLine("f1" + f1.ToString());
            //Console.WriteLine("//////////////////");

            //dlgSet d2 = p2.SetValues;
            //dlgSet df = f1.SetValues;
            //d2(4,4);
            //df(5,5);

            //Console.WriteLine("p1" + p1.ToString());
            //Console.WriteLine("p2" + p2.ToString());
            //Console.WriteLine("f1" + f1.ToString());
            //Console.WriteLine("//////////////////");

            //d1 -= p1.SetValues;
            //d1 -= f1.SetValues;

            //d1 = d2 + df + p1.SetValues;
            //d1(9, 9);

            //Console.WriteLine("p1" + p1.ToString());
            //Console.WriteLine("p2" + p2.ToString());
            //Console.WriteLine("f1" + f1.ToString());
            //Console.WriteLine("////////////////////////////////////");

            //Point2 a = new Point2(3, 3);
            //Point2 b = new Point2(2, 2);
            //Point2 c = new Point2(1, 1);

            //dlgPointOp add = Point2.pointAdd;
            //dlgPointOp sub = Point2.pointSub;

            ////a.Operatin(add, b);
            ////Console.WriteLine("a" + a.ToString());

            ////a.Operatin(sub, c);
            ////Console.WriteLine("a" + a.ToString());


            //Points po = new Points(3);

            //po.Operation(add, c);

            //foreach (Point2 p in po)
            //{
            //    Console.WriteLine("p" + p.ToString());
            //}

            //dlgPointOp1 inc = PointIncrement;

            //po.Operation1(inc);

            //foreach (Point2 p in po)
            //{
            //    Console.WriteLine("p" + p.ToString());
            //}

            //Console.WriteLine("////////////////////////////////////");

            // Создаем несколько автомобилей
            Car car1 = new Car("Мерседес");
            Car car2 = new Car("BMW");
            Car car3 = new Car("Audi");

            // Создаем гараж 
            Garage garage = new Garage(3);

            // Добавляем автомобили в гараж
            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            // Создаем мойку автомобилей
            Washer washer = new Washer();

            // Создаем делегат
            WashDelegate wd = Washer.Wash;

            // Моем все машины из гаража в мойке
            wd(garage[0]);
            wd(garage[1]);
            wd(garage[2]);
        }
    }
}
